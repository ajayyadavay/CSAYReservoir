using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace CSAY_RESERVOIR
{
    public partial class FrmReservoirOperationForHP : Form
    {
        int NumberOfEVAData, NumberOfIniEvapData,i,j;
        string path;
        double InitialStorage, eff, MinPower, Capacity, TWL, MonthPerPeriod;
        double[] Elevation = new double[1000];
        double[] Volume = new double[1000];
        double[] Area = new double[1000];
        double[] Inflow = new double[1000];
        double[] Evaporation = new double[1000];
        double[] Storages = new double[1000];
        double[] NextStorages = new double[1000];
        double[] NextElevation = new double[1000];
        double[] NextArea = new double[1000];
        double[] NextVolume = new double[1000];
        double[] NextEvaporation = new double[1000];
        double[] Releases = new double[1000];
        double[] Outflows = new double[1000];
        double[] Savt = new double[1000];
        double[] Savt_Star = new double[1000]; 
        double Sav, Sav_star, error, FinalStorage; 
         
        public FrmReservoirOperationForHP()
        {
            InitializeComponent();
        }

        private void FrmReservoirOperationForHP_Load(object sender, EventArgs e)
        {
            try
            {

                SetGridColorAndFont();
            }
            catch
            {

            }
        }

        private void BtnExportToExcel_Click(object sender, EventArgs e)
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


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "RESERVOIR OPERATION FOR POWER GENERATION " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                //((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Capacity";
                //value of k in Cell[1,2]
                //((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = TxtCapacity.Text;


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

        private void CopyAlltoClipboard()
        {
            dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView2.MultiSelect = true;
            dataGridView2.SelectAll();
            DataObject dataObj = dataGridView2.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void TxtNumberOfData_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GeneraterowsEVA();
            }
            catch
            {

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSimulate_Click(object sender, EventArgs e)
        {
            try
            {
                SimulateForPowerGeneration();
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

                int rcount = NumberOfEVAData;

                int i = 0;

                for (i = 0; i < rcount; i++)
                {
                    dataGridView.Rows.Add();
                    dataGridView.Rows[i].Cells["ColSN"].Value = worksheet.Cells[i + 3, 1].value;
                    dataGridView.Rows[i].Cells["ColElevation"].Value = worksheet.Cells[i + 3, 2].value;
                    dataGridView.Rows[i].Cells["ColCapacity"].Value = worksheet.Cells[i + 3, 3].value;
                    dataGridView.Rows[i].Cells["ColArea"].Value = worksheet.Cells[i + 3, 4].value;
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
        public void SetGridColorAndFont()
        {
            dataGridView.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.Purple;

            dataGridView1.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Purple;

            dataGridView2.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }

        private void BtnImportFromExcel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "Excel Sheet(*.xlsx)|*.xlsx|Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            openfiledialog1.FilterIndex = 1;

            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openfiledialog1.FileName;
            }
            else if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            dataGridView1.DataSource = null;

            for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            {
                dataGridView1.Rows.RemoveAt(j);
                j--;
                while (dataGridView1.Rows.Count == 0)
                    continue;
            }

            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbooks workbooks = app.Workbooks;

            Excel.Workbook workbook = workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            try
            {

                int rcount = NumberOfIniEvapData;

                int i = 0;

                for (i = 0; i < rcount; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["ColSN1"].Value = worksheet.Cells[i + 3, 1].value;
                    dataGridView1.Rows[i].Cells["ColPeriod"].Value = worksheet.Cells[i + 3, 2].value;
                    dataGridView1.Rows[i].Cells["ColInflow1"].Value = worksheet.Cells[i + 3, 3].value;
                    dataGridView1.Rows[i].Cells["ColEvaporation1"].Value = worksheet.Cells[i + 3, 4].value;
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

        private void TxtNumberOfData1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GeneraterowsIniEvap();
            }
            catch
            {

            }
        }

        public void GeneraterowsIniEvap()
        {
            int cell_val = 0, Start = 1;
            try 
            {
                NumberOfIniEvapData = Convert.ToInt32(TxtNumberOfData1.Text);
            }
            catch
            {
                //MessageBox.Show("Del_t or N missing !!!");
            }
            dataGridView1.Rows.Clear();

            for (i = 0; i < NumberOfIniEvapData; i++)
            {
                i = dataGridView1.Rows.Add();
                if (i == 0)
                {
                    cell_val = Start;
                    dataGridView1.Rows[i].Cells[0].Value = cell_val;
                }
                else
                {
                    cell_val = cell_val + 1;
                    dataGridView1.Rows[i].Cells[0].Value = cell_val;
                }
            }
            // for output datagridview
            dataGridView2.Rows.Clear();

            for (i = 0; i < NumberOfIniEvapData; i++)
            {
                i = dataGridView2.Rows.Add();
            }
        }

        public void GeneraterowsEVA()
        {
            int cell_val = 0, Start = 1;
            try
            {
                NumberOfEVAData = Convert.ToInt32(TxtNumberOfData.Text);
            }
            catch
            {
                //MessageBox.Show("Del_t or N missing !!!");
            }
            dataGridView.Rows.Clear();

            for (i = 0; i < NumberOfEVAData; i++)
            {
                i = dataGridView.Rows.Add();
                if (i == 0)
                {
                    cell_val = Start;
                    dataGridView.Rows[i].Cells[0].Value = cell_val;
                }
                else
                {
                    cell_val = cell_val + 1;
                    dataGridView.Rows[i].Cells[0].Value = cell_val;
                }
            }
        }
        public void InputData()
        {
            try
            {
                InitialStorage = Convert.ToDouble(TxtInitialStorage.Text);
                eff = Convert.ToDouble(TxtEfficiency.Text);
                MinPower = Convert.ToDouble(TxtMinPower.Text);
                TWL = Convert.ToDouble(TxtTWL.Text);
                Capacity = Convert.ToDouble(TxtCapacity.Text);
                MonthPerPeriod = Convert.ToDouble(TxtMonthsPerPeriod.Text);

                NumberOfEVAData = Convert.ToInt32(TxtNumberOfData.Text);
                NumberOfIniEvapData = Convert.ToInt32(TxtNumberOfData1.Text);

                for(i = 0; i < NumberOfEVAData; i++)
                {
                    Elevation[i] = Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value);
                    Volume[i] = Convert.ToDouble(dataGridView.Rows[i].Cells[2].Value);
                    Area[i] = Convert.ToDouble(dataGridView.Rows[i].Cells[3].Value);
                }

                for (i = 0; i < NumberOfIniEvapData; i++)
                {
                    Inflow[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    Evaporation[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                }
            }
            catch
            {

            }
        }
        public void SimulateForPowerGeneration()
        {
            int iterations = 1000, itr;
            double FindDiff, V1,V2,A1,A2,H1,H2,H=0,V,A=0;
            double Rt,Et,Ot=0;
            try
            {
                InputData();

                for(i = 0; i < NumberOfIniEvapData; i++)
                {
                    if(i==0)
                    {
                        Storages[i] = InitialStorage;
                    }
                    Sav = Storages[i];

                    for (itr = 1; itr <= iterations; itr++)
                    {
                        //Sav = InitialStorage;
                        V = Sav;

                        for(j = 0; j < NumberOfEVAData; j++)
                        {
                            FindDiff = Volume[j] - V;
                            if(FindDiff == 0)
                            {
                                H = Elevation[j];
                                A = Area[j];
                                break;
                            }
                            else if (FindDiff > 0)
                            {
                                V1 = Volume[j];
                                A1 = Area[j];
                                H1 = Elevation[j];

                                V2 = Volume[j - 1];
                                A2 = Area[j - 1];
                                H2 = Elevation[j - 1];

                                H = (H2 - H1) / (V2 - V1) * (V - V1) + H1;
                                A = (A2 - A1) / (V2 - V1) * (V - V1) + A1;
                                break;
                            }
                        }

                        Rt = MonthPerPeriod * MinPower / (0.003785 * eff/100 * (H - TWL));
                        Et = Evaporation[i] * A / 100;
                        FinalStorage = Storages[i] + Inflow[i] - Rt - Et;
                        if(FinalStorage >= Capacity)
                        {
                            Ot = FinalStorage - Capacity;
                            FinalStorage = Capacity;
                        }

                        Sav_star = (Storages[i] + FinalStorage) / 2;

                        error = Math.Abs(Sav - Sav_star);
                        if(error <= 0.5)
                        {
                            NextStorages[i] = FinalStorage;
                            Storages[i + 1] = NextStorages[i];
                            NextElevation[i] = H;
                            NextVolume[i] = V;
                            NextArea[i] = A;
                            NextEvaporation[i] = Et;
                            Releases[i] = Rt;
                            Outflows[i] = Ot;
                            Savt[i] = Sav;
                            Savt_Star[i] = Sav_star;
                            break;
                        }
                        else
                        {
                            Sav = Sav_star;
                        }
                    } 
                }
                // output to datagridview
                for(int k =0; k < NumberOfIniEvapData; k++)
                {
                    dataGridView2.Rows[k].Cells[0].Value = dataGridView1.Rows[k].Cells[1].Value;
                    dataGridView2.Rows[k].Cells[1].Value = Storages[k].ToString("0.0000");
                    dataGridView2.Rows[k].Cells[2].Value = Inflow[k].ToString("0.0000");
                    dataGridView2.Rows[k].Cells[3].Value = NextEvaporation[k].ToString("0.0000");
                    dataGridView2.Rows[k].Cells[4].Value = Releases[k].ToString("0.0000");
                    dataGridView2.Rows[k].Cells[5].Value = NextStorages[k].ToString("0.0000");
                    dataGridView2.Rows[k].Cells[6].Value = Outflows[k].ToString("0.0000");
                    dataGridView2.Rows[k].Cells[7].Value = Savt[k].ToString("0.0000");
                    dataGridView2.Rows[k].Cells[8].Value = Savt_Star[k].ToString("0.0000"); 

                }
            }
            catch
            {

            }
        }
    }
}
