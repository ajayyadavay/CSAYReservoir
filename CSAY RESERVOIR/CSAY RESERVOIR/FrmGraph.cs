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
    public partial class FrmGraph : Form
    {
        int i, N, totalN, N_obs, totalN_obs, N_obs_val, totalN_obs_val;
        //public static double[] PredictedFlow = new double[3000]; //Y
        //public static int NumberOfData, Start;
        //public static int PredictNumberOfYear, PredictStartYear;
        //public static double[] ObservedFlow = new double[3000];

        int[] X_axis = new int[3000]; 
        int[] X_axis_obs = new int[3000];
        int[] X_axis_obs_val = new int[3000];

        double[] Y_axis_predict = new double[3000];
        double[] Y_axis_Val = new double[3000];

        double[] Y_axis_predict_val = new double[3000]; 

        double sum, Deviation_from_mean_Obs, Deviation_from_mean_Predict, Mean_of_Observed;
        double Sum_Obs_minus_Predict; 
        double R_Square1, nash1;

        private void SaveGraphGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ImagePath = Environment.CurrentDirectory + "\\Thomas Fiering Model" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".png";

                ChartFlowPlot.SaveImage(ImagePath, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

                MessageBox.Show("Thomas Fiering Graph Saved to: \n" + ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int diff_in_year, diff_in_year_val, diff_val_pred;

        private void ComboBoxGraph_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxGraph.Text == "All")
                {
                    PrepareXaxisData();
                    PlotGraph();
                    Calculate_R_Square();
                    Calculate_GOF_Validation();
                }

                if (ComboBoxGraph.Text == "Calibrate")
                {
                    PlotCalibrateGraph();
                }

                if (ComboBoxGraph.Text == "Validate")
                {
                    PlotValidateGraph();
                }

                if (ComboBoxGraph.Text == "Cal + Val")
                {
                    PrepareXaxisData();
                    CalibrateAndValidateGraph();
                }

            }
            catch
            {

            }
        }

        public FrmGraph()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CopyFromGridToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmGraph_Load(object sender, EventArgs e)
        {
            try
            {
                LoadElementInComboBox();
                PrepareXaxisData();
                PlotGraph();
                Calculate_R_Square();
                Calculate_GOF_Validation();
            }
            catch
            {

            }
        }
        public void LoadElementInComboBox()
        {
            try
            {
                ComboBoxGraph.Items.Add("All");
                ComboBoxGraph.Items.Add("Calibrate");
                ComboBoxGraph.Items.Add("Validate");
                ComboBoxGraph.Items.Add("Cal + Val");
            }
            catch
            {

            }
        } 

        public void PlotCalibrateGraph()
        {
            int[] X_axis_obs1 = new int[3000];
            double[] Y_axis_obs1 = new double[3000];
             
            ChartFlowPlot.Series.Clear();
            ChartFlowPlot.Series.Add("Predicted");
            ChartFlowPlot.Series.Add("Observed");

            ChartFlowPlot.ChartAreas[0].AxisX.Interval = 24;
            ChartFlowPlot.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            ChartFlowPlot.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            diff_in_year = FrmThomasFieringModel.PredictStartYear - FrmThomasFieringModel.Start;

            int temp_index_val = 0;
            for (i = diff_in_year * 12; i < totalN_obs; i++) // observed
            {
                X_axis_obs1[temp_index_val] = temp_index_val + 1;
                Y_axis_obs1[temp_index_val] = FrmThomasFieringModel.ObservedFlow[i];
                temp_index_val++;
            }

            for (i = 0; i < totalN_obs - diff_in_year * 12; i++)
            {
                //ChartFlowPlot.Series["Predicted"].Points.AddXY(X_axis[i],  FrmThomasFieringModel.PredictedFlow[i]);
                ChartFlowPlot.Series["Predicted"].Points.AddXY(i+1, FrmThomasFieringModel.PredictedFlow[i]);
                //ChartFlowPlot.Series["Observed"].Points.AddXY(Xaxis[i], ObsFlow_mm[i]);
            }

            for (i = 0; i < totalN_obs - diff_in_year * 12; i++)
            {
                ChartFlowPlot.Series["Observed"].Points.AddXY(X_axis_obs1[i], Y_axis_obs1[i]);
            }

            //ChartFlowPlot.Series["Predicted"].Color = Color.Green;
            ChartFlowPlot.Series["Predicted"].BorderWidth = 2;

            //ChartFlowPlot.Series["Observed"].Color = Color.Red;
            ChartFlowPlot.Series["Observed"].BorderWidth = 2;

            ChartFlowPlot.Series["Predicted"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;

            //ChartMusking.Series["Line"].Points.AddXY(2, 2);
            ChartFlowPlot.Series["Predicted"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            ChartFlowPlot.Series["Observed"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }



        public void PlotValidateGraph()
        {

            ChartFlowPlot.Series.Clear();

            ChartFlowPlot.Series.Add("Predicted");
            ChartFlowPlot.Series.Add("Validation");

            ChartFlowPlot.ChartAreas[0].AxisX.Interval = 12;
            ChartFlowPlot.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            ChartFlowPlot.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            diff_val_pred = FrmThomasFieringModel.StartVal - FrmThomasFieringModel.PredictStartYear;

            int temp_index = 0;
            for (i = 0 + diff_val_pred * 12; i < totalN_obs_val + diff_val_pred * 12; i++) // predicted
            {
                Y_axis_predict_val[temp_index] = FrmThomasFieringModel.PredictedFlow[i];
                temp_index++;
            }

            for (i = 0; i < totalN_obs_val; i++)
            {
                //ChartFlowPlot.Series["Predicted"].Points.AddXY(X_axis[i],  FrmThomasFieringModel.PredictedFlow[i]);
                ChartFlowPlot.Series["Predicted"].Points.AddXY(i+1, Y_axis_predict_val[i]);
                //ChartFlowPlot.Series["Observed"].Points.AddXY(Xaxis[i], ObsFlow_mm[i]);
            }


            for (i = 0; i < totalN_obs_val; i++)
            {
                ChartFlowPlot.Series["Validation"].Points.AddXY(i+1, FrmThomasFieringModel.ObservedFlowVal[i]);
            }

            //ChartFlowPlot.Series["Predicted"].Color = Color.Green;
            ChartFlowPlot.Series["Predicted"].BorderWidth = 2;

            ChartFlowPlot.Series["Validation"].Color = Color.Red;
            ChartFlowPlot.Series["Validation"].BorderWidth = 2;

            ChartFlowPlot.Series["Predicted"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            ChartFlowPlot.Series["Validation"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;

            //ChartMusking.Series["Line"].Points.AddXY(2, 2);
            ChartFlowPlot.Series["Predicted"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            ChartFlowPlot.Series["Validation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

        }
        public void PrepareXaxisData()
        {
            diff_in_year = FrmThomasFieringModel.PredictStartYear - FrmThomasFieringModel.Start;
            diff_in_year_val = FrmThomasFieringModel.StartVal - FrmThomasFieringModel.Start;

            N = FrmThomasFieringModel.PredictNumberOfYear;
            N_obs = FrmThomasFieringModel.NumberOfData1;
            N_obs_val = FrmThomasFieringModel.NumberOfDataVal;

            totalN = N * 12;
            totalN_obs = N_obs * 12;
            totalN_obs_val = N_obs_val * 12;
            
            int temp_index = 0;
            for (i = 0 + diff_in_year * 12; i < totalN + diff_in_year * 12; i++) // predicted
            {
                X_axis[i] = i + 1;
                Y_axis_predict[i] = FrmThomasFieringModel.PredictedFlow[temp_index];
                temp_index++;
            }

            int temp_index_val = 0;
            for (i = 0 + diff_in_year_val * 12; i < totalN_obs_val + diff_in_year_val * 12; i++) // validation
            {
                X_axis_obs_val[i] = i + 1;
                Y_axis_Val[i] = FrmThomasFieringModel.ObservedFlowVal[temp_index_val];
                temp_index_val++;
            }

            for (i = 0; i < totalN_obs; i++) // obs
            {
               X_axis_obs[i] = i + 1;
            }

        }
        public void CalibrateAndValidateGraph()
        {
            int totalyear, tempPlot =0;
            int diffyr1, tempPlotyr1 = -1;
            ChartFlowPlot.Series.Clear();
            ChartFlowPlot.Series.Add("Predicted");
            ChartFlowPlot.Series.Add("Observed");
            ChartFlowPlot.Series.Add("Validation");

            ChartFlowPlot.ChartAreas[0].AxisX.Interval = 60;
            ChartFlowPlot.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            ChartFlowPlot.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            totalyear = (FrmThomasFieringModel.StartVal + FrmThomasFieringModel.NumberOfDataVal - 1) - FrmThomasFieringModel.PredictStartYear;
            totalyear = (totalyear+1) * 12;

            diffyr1 = FrmThomasFieringModel.PredictStartYear - FrmThomasFieringModel.Start;
            diffyr1 = diffyr1 * 12;

            for (i = 0 + diff_in_year * 12; i < totalN + diff_in_year * 12; i++)
            {
                if (tempPlot >= totalyear) continue;
                //ChartFlowPlot.Series["Predicted"].Points.AddXY(X_axis[i],  FrmThomasFieringModel.PredictedFlow[i]);
                ChartFlowPlot.Series["Predicted"].Points.AddXY(X_axis[i]- diffyr1, Y_axis_predict[i]);
                //ChartFlowPlot.Series["Observed"].Points.AddXY(Xaxis[i], ObsFlow_mm[i]);
                tempPlot++;
            }

            //diffyr1 = FrmThomasFieringModel.PredictStartYear - FrmThomasFieringModel.Start;
            //diffyr1 = diffyr1 * 12;

            for (i = 0; i < totalN_obs; i++)
            {
                tempPlotyr1++;
                if (tempPlotyr1 <= diffyr1) continue;
                //X_axis_obs[i] = X_axis_obs[i] - diffyr1;
                ChartFlowPlot.Series["Observed"].Points.AddXY(X_axis_obs[i]- diffyr1, FrmThomasFieringModel.ObservedFlow[i]);
                
            }

            for (i = 0 + diff_in_year_val * 12; i < totalN_obs_val + diff_in_year_val * 12; i++)
            {
                ChartFlowPlot.Series["Validation"].Points.AddXY(X_axis_obs_val[i]- diffyr1, Y_axis_Val[i]);
            }

            //ChartFlowPlot.Series["Predicted"].Color = Color.Green;
            ChartFlowPlot.Series["Predicted"].BorderWidth = 2;

            //ChartFlowPlot.Series["Observed"].Color = Color.Red;
            ChartFlowPlot.Series["Observed"].BorderWidth = 2;

            //ChartFlowPlot.Series["Validation"].Color = Color.Blue;
            ChartFlowPlot.Series["Validation"].BorderWidth = 2;

            ChartFlowPlot.Series["Predicted"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;

            ChartFlowPlot.Series["Validation"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;

            //ChartMusking.Series["Line"].Points.AddXY(2, 2);
            ChartFlowPlot.Series["Predicted"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            ChartFlowPlot.Series["Observed"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            ChartFlowPlot.Series["Validation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }
        
        public void PlotGraph()
        {
            ChartFlowPlot.Series.Clear();
            ChartFlowPlot.Series.Add("Predicted");
            ChartFlowPlot.Series.Add("Observed");
            ChartFlowPlot.Series.Add("Validation");

            ChartFlowPlot.ChartAreas[0].AxisX.Interval = 60;
            ChartFlowPlot.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            ChartFlowPlot.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            for (i = 0 + diff_in_year * 12; i < totalN + diff_in_year * 12; i++)
            {
                //ChartFlowPlot.Series["Predicted"].Points.AddXY(X_axis[i],  FrmThomasFieringModel.PredictedFlow[i]);
                ChartFlowPlot.Series["Predicted"].Points.AddXY(X_axis[i], Y_axis_predict[i]);
                //ChartFlowPlot.Series["Observed"].Points.AddXY(Xaxis[i], ObsFlow_mm[i]);
            }

            for(i = 0; i < totalN_obs; i++)
            {
                ChartFlowPlot.Series["Observed"].Points.AddXY(X_axis_obs[i], FrmThomasFieringModel.ObservedFlow[i]);
            }

            for (i = 0 + diff_in_year_val * 12; i < totalN_obs_val + diff_in_year_val * 12; i++)
            {
                ChartFlowPlot.Series["Validation"].Points.AddXY(X_axis_obs_val[i], Y_axis_Val[i]);
            }

            //ChartFlowPlot.Series["Predicted"].Color = Color.Green;
            ChartFlowPlot.Series["Predicted"].BorderWidth = 2;

            //ChartFlowPlot.Series["Observed"].Color = Color.Red;
            ChartFlowPlot.Series["Observed"].BorderWidth = 2;

            //ChartFlowPlot.Series["Validation"].Color = Color.Blue;
            ChartFlowPlot.Series["Validation"].BorderWidth = 2;

            ChartFlowPlot.Series["Predicted"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;

            ChartFlowPlot.Series["Validation"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            
            //ChartMusking.Series["Line"].Points.AddXY(2, 2);
            ChartFlowPlot.Series["Predicted"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            ChartFlowPlot.Series["Observed"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            ChartFlowPlot.Series["Validation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        public void Calculate_R_Square()
        {
            diff_in_year = FrmThomasFieringModel.PredictStartYear - FrmThomasFieringModel.Start;

            if(diff_in_year >= 0)
            {
                sum = 0;
                int count = 0; 
                for (i = 12 * diff_in_year; i < totalN_obs; i++) // mean of observed
                {
                    sum = sum + FrmThomasFieringModel.ObservedFlow[i];
                    count++;
                }
                Mean_of_Observed = sum / count;

                sum = 0;
                for(i = 12 * diff_in_year; i < totalN_obs; i++) // deviation of observed from mean
                {
                    sum = sum + Math.Pow((FrmThomasFieringModel.ObservedFlow[i] - Mean_of_Observed), 2);
                }
                Deviation_from_mean_Obs = sum;

                sum = 0;
                for (i = 0; i < totalN_obs; i++) // deviation of predicted from mean
                {
                    sum = sum + Math.Pow((FrmThomasFieringModel.PredictedFlow[i] - Mean_of_Observed), 2);
                }
                Deviation_from_mean_Predict = sum;

                R_Square1 =Math.Round(Deviation_from_mean_Predict / Deviation_from_mean_Obs, 4);

                sum = 0;
                for(i = 12 * diff_in_year; i < totalN_obs; i++)
                {
                    sum = sum + Math.Pow((FrmThomasFieringModel.ObservedFlow[i] - FrmThomasFieringModel.PredictedFlow[i - 12 * diff_in_year]),2);
                }
                Sum_Obs_minus_Predict = sum;

                nash1 = Math.Round(1 - Sum_Obs_minus_Predict / Deviation_from_mean_Obs, 4);

                //LblRSquare.Text = "R^2 = " + R_Square1;
                LblRSquare.Text = "R^2 = " + FrmThomasFieringModel.R_Square.ToString("0.0000");
                //LblNash.Text = "Nash Eff. = " + nash1;
                LblNash.Text = "Nash Eff. = " + FrmThomasFieringModel.nash.ToString("0.0000");
            }
            
        }

        public void Calculate_GOF_Validation()
        {
            diff_in_year_val = FrmThomasFieringModel.StartVal - FrmThomasFieringModel.PredictStartYear;

            if (diff_in_year_val >= 0)
            {
                sum = 0;
                int count = 0;
                for (i = 0 ; i < totalN_obs_val; i++) // mean of observed
                {
                    sum = sum + FrmThomasFieringModel.ObservedFlowVal[i];
                    count++;
                }
                Mean_of_Observed = sum / count;

                sum = 0;
                for (i = 0 ; i < totalN_obs_val; i++) // deviation of observed from mean
                {
                    sum = sum + Math.Pow((FrmThomasFieringModel.ObservedFlowVal[i] - Mean_of_Observed), 2);
                }
                Deviation_from_mean_Obs = sum;

                sum = 0;
                for (i = 12 * diff_in_year_val; i < (12 * diff_in_year_val + totalN_obs_val); i++) // deviation of predicted from mean
                {
                    sum = sum + Math.Pow((FrmThomasFieringModel.PredictedFlow[i] - Mean_of_Observed), 2);
                }
                Deviation_from_mean_Predict = sum;

                R_Square1 = Math.Round(Deviation_from_mean_Predict / Deviation_from_mean_Obs, 4);

                sum = 0;
                for (i = 0; i < totalN_obs_val; i++)
                {
                    sum = sum + Math.Pow((FrmThomasFieringModel.ObservedFlowVal[i] - FrmThomasFieringModel.PredictedFlow[i + 12 * diff_in_year_val]), 2);
                }
                Sum_Obs_minus_Predict = sum;

                nash1 = Math.Round(1 - Sum_Obs_minus_Predict / Deviation_from_mean_Obs, 4);

                //LblRSquareVal.Text = "R^2 = " + R_Square1;
                //LblNashVal.Text = "Nash Eff. = " + nash1;
                LblRSquareVal.Text = "R^2 = " + FrmThomasFieringModel.R_Square_val.ToString("0.0000");
                LblNashVal.Text = "Nash Eff. = " + FrmThomasFieringModel.nash_val.ToString("0.0000");
                
            }
        }

    }
}
