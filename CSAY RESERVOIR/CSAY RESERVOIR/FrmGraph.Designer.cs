namespace CSAY_RESERVOIR
{
    partial class FrmGraph
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
            this.LblRSquareVal = new System.Windows.Forms.Label();
            this.LblNash = new System.Windows.Forms.Label();
            this.LblNashVal = new System.Windows.Forms.Label();
            this.LblRSquare = new System.Windows.Forms.Label();
            this.ComboBoxGraph = new System.Windows.Forms.ComboBox();
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
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.ChartFlowPlot.Legends.Add(legend1);
            this.ChartFlowPlot.Location = new System.Drawing.Point(12, 12);
            this.ChartFlowPlot.Name = "ChartFlowPlot";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Graph";
            this.ChartFlowPlot.Series.Add(series1);
            this.ChartFlowPlot.Size = new System.Drawing.Size(964, 426);
            this.ChartFlowPlot.TabIndex = 41;
            this.ChartFlowPlot.Text = "chart1";
            title1.BackColor = System.Drawing.Color.White;
            title1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.DarkViolet;
            title1.Name = "Graph_title";
            title1.Text = "THOMAS FIERING MODEL";
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
            title3.Text = "Discharge (m3/s)";
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
            // LblRSquareVal
            // 
            this.LblRSquareVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRSquareVal.AutoSize = true;
            this.LblRSquareVal.BackColor = System.Drawing.Color.Transparent;
            this.LblRSquareVal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRSquareVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblRSquareVal.Location = new System.Drawing.Point(773, 81);
            this.LblRSquareVal.Name = "LblRSquareVal";
            this.LblRSquareVal.Size = new System.Drawing.Size(69, 26);
            this.LblRSquareVal.TabIndex = 42;
            this.LblRSquareVal.Text = "R^2 = ";
            // 
            // LblNash
            // 
            this.LblNash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblNash.AutoSize = true;
            this.LblNash.BackColor = System.Drawing.Color.Transparent;
            this.LblNash.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblNash.Location = new System.Drawing.Point(95, 51);
            this.LblNash.Name = "LblNash";
            this.LblNash.Size = new System.Drawing.Size(120, 26);
            this.LblNash.TabIndex = 43;
            this.LblNash.Text = "Nash Eff. = ";
            // 
            // LblNashVal
            // 
            this.LblNashVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNashVal.AutoSize = true;
            this.LblNashVal.BackColor = System.Drawing.Color.Transparent;
            this.LblNashVal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNashVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNashVal.Location = new System.Drawing.Point(773, 51);
            this.LblNashVal.Name = "LblNashVal";
            this.LblNashVal.Size = new System.Drawing.Size(120, 26);
            this.LblNashVal.TabIndex = 44;
            this.LblNashVal.Text = "Nash Eff. = ";
            // 
            // LblRSquare
            // 
            this.LblRSquare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblRSquare.AutoSize = true;
            this.LblRSquare.BackColor = System.Drawing.Color.Transparent;
            this.LblRSquare.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRSquare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblRSquare.Location = new System.Drawing.Point(95, 81);
            this.LblRSquare.Name = "LblRSquare";
            this.LblRSquare.Size = new System.Drawing.Size(69, 26);
            this.LblRSquare.TabIndex = 45;
            this.LblRSquare.Text = "R^2 = ";
            // 
            // ComboBoxGraph
            // 
            this.ComboBoxGraph.AllowDrop = true;
            this.ComboBoxGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGraph.BackColor = System.Drawing.Color.White;
            this.ComboBoxGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxGraph.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxGraph.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ComboBoxGraph.FormattingEnabled = true;
            this.ComboBoxGraph.Location = new System.Drawing.Point(615, 17);
            this.ComboBoxGraph.Name = "ComboBoxGraph";
            this.ComboBoxGraph.Size = new System.Drawing.Size(157, 31);
            this.ComboBoxGraph.TabIndex = 49;
            this.ComboBoxGraph.Text = "All";
            this.ComboBoxGraph.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGraph_SelectedIndexChanged);
            // 
            // FrmGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.ComboBoxGraph);
            this.Controls.Add(this.LblRSquare);
            this.Controls.Add(this.LblNashVal);
            this.Controls.Add(this.LblNash);
            this.Controls.Add(this.LblRSquareVal);
            this.Controls.Add(this.ChartFlowPlot);
            this.Name = "FrmGraph";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.FrmGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartFlowPlot)).EndInit();
            this.contextMenuStripGraph.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFlowPlot;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGraph;
        private System.Windows.Forms.ToolStripMenuItem SaveGraphGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label LblRSquareVal;
        private System.Windows.Forms.Label LblNash;
        private System.Windows.Forms.Label LblNashVal;
        private System.Windows.Forms.Label LblRSquare;
        private System.Windows.Forms.ComboBox ComboBoxGraph;
    }
}