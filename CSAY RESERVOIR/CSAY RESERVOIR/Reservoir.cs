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
    public partial class FrmReservoir : Form
    {
        int Start, NumberOfData, i;
        double InitialStorage, Capacity;
        string path;
        double value, CheckForRelease, CheckForOverFlow;
        double Current_Storage, Inflow, Demand, Evapotrans, Release, Next_Storage, OverFlow;

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

                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "RESERVOIR OPTIMIZATION " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Capacity";
                //value of k in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = TxtCapacity.Text;


                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[5, 1];
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


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "RESERVOIR OPTIMIZATION " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Capacity";
                //value of k in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = TxtCapacity.Text;
                

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[5, 1];
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
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView.MultiSelect = true;
            dataGridView.SelectAll();
            DataObject dataObj = dataGridView.GetClipboardContent();
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

        private void PasteToGidCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedCells.Count < 1) return;

                string[] lines;

                int row = dataGridView.SelectedCells[0].RowIndex;
                int col = dataGridView.SelectedCells[0].ColumnIndex;

                //get copied values
                lines = Clipboard.GetText().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                string[] values;
                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].Split('\t');

                    if (row >= dataGridView.Rows.Count || dataGridView.Rows[row].IsNewRow) continue;
                    //if (row >= dataGridViewMusking.Rows.Count || dataGridViewMusking.Rows[row].IsNewRow) dataGridViewMusking.Rows.Add();
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (col + j >= dataGridView.Columns.Count) continue;
                        dataGridView.Rows[row].Cells[col + j].Value = values[j];
                    }

                    row++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void RemoveOneSelectedRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView.CurrentCell.RowIndex;
                dataGridView.Rows.RemoveAt(row);
                dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearValueOfSelectedCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell cell in dataGridView.SelectedCells)
                {
                    string i = "";
                    cell.Value = (object)i;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveAllGridsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CopySelectedtoClipboard()
        {
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView.MultiSelect = true;
            //dataGridViewMusking.SelectAll();
            DataObject dataObj = dataGridView.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout fabout = new FrmAbout();
            fabout.Show();
        }

        public FrmReservoir()
        {
            InitializeComponent();
        }

        private void FrmReservoir_Load(object sender, EventArgs e)
        {
            SetGridColorAndFont();
        }
        public void SetGridColorAndFont()
        {
            this.dataGridView.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            this.dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }

        private void TxtNumberOfData_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
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
                value = worksheet.Cells[2, 2].value;
                TxtInitialStorage.Text = value.ToString();

                value = worksheet.Cells[3, 2].value;
                TxtCapacity.Text = value.ToString();
                
                int rcount = NumberOfData;

                int i = 0;

                for (i = 0; i < rcount; i++)
                {
                    dataGridView.Rows.Add();
                    dataGridView.Rows[i].Cells["ColTime"].Value = worksheet.Cells[i + 6, 1].value;
                    dataGridView.Rows[i].Cells["ColInflow"].Value = worksheet.Cells[i + 6, 2].value;
                    dataGridView.Rows[i].Cells["ColDemand"].Value = worksheet.Cells[i + 6, 3].value;
                    dataGridView.Rows[i].Cells["ColEvapotrans"].Value = worksheet.Cells[i + 6, 4].value;
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

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // input
                InitialStorage = Convert.ToDouble(TxtInitialStorage.Text);
                Capacity = Convert.ToDouble(TxtCapacity.Text);

                
                for (i = 0; i < NumberOfData; i++)
                {
                    if (i == 0)
                    {
                        dataGridView.Rows[i].Cells[1].Value = InitialStorage.ToString();
                    }
                    else
                    {
                        dataGridView.Rows[i].Cells[1].Value = Current_Storage.ToString();
                    }
                    Current_Storage = Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value); //St
                    Inflow = Convert.ToDouble(dataGridView.Rows[i].Cells[2].Value);  //Qt
                    Demand = Convert.ToDouble(dataGridView.Rows[i].Cells[3].Value);  //Dt
                    Evapotrans = Convert.ToDouble(dataGridView.Rows[i].Cells[4].Value);  //Et

                    //calculation
                    CheckForRelease = Current_Storage + Inflow - Evapotrans; // St+Qt-Et
                    if (CheckForRelease >= Demand)
                    {
                        Release = Demand;   //Rt
                    }
                    else
                    {
                        Release = CheckForRelease;  //Rt
                    }


                    CheckForOverFlow = CheckForRelease - Release - Capacity;
                    
                    if(CheckForOverFlow <=0)
                    {
                        OverFlow = 0;   //Ot
                    }
                    else
                    {
                        OverFlow = CheckForOverFlow;    //Ot
                    }

                    Next_Storage = Current_Storage + Inflow - Evapotrans - Release - OverFlow;

                    //output to datagrid
                    dataGridView.Rows[i].Cells[5].Value = Release.ToString();
                    dataGridView.Rows[i].Cells[6].Value = Next_Storage.ToString();
                    dataGridView.Rows[i].Cells[7].Value = OverFlow.ToString();

                    //update values
                    Current_Storage = Next_Storage;
                }

            }
            catch
            {

            }
        }

        private void TxtStart_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
            }
            catch
            {

            }
        }

        public void Generaterows()
        {
            int cell_val=0;
            try
            {
                NumberOfData = Convert.ToInt32(TxtNumberOfData.Text);
                Start = Convert.ToInt32(TxtStart.Text);
            }
            catch
            {
                //MessageBox.Show("Del_t or N missing !!!");
            }
            dataGridView.Rows.Clear();
            
            for (i = 0; i < NumberOfData; i++)
            {
                i = dataGridView.Rows.Add();

                if (i==0)
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

    }
}
