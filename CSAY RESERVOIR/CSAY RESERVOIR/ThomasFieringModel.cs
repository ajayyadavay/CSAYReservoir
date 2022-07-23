using MathNet.Numerics.Distributions;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Accord.Statistics.Distributions.Univariate;

namespace CSAY_RESERVOIR
{
    public partial class FrmThomasFieringModel : Form
    { 
        public static int NumberOfData, NumberOfData1, NumberOfDataVal, Start, StartVal; 
        bool ReadInputObsFlow = true;
        bool PredictFlow = true;
        int i,j;
        string[] MonthName = {"JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC", "JAN" };
        string path;
        //string[] ParameterHeading = { "Mean", "Std. Dev.", "Regression Coeff.", "Correlation Coeff." };

        double[] MinMonthlyFlows = new double[100]; 

        double[] Mean = new double[100]; 
        double[] StandardDeviation = new double[100]; //S
        double[] RegressionCoeff = new double[100]; //B
        double[] CorrelationCoeff = new double[100]; //r
        double[,] MonthlyInputFlow = new double[20, 500]; 
        double[,] MonthlyInputFlowForMin = new double[20, 500];
        double InitialGuessFlow;

        public static int PredictNumberOfYear, PredictStartYear;
        int n;
        int cell_val, month_no;

        double SqrRoot;
        public static double[] PredictedFlow = new double[3000]; //Y
        double[] U = new double[3000]; //Random Normal Variate ~ N(0,1)
        double[] Optimum_U = new double[3000]; //Optimum Random Normal Variate ~ N(0,1)
        double MinimumFlow;

        public static double[] ObservedFlow = new double[3000];
        public static double[] ObservedFlowVal = new double[3000];
        int Obs_index = 0, Obs_index_val = 0;

        public static double[] MeanY1 = new double[100];
        public static double[] MeanY2 = new double[100];
        public static double[] StdDev1 = new double[100];
        public static double[] StdDev2 = new double[100];
        public static double[] RegCoef1 = new double[100];
        public static double[] RegCoef2 = new double[100];
        public static double[] CorCoef1 = new double[100];
        public static double[] CorCoef2 = new double[100];

        public static double MR2, StdR2, RegR2, CorrR2, MNash, StdNash, RegNash, CorrNash;

        // declaring variables for Calculating Nash_Eff, R Squared
        int N, totalN, N_obs, totalN_obs, N_obs_val, totalN_obs_val;
         
        int[] X_axis = new int[3000];
        int[] X_axis_obs = new int[3000];
        int[] X_axis_obs_val = new int[3000];

        double[] Y_axis_predict = new double[3000];
        double[] Y_axis_Val = new double[3000];

        double sum, Deviation_from_mean_Obs, Deviation_from_mean_Predict, Mean_of_Observed;
        double Sum_Obs_minus_Predict;
        public static double R_Square, nash, R_Square_val, nash_val;

        int diff_in_year, diff_in_year_val;

        double Best_R_Sqare = 0.6, Best_nash = 0.5;
        bool Best_Model_Found = false;
        double CorrCoeffFinal, CoD;
        public double[] Arr1 = new double[3000];
        public double[] Arr2 = new double[3000]; 
        // End of declaring variables for Calculating Nash_Eff, R Squared

        public FrmThomasFieringModel()
        {
            InitializeComponent();
        }
        
        private void FrmThomasFieringModel_Load(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Maximized;
                ReadInputObsFlow = true;
                Generaterows();  // For Input datagridview and parameters gridview
                SetGridColorAndFont();
            }
            catch
            {

            }
        }

        public void Generaterows() //for input and parameter datagridview
        {
            try
            {
                NumberOfData = Convert.ToInt32(TxtNumberOfData.Text);
                NumberOfData1 = NumberOfData;
                Start = Convert.ToInt32(TxtStart.Text);
            }
            catch
            {

            }
                // input datagridview
            dataGridView.Rows.Clear();

            for (i = 0; i <= 12; i++)
            {
                 i = dataGridView.Rows.Add();
                 dataGridView.Rows[i].Cells[0].Value = MonthName[i];
            }

            // validation datagridview
            dataGridView.Rows.Clear();

            for (i = 0; i <= 12; i++)
            {
                i = dataGridViewVal.Rows.Add();
                dataGridViewVal.Rows[i].Cells[0].Value = MonthName[i];
            }

            // parameter datagridview
            dataGridViewParameters.Rows.Clear();
            for (i = 0; i <= 12; i++)
            {
                i = dataGridViewParameters.Rows.Add();
                dataGridViewParameters.Rows[i].Cells[0].Value = MonthName[i];
            }
        }
        

        public void SetGridColorAndFont()
        {
            // for input datagridview
            dataGridView.DefaultCellStyle.Font = new Font("Comic Sans MS", 11);
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            //dataGridView.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // for parameter datagridview
            dataGridViewParameters.DefaultCellStyle.Font = new Font("Comic Sans MS", 11);
            dataGridViewParameters.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewParameters.DefaultCellStyle.SelectionForeColor = Color.White;
            //dataGridView.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridViewParameters.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // for prediction datagridview
            dataGridViewPredict.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            dataGridViewPredict.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewPredict.DefaultCellStyle.SelectionForeColor = Color.White;
           // dataGridViewPredict.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewPredict.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // for validation datagridview
            dataGridViewVal.DefaultCellStyle.Font = new Font("Comic Sans MS", 11);
            dataGridViewVal.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewVal.DefaultCellStyle.SelectionForeColor = Color.White;
            // dataGridViewPredict.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewVal.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;


        }

