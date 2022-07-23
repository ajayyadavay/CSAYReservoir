namespace CSAY_RESERVOIR
{
    partial class CorrCoeffGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartFlowPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStripGraph = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SaveGraphGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFlowPlot)).BeginInit();
            this.contextMenuStripGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartFlowPlot
            // 
            this.ChartFlowPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartFlowPlot.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChartFlowPlot.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.ChartFlowPlot.ChartAreas.Add(chartArea1);
            this.ChartFlowPlot.ContextMenuStrip = this.contextMenuStripGraph;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BorderColor = System.Drawing.Color.Blue;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.ChartFlowPlot.Legends.Add(legend1);
            this.ChartFlowPlot.Location = new System.Drawing.Point(12, 12);
            this.ChartFlowPlot.Name = "ChartFlowPlot";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Graph";
            this.ChartFlowPlot.Series.Add(series1);
            this.ChartFlowPlot.Size = new System.Drawing.Size(964, 426);
            this.ChartFlowPlot.TabIndex = 44;
            this.ChartFlowPlot.Text = "chart1";
            title1.BackColor = System.Drawing.Color.White;
            title1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.DarkViolet;
            title1.Name = "Graph_title";
            title1.Text = "THOMAS FEIRING MODEL - CORRELATION COEFFICIENT";
            title2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Blue;
            title2.Name = "X_axis_label";
            title2.Position.Auto = false;
            title2.Position.Width = 94F;
            title2.Position.Y = 97F;
            title2.Text = "Months";
            title3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.Blue;
            title3.Name = "Y_axis_label";
            title3.Position.Auto = false;
            title3.Position.Height = 50F;
            title3.Position.X = 4F;
            title3.Position.Y = 30F;
            title3.Text = "Correlation Coefficient";
            title3.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            this.ChartFlowPlot.Titles.Add(title1);
            this.ChartFlowPlot.Titles.Add(title2);
            this.ChartFlowPlot.Titles.Add(title3);
            // 
            // contextMenuStripGraph
            // 
            this.contextMenuStripGraph.BackColor = System.Drawing.Color.White;
            this.contextMenuStripGraph.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripGraph.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveGraphGridToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStripGraph.Name = "contextMenuStrip1";
            this.contextMenuStripGraph.Size = new System.Drawing.Size(146, 48);
            // 
            // SaveGraphGridToolStripMenuItem
            // 
            this.SaveGraphGridToolStripMenuItem.Name = "SaveGraphGridToolStripMenuItem";
            this.SaveGraphGridToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.SaveGraphGridToolStripMenuItem.Text = "Save Graph";
            this.SaveGraphGridToolStripMenuItem.Click += new System.EventHandler(this.SaveGraphGridToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CorrCoeffGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.ChartFlowPlot);
            this.Name = "CorrCoeffGraph";
            this.Text = "CorrCoeffGraph";
            this.Load += new System.EventHandler(this.CorrCoeffGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartFlowPlot)).EndInit();
            this.contextMenuStripGraph.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFlowPlot;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGraph;
        private System.Windows.Forms.ToolStripMenuItem SaveGraphGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}