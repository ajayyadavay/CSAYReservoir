using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSAY_RESERVOIR
{
    
    public partial class CorrCoeffGraph : Form
    {
        int[] X_axis = new int[100];
        string[] MonthName = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
        int i;
        public CorrCoeffGraph()
        {
            InitializeComponent();
        }

        private void CorrCoeffGraph_Load(object sender, EventArgs e)
        {
            try
            {
                PrepareXaxisData();
                PlotGraph();
            }
            catch
            {

            }
        }
        public void PrepareXaxisData()
        {
            for (i = 0; i < 12; i++)
            {
                X_axis[i] = i + 1;
            }
        }

        public void PlotGraph()
        {
            ChartFlowPlot.Series.Clear();
            ChartFlowPlot.Series.Add("Predicted");
            ChartFlowPlot.Series.Add("Observed");

            ChartFlowPlot.ChartAreas[0].AxisX.Interval = 1;
            ChartFlowPlot.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            ChartFlowPlot.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            for (i = 0; i < 12; i++)
            {
                //ChartFlowPlot.Series["Observed"].Points.AddXY(X_axis[i], FrmThomasFieringModel.CorCoef1[i]);
                ChartFlowPlot.Series["Observed"].Points.AddXY(MonthName[i], FrmThomasFieringModel.CorCoef1[i]);
            }

            for (i = 0; i < 12; i++)
            {
                //ChartFlowPlot.Series["Predicted"].Points.AddXY(X_axis[i], FrmThomasFieringModel.CorCoef2[i]);
                ChartFlowPlot.Series["Predicted"].Points.AddXY(MonthName[i], FrmThomasFieringModel.CorCoef2[i]);
            }

            //ChartFlowPlot.Series["Predicted"].Color = Color.Green;
            //ChartFlowPlot.Series["Predicted"].BorderWidth = 2;

            //ChartFlowPlot.Series["Observed"].Color = Color.Red;
            //ChartFlowPlot.Series["Observed"].BorderWidth = 2;

            //ChartFlowPlot.Series["Predicted"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;

            //ChartFlowPlot.Series["Validation"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;

            //ChartMusking.Series["Line"].Points.AddXY(2, 2);
            ChartFlowPlot.Series["Predicted"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            ChartFlowPlot.Series["Observed"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveGraphGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ImagePath = Environment.CurrentDirectory + "\\CorrCoeff - Thomas Fiering Model" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".png";

                ChartFlowPlot.SaveImage(ImagePath, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

                MessageBox.Show("Correlation Coefficient - Thomas Fiering Graph Saved to: \n" + ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