        private void TxtStart_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GenerateColumns();
            }
            catch
            {

            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout fabout = new FrmAbout();
            fabout.Show();
        }

        private void TxtPredictYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BtnPredictFlow.Enabled = true;
                PredictFlow = true;
                ReadInputObsFlow = true;
                GeneratePredictRows();

            }
            catch
            {

            }
        }

        private void TxtPredictStartYear_TextChanged(object sender, EventArgs e)
        {
            int FlowDecYear;
            try
            {
                BtnPredictFlow.Enabled = true;
                PredictFlow = true;
                ReadInputObsFlow = true;
                FlowDecYear = Convert.ToInt32(TxtPredictStartYear.Text);
                LblInitialGuessFlow.Text = "Flow of Dec:" + (FlowDecYear-1);
                GeneratePredictRows();

                TxtInitialGuessFlow.Text = "";
            }
            catch
            {

            }
        }

        private void IMPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "Excel Sheet(*.xlsx)|*.xlsx|Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            openfiledialog1.FilterIndex = 1;

            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openfiledialog1.FileName;
            }
            else if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            dataGridView.DataSource = null;

            for (int j = 0; j < dataGridView.Rows.Count - 1; j++)
            {
                dataGridView.Rows.RemoveAt(j);
                j--;
                while (dataGridView.Rows.Count == 0)
                    continue;
            }

            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbooks workbooks = app.Workbooks;

            Excel.Workbook workbook = workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            try
            {
                int rcount = 13;

                int i = 0;
                int k;
                for (i = 0; i < rcount; i++)
                {
                    dataGridView.Rows.Add();
                    for(k = 0; k <= NumberOfData; k++)
                    {
                        dataGridView.Rows[i].Cells[k].Value = worksheet.Cells[i + 3, k+1].value;
                    }
                    //worksheet.cells[rows, column].value; here rows column starts from 1 and rows starts from 1 of excel.
                }

                workbook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(worksheet);
                // Marshal.ReleaseComObject(rcount);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                workbook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(worksheet);
            }
            MessageBox.Show("IMPORT COMPLETED SUCESSFULLY !");
        }

        private void PredictFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PredictFlowByTHF();
            }
            catch
            {

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            FrmTFMAbout fthabout = new FrmTFMAbout();
             fthabout.Show();
        }

        private void BtnPredictFlow_Click(object sender, EventArgs e)
        {
            try
            {
                ReadInputObsFlow = false;
                PredictFlowByTHF();
                BtnPredictFlow.Enabled = false;
            }
            catch
            {

            }
        }

        private void BtnCalcPara_Click(object sender, EventArgs e)
        {
            try
            {
                CalculateParameters();
            }
            catch
            {

            }

        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "Excel Sheet(*.xlsx)|*.xlsx|Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            openfiledialog1.FilterIndex = 1;

            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openfiledialog1.FileName;
            }
            else if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            dataGridView.DataSource = null;

            for (int j = 0; j < dataGridView.Rows.Count - 1; j++)
            {
                dataGridView.Rows.RemoveAt(j);
                j--;
                while (dataGridView.Rows.Count == 0)
                    continue;
            }

            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbooks workbooks = app.Workbooks;

            Excel.Workbook workbook = workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            try
            {
                int rcount = 13;

                int i = 0;
                int k;
                for (i = 0; i < rcount; i++)
                {
                    dataGridView.Rows.Add();
                    for (k = 0; k <= NumberOfData; k++)
                    {
                        dataGridView.Rows[i].Cells[k].Value = worksheet.Cells[i + 3, k + 1].value;
                    }
                    //worksheet.cells[rows, column].value; here rows column starts from 1 and rows starts from 1 of excel.
                }

                workbook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(worksheet);
                // Marshal.ReleaseComObject(rcount);

                ReadInputObsFlow = true;

                Obs_index = 0;
                NumberOfData1 = Convert.ToInt32(TxtNumberOfData.Text);
                for (i = 0; i < NumberOfData1; i++)
                {
                    for (j = 0; j < 12; j++)
                    {
                        ObservedFlow[Obs_index] = Convert.ToDouble(dataGridView.Rows[j].Cells[i + 1].Value);
                        Obs_index++;
                    }
                }

                MinimumFlow = ObservedFlow[0];
                for(i = 1; i < NumberOfData1 * 12; i++)
                {
                    if(MinimumFlow > ObservedFlow[0]) 
                    {
                        MinimumFlow = ObservedFlow[i];
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                workbook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(worksheet);
            }
            MessageBox.Show("IMPORT COMPLETED SUCESSFULLY !");
        }

        private void AllGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                CopyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "THOMAS FIERING METHOD " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 11]).Value = "Nash Efficiency";
                ((Excel.Range)xlWorkSheet.Cells[3, 11]).Value = "R squre";

                ((Excel.Range)xlWorkSheet.Cells[1, 12]).Value = "Calibration";
                ((Excel.Range)xlWorkSheet.Cells[1, 13]).Value = "Validation";
                ((Excel.Range)xlWorkSheet.Cells[1, 14]).Value = "Mean";
                ((Excel.Range)xlWorkSheet.Cells[1, 15]).Value = "StdDev";
                ((Excel.Range)xlWorkSheet.Cells[1, 16]).Value = "Reg Coeff";
                ((Excel.Range)xlWorkSheet.Cells[1, 17]).Value = "Corr Coeff";

                ((Excel.Range)xlWorkSheet.Cells[2, 12]).Value = nash.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[2, 13]).Value = nash_val.ToString("0.0000"); 
                ((Excel.Range)xlWorkSheet.Cells[2, 14]).Value = MNash.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[2, 15]).Value = StdNash.ToString("0.0000"); 
                ((Excel.Range)xlWorkSheet.Cells[2, 16]).Value = RegNash.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[2, 17]).Value = CorrNash.ToString("0.0000");

                ((Excel.Range)xlWorkSheet.Cells[3, 12]).Value = R_Square.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[3, 13]).Value = R_Square_val.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[3, 14]).Value = MR2.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[3, 15]).Value = StdR2.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[3, 16]).Value = RegR2.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[3, 17]).Value = CorrR2.ToString("0.0000");

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[6, 1];

                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                // xlWorkBook.Close();
                //  xlexcel.Quit();
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);

                MessageBox.Show("Export Completed Sucessfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void CopyAlltoClipboard()
        {
            dataGridViewPredict.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewPredict.MultiSelect = true;
            dataGridViewPredict.SelectAll();
            DataObject dataObj = dataGridViewPredict.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void SelectedGridOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                CopySelectedtoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "THOMAS FIERING METHOD " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 11]).Value = "Nash Efficiency";
                ((Excel.Range)xlWorkSheet.Cells[3, 11]).Value = "R squre";

                ((Excel.Range)xlWorkSheet.Cells[1, 12]).Value = "Calibration";
                ((Excel.Range)xlWorkSheet.Cells[1, 13]).Value = "Validation";
                ((Excel.Range)xlWorkSheet.Cells[1, 14]).Value = "Mean";
                ((Excel.Range)xlWorkSheet.Cells[1, 15]).Value = "StdDev";
                ((Excel.Range)xlWorkSheet.Cells[1, 16]).Value = "Reg Coeff";
                ((Excel.Range)xlWorkSheet.Cells[1, 17]).Value = "Corr Coeff";

                ((Excel.Range)xlWorkSheet.Cells[2, 12]).Value = nash.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[2, 13]).Value = nash_val.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[2, 14]).Value = MNash.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[2, 15]).Value = StdNash.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[2, 16]).Value = RegNash.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[2, 17]).Value = CorrNash.ToString("0.0000");

                ((Excel.Range)xlWorkSheet.Cells[3, 12]).Value = R_Square.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[3, 13]).Value = R_Square_val.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[3, 14]).Value = MR2.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[3, 15]).Value = StdR2.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[3, 16]).Value = RegR2.ToString("0.0000");
                ((Excel.Range)xlWorkSheet.Cells[3, 17]).Value = CorrR2.ToString("0.0000");

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[6, 1];

                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                // xlWorkBook.Close();
                //  xlexcel.Quit();
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);

                MessageBox.Show("Export Completed Sucessfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void CopySelectedtoClipboard()
        {
            dataGridViewPredict.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewPredict.MultiSelect = true;
            //dataGridViewMusking.SelectAll();
            DataObject dataObj = dataGridViewPredict.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void CopyFromGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CopySelectedtoClipboard();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void CopySelectedtoClipboard2()
        {
            dataGridViewParameters.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewParameters.MultiSelect = true;
            //dataGridViewMusking.SelectAll();
            DataObject dataObj = dataGridViewParameters.GetClipboardContent(); 
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void CopyAlltoClipboard2()
        {
            dataGridViewParameters.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewParameters.MultiSelect = true;
            dataGridViewParameters.SelectAll(); 
            DataObject dataObj = dataGridViewParameters.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void toolExportAllStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {

                CopyAlltoClipboard2();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "THOMAS FIERING METHOD " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[3, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                // xlWorkBook.Close();
                //  xlexcel.Quit();
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);

                MessageBox.Show("Export Completed Sucessfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void toolExportSelectedStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                CopySelectedtoClipboard2();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "THOMAS FIERING METHOD " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[3, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                // xlWorkBook.Close();
                //  xlexcel.Quit();
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);

                MessageBox.Show("Export Completed Sucessfully.");

             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void EXPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnGraph_Click(object sender, EventArgs e)
        {
            FrmGraph fGraph = new FrmGraph();
            fGraph.Show();

        }
        
        private void RUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CalculateParameters();
            }
            catch
            {

            }
        }

        private void TxtNumberOfData_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GenerateColumns();
            }
            catch
            {

            }
        }

        private void BtnOptimize_Click(object sender, EventArgs e)
        {
            int itr, MaxIterations, tempMaxIterations;
            int tempPredictYear=1;
            try
            {
                Best_Model_Found = false;
                MaxIterations = Convert.ToInt32(TxtMaxIterations.Text);
                tempPredictYear = Convert.ToInt32(TxtPredictYear.Text);
                tempMaxIterations = MaxIterations;

                for(itr = 1; itr <= MaxIterations; itr++)
                {
                    TxtPredictYear.Text = "";
                    TxtPredictYear.Text = tempPredictYear.ToString();
                    Best_R_Sqare = 0.6;
                    BtnCalcPara_Click(sender, e);
                    BtnGenerateRandom_Click(sender, e);
                    BtnPredictFlow_Click(sender, e); 

                }
                /*if (Best_R_Square_Found == false && itr == MaxIterations && MaxIterations<= 2 * tempMaxIterations)
                {
                    MaxIterations = MaxIterations + 50;
                }*/
                if(Best_Model_Found == true)
                {
                    MessageBox.Show("Optimization Completed for iterations = " + MaxIterations + "\nBest Model Found !");
                }
                else if(Best_Model_Found == false)
                {
                    MessageBox.Show("Best Model NOT Found for iterations = " + MaxIterations + "\nIncrease Maximum Iterations");
                }
               
            }
            catch
            {

            }
        }

        private void BtnUseOptimum_Click(object sender, EventArgs e)
        {
            int OptU;
            int tempPredictYear = 1;
            try
            {
                tempPredictYear = Convert.ToInt32(TxtPredictYear.Text);
                TxtPredictYear.Text = "";
                TxtPredictYear.Text = tempPredictYear.ToString();
                BtnCalcPara_Click(sender, e);
                //BtnGenerateRandom_Click(sender, e);
                for(OptU = 0; OptU < PredictNumberOfYear * 12; OptU++)
                {
                    //U[OptU] = Optimum_U[OptU];
                    dataGridViewPredict.Rows[OptU].Cells["ColU"].Value = Optimum_U[OptU].ToString();
                }
                BtnPredictFlow_Click(sender, e);
            }
            catch
            {

            }
        }

        private void TxtNumberOfData_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                GenerateColumns();
            }
            catch
            {

            }
        }

        private void TxtInitialGuessFlow_TextChanged(object sender, EventArgs e)
        {

        }

        public void GenerateColumns()
        {
            int years=0;
            try
            {
                NumberOfData = Convert.ToInt32(TxtNumberOfData.Text);
                Start = Convert.ToInt32(TxtStart.Text);
            
                //dataGridView.Rows.Clear();
                dataGridView.ColumnCount = NumberOfData + 1;

                for (i = 1; i <= NumberOfData; i++)
                {
                    //i = dataGridView.Columns.Add();
                    if(i==1)
                    {
                        dataGridView.Columns[i].Name = Start.ToString();
                        years = Start;
                        dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dataGridView.Columns[i].Width = 65;
                    }
                    else
                    {
                        years = Start + i-1;
                        dataGridView.Columns[i].Name = years.ToString();
                        dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dataGridView.Columns[i].Width = 65;
                    } 
                }
                /*int index = 0;
                for(j=NumberOfData + 1; j<NumberOfData + 5;j++)
                {
                    dataGridView.Columns[j].Name = ParameterHeading[index];
                    dataGridView.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable;
                    index++;
                }*/
            }
            catch
            {

            }
        }
        
        public void GenerateColumnsForValidation()
        {
            int years = 0;
            try
            {
                NumberOfDataVal = Convert.ToInt32(TxtNumberOfDataVal.Text);
                StartVal = Convert.ToInt32(TxtStartVal.Text);

                //dataGridView.Rows.Clear();
                dataGridViewVal.ColumnCount = NumberOfDataVal + 1;

                for (i = 1; i <= NumberOfDataVal; i++)
                {
                    //i = dataGridView.Columns.Add();
                    if (i == 1)
                    {
                        dataGridViewVal.Columns[i].Name = StartVal.ToString();
                        years = StartVal;
                        dataGridViewVal.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dataGridViewVal.Columns[i].Width = 65;
                    }
                    else
                    {
                        years = StartVal + i - 1;
                        dataGridViewVal.Columns[i].Name = years.ToString();
                        dataGridViewVal.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dataGridViewVal.Columns[i].Width = 65;
                    }
                }
               
            }
            catch
            {

            }
        }

        private void TxtNumberOfDataVal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GenerateColumnsForValidation();
            }
            catch
            {

            }
        }

        private void TxtStartVal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GenerateColumnsForValidation();
            }
            catch
            {

            }
        }

        private void BtnMean_Click(object sender, EventArgs e)
        {
            MeanGraph FrmMeangraph = new MeanGraph();
            FrmMeangraph.Show();
        }

        private void BtnStdDev_Click(object sender, EventArgs e)
        {
            StdDevGraph fstd = new StdDevGraph();
            fstd.Show();
        }

        private void BtnRegCoeff_Click(object sender, EventArgs e)
        {
            RegCoeffGraph freg = new RegCoeffGraph();
            freg.Show();
        }

        private void BtnCorrCoeff_Click(object sender, EventArgs e)
        {
            CorrCoeffGraph fcor= new CorrCoeffGraph();
            fcor.Show();
        }

        private void BtnImportVal_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "Excel Sheet(*.xlsx)|*.xlsx|Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            openfiledialog1.FilterIndex = 1;

            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openfiledialog1.FileName;
            }
            else if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            dataGridViewVal.DataSource = null;

            for (int j = 0; j < dataGridViewVal.Rows.Count - 1; j++)
            {
                dataGridViewVal.Rows.RemoveAt(j);
                j--;
                while (dataGridViewVal.Rows.Count == 0)
                    continue;
            }

            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbooks workbooks = app.Workbooks;

            Excel.Workbook workbook = workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            try
            {
                int rcount = 13;

                int i = 0;
                int k;
                for (i = 0; i < rcount; i++)
                {
                    dataGridViewVal.Rows.Add();
                    for (k = 0; k <= NumberOfDataVal; k++)
                    {
                        dataGridViewVal.Rows[i].Cells[k].Value = worksheet.Cells[i + 3, k + 1].value;
                    }
                    //worksheet.cells[rows, column].value; here rows column starts from 1 and rows starts from 1 of excel.
                }

                workbook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(worksheet);
                // Marshal.ReleaseComObject(rcount);

                //ReadInputObsFlow = true;

                Obs_index_val = 0;
                NumberOfDataVal = Convert.ToInt32(TxtNumberOfDataVal.Text);
                for (i = 0; i < NumberOfDataVal; i++)
                {
                    for (j = 0; j < 12; j++)
                    {
                        ObservedFlowVal[Obs_index_val] = Convert.ToDouble(dataGridViewVal.Rows[j].Cells[i + 1].Value);
                        Obs_index_val++;
                    }
                }

                //Find minimum monthly flow
                NumberOfDataVal = Convert.ToInt32(TxtNumberOfDataVal.Text);
                for (i = 0; i < 12; i++) //for 12 rows of month
                {
                    for (j = 1; j <= NumberOfData1; j++)   // represents number of years in each rows
                    {
                        MonthlyInputFlowForMin[i, j] = Convert.ToDouble(dataGridView.Rows[i].Cells[j].Value);// input from datagridview
                    }
                }
                 
                for(i=0;i<12;i++)
                {
                    MinMonthlyFlows[i] = MonthlyInputFlowForMin[i, 1]; // minimum flow is initialized to first year flow
                }                          // then in the loop given below, minimum monthly flow is obtained

                for (i = 0; i < 12; i++) //for 12 rows of month 
                {
                    for (j = 1; j <= NumberOfData1; j++)   // represents number of years in each rows
                    {
                        if(MinMonthlyFlows[i] > MonthlyInputFlowForMin[i,j])
                        {
                            MinMonthlyFlows[i] = MonthlyInputFlowForMin[i, j];
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                workbook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(worksheet);
            }
            MessageBox.Show("IMPORT COMPLETED SUCESSFULLY !");
        }

        public void CalculateParameters()
        {
            double Sum, SumNumerator, sumj1;
            int i, j;
            try
            {
                // input observed flow
                if(ReadInputObsFlow == true)
                {
                    NumberOfData = Convert.ToInt32(TxtNumberOfData.Text);
                    for (i = 0; i < 13; i++) //for 12 rows of month and 13th for repeated data of January
                    {
                        for (j = 1; j <= NumberOfData; j++)   // represents number of years in each rows
                        {
                            MonthlyInputFlow[i, j] = Convert.ToDouble(dataGridView.Rows[i].Cells[j].Value);// input from datagridview
                        }
                    }
                }
                
                for (i = 0; i < 13; i++) //for 12 rows of month and 13th for repeated data of January
                {
                    Sum = 0;

                    for (j = 1; j <= NumberOfData; j++)   // represents number of years in each rows
                    {
                        //MonthlyInputFlow[i, j] = Convert.ToDouble(dataGridView.Rows[i].Cells[j].Value);// input from datagridview
                        Sum = Sum + MonthlyInputFlow[i, j];
                    }
                    Mean[i] = Sum / NumberOfData; // calculate mean
                    dataGridViewParameters.Rows[i].Cells[1].Value = Mean[i].ToString("0.000"); // output mean to datagridview
                    //dataGridView.Rows[i].Cells[NumberOfData + 1].Value = Mean[i].ToString("0.000");
                }

                for(i = 0; i < 13; i++)
                {
                    Sum = 0; SumNumerator = 0; sumj1 = 0; 

                    for(j = 1; j <= NumberOfData; j++)
                    {
                        Sum = Sum + (MonthlyInputFlow[i, j] - Mean[i]) * (MonthlyInputFlow[i, j] - Mean[i]);

                        if (i <= 11)
                        {
                            // for next month of same years
                            sumj1 = sumj1 + (MonthlyInputFlow[i + 1, j] - Mean[i + 1]) * (MonthlyInputFlow[i + 1, j] - Mean[i + 1]);

                            SumNumerator = SumNumerator + (MonthlyInputFlow[i, j] - Mean[i]) * (MonthlyInputFlow[i + 1, j] - Mean[i + 1]);
                        }
                    }
                    StandardDeviation[i] = Math.Sqrt(Sum / (NumberOfData - 1)); // calculate standard deviation
                    dataGridViewParameters.Rows[i].Cells[2].Value = StandardDeviation[i].ToString("0.000");// output std. dev
                    //dataGridView.Rows[i].Cells[NumberOfData + 2].Value = StandardDeviation[i].ToString("0.000");

                    if (i <= 11)
                    {
                        RegressionCoeff[i] = SumNumerator / Sum; // calculate regression coefficient i.e B
                        dataGridViewParameters.Rows[i].Cells[3].Value = RegressionCoeff[i].ToString("0.000");// output regression coeff.
                        //dataGridView.Rows[i].Cells[NumberOfData + 3].Value = RegressionCoeff[i].ToString("0.000");

                        CorrelationCoeff[i] = SumNumerator / (Math.Sqrt(Sum * sumj1)); // calculate correlation coeff i.e. r
                        dataGridViewParameters.Rows[i].Cells[4].Value = CorrelationCoeff[i].ToString("0.000");// output correlation coeff.
                        //dataGridView.Rows[i].Cells[NumberOfData + 4].Value = CorrelationCoeff[i].ToString("0.000");

                    }
                    
                }

                /*
                Obs_index = 0;
                for(i = 0; i< NumberOfData; i++)
                {
                    for(j = 0; j < 12; j++)
                    {
                        ObservedFlow[Obs_index]= Convert.ToDouble(dataGridView.Rows[j].Cells[i + 1].Value);
                        Obs_index++;
                    }
                } */
            }
            catch
            {

            }
        }

        private void PasteToGridCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPredict.SelectedCells.Count < 1) return;

                string[] lines;

                int row = dataGridViewPredict.SelectedCells[0].RowIndex;
                int col = dataGridViewPredict.SelectedCells[0].ColumnIndex;

                //get copied values
                lines = Clipboard.GetText().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                string[] values;
                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].Split('\t');

                    if (row >= dataGridViewPredict.Rows.Count || dataGridViewPredict.Rows[row].IsNewRow) continue;
                    //if (row >= dataGridViewMusking.Rows.Count || dataGridViewMusking.Rows[row].IsNewRow) dataGridViewMusking.Rows.Add();
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (col + j >= dataGridViewPredict.Columns.Count) continue;
                        dataGridViewPredict.Rows[row].Cells[col + j].Value = values[j];
                    }

                    row++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BtnGenerateRandom_Click(object sender, EventArgs e)
        {
            int ui;
            double[] result = new double[3000];
            // Take input from the grid cells for value of U ~ N(0,1)
            //for (ui = 0; ui < PredictNumberOfYear * 12; ui++)
            //{
                //var normal = new NormalDistribution(mean: 0, stdDev: 1);
                //dataGridViewPredict.Rows[index].Cells["ColU"].Value = U[index].ToString();
                //U[ui] = Convert.ToDouble(dataGridViewPredict.Rows[ui].Cells["ColU"].Value);
                
            //}
            
            NormalDistribution.Random(PredictNumberOfYear*12, result);
            for (ui = 0; ui < PredictNumberOfYear * 12; ui++)
            {
                
                dataGridViewPredict.Rows[ui].Cells["ColU"].Value = result[ui].ToString();
               
            }
            //MessageBox.Show(result[0].ToString() + "   " +  result[1].ToString());

        }

        public void GeneratePredictRows()
        {
            try
            {
                PredictNumberOfYear = Convert.ToInt32(TxtPredictYear.Text);
                PredictStartYear = Convert.ToInt32(TxtPredictStartYear.Text);
            }
            catch
            {

            }
            dataGridViewPredict.Rows.Clear();

            n = PredictNumberOfYear * 12;

            for (i = 0; i < n; i++)
            {
                i = dataGridViewPredict.Rows.Add();
                if (i % 12 == 0)
                {
                    cell_val = PredictStartYear + i / 12;
                    dataGridViewPredict.Rows[i].Cells[0].Value = cell_val;
                    dataGridViewPredict.Rows[i].Cells[1].Value = "JAN";
                    month_no = 0;
                }
                else
                {
                    month_no++;
                    if (month_no == 1) dataGridViewPredict.Rows[i].Cells[1].Value = "FEB";
                    if (month_no == 2) dataGridViewPredict.Rows[i].Cells[1].Value = "MAR";
                    if (month_no == 3) dataGridViewPredict.Rows[i].Cells[1].Value = "APR";
                    if (month_no == 4) dataGridViewPredict.Rows[i].Cells[1].Value = "MAY";
                    if (month_no == 5) dataGridViewPredict.Rows[i].Cells[1].Value = "JUN";
                    if (month_no == 6) dataGridViewPredict.Rows[i].Cells[1].Value = "JUL";
                    if (month_no == 7) dataGridViewPredict.Rows[i].Cells[1].Value = "AUG";
                    if (month_no == 8) dataGridViewPredict.Rows[i].Cells[1].Value = "SEP";
                    if (month_no == 9) dataGridViewPredict.Rows[i].Cells[1].Value = "OCT";
                    if (month_no == 10) dataGridViewPredict.Rows[i].Cells[1].Value = "NOV";
                    if (month_no == 11) dataGridViewPredict.Rows[i].Cells[1].Value = "DEC";

                }
            }
        }

       
        public void PredictFlowByTHF() 
        {
            double term1, term2, term3,tempz;
            int index = 0; int k,i,ui,OptU;

            /* for(i = 0; i < 12; i++)
             {
                 Mean[i] = Convert.ToDouble(dataGridViewParameters.Rows[i].Cells[1].Value);
                 StandardDeviation[i] = Convert.ToDouble(dataGridViewParameters.Rows[i].Cells[2].Value);
                 RegressionCoeff[i] = Convert.ToDouble(dataGridViewParameters.Rows[i].Cells[3].Value);
                 CorrelationCoeff[i] = Convert.ToDouble(dataGridViewParameters.Rows[i].Cells[4].Value);
             }*/

            ReadInputObsFlow = false;

            // Take input from the grid cells for value of U ~ N(0,1)
            for(ui=0; ui < PredictNumberOfYear * 12; ui++)
            {
                U[ui] = Convert.ToDouble(dataGridViewPredict.Rows[ui].Cells["ColU"].Value);
            }

            for (ui = 0; ui < 12; ui++)
            {
                MeanY1[ui] = Convert.ToDouble(dataGridViewParameters.Rows[ui].Cells[1].Value);
                StdDev1[ui] = Convert.ToDouble(dataGridViewParameters.Rows[ui].Cells[2].Value);
                RegCoef1[ui] = Convert.ToDouble(dataGridViewParameters.Rows[ui].Cells[3].Value); 
                CorCoef1[ui] = Convert.ToDouble(dataGridViewParameters.Rows[ui].Cells[4].Value);
            }
            for (i = 0; i< PredictNumberOfYear; i++)
            {
                if (PredictFlow == true)
                {
                    NumberOfData++;
                }

                for (k = 0; k < 12; k++)
                {
                    Mean[k] = Convert.ToDouble(dataGridViewParameters.Rows[k].Cells[1].Value);
                    StandardDeviation[k] = Convert.ToDouble(dataGridViewParameters.Rows[k].Cells[2].Value);
                    RegressionCoeff[k] = Convert.ToDouble(dataGridViewParameters.Rows[k].Cells[3].Value);
                    CorrelationCoeff[k] = Convert.ToDouble(dataGridViewParameters.Rows[k].Cells[4].Value);
                }

                for (j = 0; j < 12; j++)
                {
                    
                    if(j == 0 && i == 0)
                    {
                        //PredictedFlow[index] = Mean[j]; //Y 
                        // PredictedFlow[index] = Convert.ToDouble(dataGridView.Rows[0].Cells[1].Value);
                        // dataGridViewPredict.Rows[index].Cells["ColMean"].Value = Mean[j].ToString("0.000");
                        //  dataGridViewPredict.Rows[index].Cells["ColFlowPredicted"].Value = PredictedFlow[index].ToString("0.000");

                        InitialGuessFlow = Convert.ToDouble(TxtInitialGuessFlow.Text);

                        term1 = Mean[j]; // current month
                        term2 = RegressionCoeff[11] * (InitialGuessFlow - Mean[11]);

                        SqrRoot = Math.Sqrt(1 - CorrelationCoeff[11] * CorrelationCoeff[11]);

                        term3 = U[index] * StandardDeviation[j] * SqrRoot;

                        PredictedFlow[index] = term1 + term2 + term3; //Y
                        
                        dataGridViewPredict.Rows[index].Cells["ColMean"].Value = Mean[j].ToString("0.000");
                        dataGridViewPredict.Rows[index].Cells["ColB"].Value = RegressionCoeff[11].ToString("0.000");
                        //dataGridViewPredict.Rows[index].Cells["ColU"].Value = U[index].ToString("0.000");
                        dataGridViewPredict.Rows[index].Cells["ColS"].Value = StandardDeviation[j].ToString("0.000");
                        dataGridViewPredict.Rows[index].Cells["Colr"].Value = SqrRoot.ToString("0.000");
                        dataGridViewPredict.Rows[index].Cells["ColFlowPredicted"].Value = PredictedFlow[index].ToString("0.000");

                        index++; 
                    }
                    else if(j == 0)
                    {
                        term1 = Mean[j]; // current month

                        term2 = RegressionCoeff[11] * (PredictedFlow[index - 1] - Mean[11]);

                        SqrRoot = Math.Sqrt(1 - CorrelationCoeff[11] * CorrelationCoeff[11]);

                        term3 = U[index] * StandardDeviation[j] * SqrRoot;

                        PredictedFlow[index] = term1 + term2 + term3; //Y
                        
                        // output to datagridview of predicted flow
                        dataGridViewPredict.Rows[index].Cells["ColMean"].Value = Mean[j].ToString("0.000");
                        dataGridViewPredict.Rows[index].Cells["ColB"].Value = RegressionCoeff[11].ToString("0.000");
                        //dataGridViewPredict.Rows[index].Cells["ColU"].Value = U[index].ToString("0.000");
                        dataGridViewPredict.Rows[index].Cells["ColS"].Value = StandardDeviation[j].ToString("0.000");
                        dataGridViewPredict.Rows[index].Cells["Colr"].Value = SqrRoot.ToString("0.000");
                        dataGridViewPredict.Rows[index].Cells["ColFlowPredicted"].Value = PredictedFlow[index].ToString("0.000");

                        // update index
                       index++;
                    }
                    else
                    {
                        term1 = Mean[j]; //current month
                        term2 = RegressionCoeff[j-1] * (PredictedFlow[index-1] - Mean[j-1]); // previous month

                        SqrRoot = Math.Sqrt(1 - CorrelationCoeff[j - 1] * CorrelationCoeff[j - 1]);

                        term3 = U[index] * StandardDeviation[j] * SqrRoot;

                        PredictedFlow[index] = term1 + term2 + term3; //Y
                        
                        // output to datagridview of predicted flow
                        dataGridViewPredict.Rows[index].Cells["ColMean"].Value = Mean[j].ToString("0.000");
                        dataGridViewPredict.Rows[index].Cells["ColB"].Value = RegressionCoeff[j - 1].ToString("0.000");
                        //dataGridViewPredict.Rows[index].Cells["ColU"].Value = U[index].ToString("0.000");
                        dataGridViewPredict.Rows[index].Cells["ColS"].Value = StandardDeviation[j].ToString("0.000");
                        dataGridViewPredict.Rows[index].Cells["Colr"].Value = SqrRoot.ToString("0.000");
                        dataGridViewPredict.Rows[index].Cells["ColFlowPredicted"].Value = PredictedFlow[index].ToString("0.000");
                        
                        //update index
                        index++;
                    }

                    MonthlyInputFlow[j, NumberOfData] = PredictedFlow[index-1];
                }
                // update parameters
                MonthlyInputFlow[12, NumberOfData] = MonthlyInputFlow[0, NumberOfData];// appending january flow at the end to calculate correlation and regression coeff.
                CalculateParameters();
                
            }
            PredictFlow = false;
           
            for (ui = 0; ui < 12; ui++)
            {
                MeanY2[ui] = Convert.ToDouble(dataGridViewParameters.Rows[ui].Cells[1].Value);
                StdDev2[ui] = Convert.ToDouble(dataGridViewParameters.Rows[ui].Cells[2].Value);
                RegCoef2[ui] = Convert.ToDouble(dataGridViewParameters.Rows[ui].Cells[3].Value);
                CorCoef2[ui] = Convert.ToDouble(dataGridViewParameters.Rows[ui].Cells[4].Value);
            }

            // replacing negative flows by minimum monthly flow
            int MinIndex = 0;
            for (i = 0; i < PredictNumberOfYear; i++) //year
            {
                for (j = 0; j < 12; j++)   // month
                {
                    if (PredictedFlow[MinIndex] < 0)
                    {
                        PredictedFlow[MinIndex] = MinMonthlyFlows[j];
                        dataGridViewPredict.Rows[MinIndex].Cells["ColFlowPredicted"].Value = PredictedFlow[MinIndex].ToString("0.000");
                    }
                    MinIndex++;
                }
            }

            // Calculate Nash and R square
            Calculate_R_Square_Nash();
            Calculate_GOF_Validation();
            if (R_Square > Best_R_Sqare && R_Square_val > 0.6 && nash > Best_nash && nash_val > Best_nash)
            {
                Best_Model_Found = true;
                Best_R_Sqare = R_Square;
                for(OptU = 0; OptU < PredictNumberOfYear * 12; OptU++)
                {
                    Optimum_U[OptU] = U[OptU];
                }
            }

            ParaCoeffOfDetermination(); // Nash and R squre of parameters: mean, standard deviation, correlation coeff.

            /*  
              for (i = 0; i < PredictNumberOfYear * 12; i++)
              {
                  if(PredictedFlow[i] < 0)
                  {
                      PredictedFlow[i] = MinimumFlow;
                      dataGridViewPredict.Rows[i].Cells["ColFlowPredicted"].Value = PredictedFlow[i].ToString("0.000");

                  }
              }*/

        }

        // Calculation of Nash_Eff, R_Square
        public void Calculate_R_Square_Nash() //R_Square for Observed and nash efficiency 
        {
            int ArIndex;
            diff_in_year = FrmThomasFieringModel.PredictStartYear - FrmThomasFieringModel.Start;
            //diff_in_year_val = FrmThomasFieringModel.StartVal - FrmThomasFieringModel.Start;

            N = FrmThomasFieringModel.PredictNumberOfYear;
            N_obs = FrmThomasFieringModel.NumberOfData1;
            
            totalN = N * 12;
            totalN_obs = N_obs * 12;
           
            //diff_in_year = FrmThomasFieringModel.PredictStartYear - FrmThomasFieringModel.Start;

            if (diff_in_year >= 0)
            {
                sum = 0;
                int count = 0,ArraySize;
                ArIndex = 0;
                for (i = 12 * diff_in_year; i < totalN_obs; i++) // mean of observed
                {
                    sum = sum + FrmThomasFieringModel.ObservedFlow[i];
                    Arr1[ArIndex] = ObservedFlow[i];
                    ArIndex++;
                    count++;
                }
                ArraySize = count;
                Mean_of_Observed = sum / count;

                sum = 0;
                for (i = 12 * diff_in_year; i < totalN_obs; i++) // deviation of observed from mean
                {
                    sum = sum + Math.Pow((FrmThomasFieringModel.ObservedFlow[i] - Mean_of_Observed), 2);
                }
                Deviation_from_mean_Obs = sum;

                sum = 0; ArIndex = 0;
                for (i = 0; i < ArraySize; i++) // deviation of predicted from mean for (i = 0; i < totalN_obs; i++)
                {
                    sum = sum + Math.Pow((FrmThomasFieringModel.PredictedFlow[i] - Mean_of_Observed), 2);
                    Arr2[ArIndex] = PredictedFlow[i];
                    ArIndex++;
                }
                Deviation_from_mean_Predict = sum;

                //R_Square = Math.Round(Deviation_from_mean_Predict / Deviation_from_mean_Obs, 4);

                sum = 0;
                for (i = 12 * diff_in_year; i < totalN_obs; i++)
                {
                    sum = sum + Math.Pow((FrmThomasFieringModel.ObservedFlow[i] - FrmThomasFieringModel.PredictedFlow[i - 12 * diff_in_year]), 2);
                }
                Sum_Obs_minus_Predict = sum;

                nash = Math.Round(1 - Sum_Obs_minus_Predict / Deviation_from_mean_Obs, 4);

                //LblRSquare.Text = "R^2 = " + R_Square;
                //LblNash.Text = "Nash Eff. = " + nash;
                CorrCoeffFinal = FindCorrelationCoefficient(ArraySize, Arr1, Arr2);
                R_Square = CorrCoeffFinal * CorrCoeffFinal;
            }

        }

        public void Calculate_GOF_Validation()
        {
            int ArIndex;
            diff_in_year_val = FrmThomasFieringModel.StartVal - FrmThomasFieringModel.PredictStartYear;

            N = FrmThomasFieringModel.PredictNumberOfYear;
            N_obs_val = FrmThomasFieringModel.NumberOfDataVal;

            totalN = N * 12;
            totalN_obs_val = N_obs_val * 12;

            if (diff_in_year_val >= 0)
            {
                sum = 0;
                int count = 0, ArraySize;
                ArIndex = 0;
                for (i = 0; i < totalN_obs_val; i++) // mean of observed
                {
                    sum = sum + FrmThomasFieringModel.ObservedFlowVal[i];
                    Arr1[ArIndex] = ObservedFlowVal[i];
                    ArIndex++;
                    count++;
                }
                ArraySize = count;
                Mean_of_Observed = sum / count;

                sum = 0;
                for (i = 0; i < totalN_obs_val; i++) // deviation of observed from mean
                {
                    sum = sum + Math.Pow((FrmThomasFieringModel.ObservedFlowVal[i] - Mean_of_Observed), 2);
                }
                Deviation_from_mean_Obs = sum;

                sum = 0; ArIndex = 0;
                for (i = 12 * diff_in_year_val; i < (12 * diff_in_year_val + totalN_obs_val); i++) // deviation of predicted from mean
                {
                    sum = sum + Math.Pow((FrmThomasFieringModel.PredictedFlow[i] - Mean_of_Observed), 2);
                    Arr2[ArIndex] = PredictedFlow[i];
                    ArIndex++;
                }
                Deviation_from_mean_Predict = sum;

                R_Square_val = Math.Round(Deviation_from_mean_Predict / Deviation_from_mean_Obs, 4);

                sum = 0;
                for (i = 0; i < totalN_obs_val; i++)
                {
                    sum = sum + Math.Pow((FrmThomasFieringModel.ObservedFlowVal[i] - FrmThomasFieringModel.PredictedFlow[i + 12 * diff_in_year_val]), 2);
                }
                Sum_Obs_minus_Predict = sum;

                nash_val = Math.Round(1 - Sum_Obs_minus_Predict / Deviation_from_mean_Obs, 4);

                //LblRSquareVal.Text = "R^2 = " + R_Square;
                //LblNashVal.Text = "Nash Eff. = " + nash;

                CorrCoeffFinal = FindCorrelationCoefficient(ArraySize, Arr1, Arr2);
                R_Square_val = CorrCoeffFinal * CorrCoeffFinal;


            }
        }

        public void ParaCoeffOfDetermination()
        {
            int MonthNum = 12;
            double tempcorrcoef;

            // coefficient of determination
            tempcorrcoef = FindCorrelationCoefficient(MonthNum, MeanY1, MeanY2);
            MR2 = tempcorrcoef * tempcorrcoef;

            tempcorrcoef = FindCorrelationCoefficient(MonthNum, StdDev1, StdDev2);
            StdR2 = tempcorrcoef * tempcorrcoef;

            tempcorrcoef = FindCorrelationCoefficient(MonthNum, RegCoef1, RegCoef2);
            RegR2 = tempcorrcoef * tempcorrcoef;

            tempcorrcoef = FindCorrelationCoefficient(MonthNum, CorCoef1, CorCoef2);
            CorrR2 = tempcorrcoef * tempcorrcoef;

            //Nash
            tempcorrcoef = FindNashEfficiency(MonthNum, MeanY1, MeanY2);
            MNash = tempcorrcoef * tempcorrcoef;

            tempcorrcoef = FindNashEfficiency(MonthNum, StdDev1, StdDev2);
            StdNash = tempcorrcoef * tempcorrcoef;

            tempcorrcoef = FindNashEfficiency(MonthNum, RegCoef1, RegCoef2);
            RegNash = tempcorrcoef * tempcorrcoef;

            tempcorrcoef = FindNashEfficiency(MonthNum, CorCoef1, CorCoef2);
            CorrNash = tempcorrcoef * tempcorrcoef;
        }

        public double FindCorrelationCoefficient(int SizeOfArray, double [] Array1, double [] Array2)
        {
            int i;
            double sum1=0, sum2 = 0,sum3,Avg1,Avg2,Denominators,CorrCoeff12;
            for(i =0; i < SizeOfArray; i++)
            {
                sum1 += Array1[i];
                sum2 += Array2[i];
            }
            Avg1 = sum1 / SizeOfArray;
            Avg2 = sum2 / SizeOfArray;
            //MessageBox.Show("Avg1 = " + Avg1.ToString() + "Avg2 = " + Avg2.ToString());

            sum1 = 0; sum2 = 0; sum3 = 0;
            for(i=0; i<SizeOfArray;i++)
            {
                sum3 += (Array1[i] - Avg1) * (Array2[i] - Avg2); //Numerator
                sum1 += (Array1[i] - Avg1) * (Array1[i] - Avg1);
                sum2 += (Array2[i] - Avg2) * (Array2[i] - Avg2);
            }
            Denominators = Math.Sqrt(sum1 * sum2);
            CorrCoeff12 = sum3 / Denominators;

            return CorrCoeff12;
        }

        public double FindNashEfficiency(int SizeOfArray, double[] ObsArray1, double[] PredArray2)
        {
            double NashEff;
            int i;
            double sum1 = 0, sum2 = 0, Avg1, Avg2;
            for (i = 0; i < SizeOfArray; i++)
            {
                sum1 += ObsArray1[i];
            }
            Avg1 = sum1 / SizeOfArray;

            sum1 = 0; sum2 = 0;;
            for (i = 0; i < SizeOfArray; i++)
            {
                sum1 += (ObsArray1[i] - PredArray2[i]) * (ObsArray1[i] - PredArray2[i]); //Numerator
                sum2 += (ObsArray1[i] - Avg1) * (ObsArray1[i] - Avg1);
            }
            NashEff = 1 - sum1 / sum2;

            return NashEff;
        }
         
    }
}
