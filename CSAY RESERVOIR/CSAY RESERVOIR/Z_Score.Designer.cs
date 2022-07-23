namespace CSAY_RESERVOIR
{
    partial class FrmZScore
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
            this.LblNumberOfData = new System.Windows.Forms.Label();
            this.TxtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtmu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtsigma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtZ = new System.Windows.Forms.TextBox();
            this.LblCDF = new System.Windows.Forms.Label();
            this.TxtCDF = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNumberOfData
            // 
            this.LblNumberOfData.AutoSize = true;
            this.LblNumberOfData.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberOfData.ForeColor = System.Drawing.Color.DarkCyan;
            this.LblNumberOfData.Location = new System.Drawing.Point(103, 81);
            this.LblNumberOfData.Name = "LblNumberOfData";
            this.LblNumberOfData.Size = new System.Drawing.Size(26, 26);
            this.LblNumberOfData.TabIndex = 42;
            this.LblNumberOfData.Text = "X";
            // 
            // TxtX
            // 
            this.TxtX.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtX.Location = new System.Drawing.Point(95, 110);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(75, 30);
            this.TxtX.TabIndex = 41;
            this.TxtX.TextChanged += new System.EventHandler(this.TxtX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(213, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mean";
            // 
            // Txtmu
            // 
            this.Txtmu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtmu.Location = new System.Drawing.Point(205, 110);
            this.Txtmu.Name = "Txtmu";
            this.Txtmu.Size = new System.Drawing.Size(84, 30);
            this.Txtmu.TabIndex = 43;
            this.Txtmu.TextChanged += new System.EventHandler(this.Txtmu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(325, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 46;
            this.label2.Text = "Std. Dev";
            // 
            // Txtsigma
            // 
            this.Txtsigma.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtsigma.Location = new System.Drawing.Point(317, 110);
            this.Txtsigma.Name = "Txtsigma";
            this.Txtsigma.Size = new System.Drawing.Size(90, 30);
            this.Txtsigma.TabIndex = 45;
            this.Txtsigma.TextChanged += new System.EventHandler(this.Txtsigma_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(459, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 26);
            this.label3.TabIndex = 48;
            this.label3.Text = "Z";
            // 
            // TxtZ
            // 
            this.TxtZ.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtZ.Location = new System.Drawing.Point(433, 110);
            this.TxtZ.Name = "TxtZ";
            this.TxtZ.Size = new System.Drawing.Size(92, 30);
            this.TxtZ.TabIndex = 47;
            this.TxtZ.TextChanged += new System.EventHandler(this.TxtZ_TextChanged);
            // 
            // LblCDF
            // 
            this.LblCDF.AutoSize = true;
            this.LblCDF.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCDF.ForeColor = System.Drawing.Color.DarkCyan;
            this.LblCDF.Location = new System.Drawing.Point(564, 81);
            this.LblCDF.Name = "LblCDF";
            this.LblCDF.Size = new System.Drawing.Size(142, 26);
            this.LblCDF.TabIndex = 50;
            this.LblCDF.Text = "CDF (Z-Score)";
            // 
            // TxtCDF
            // 
            this.TxtCDF.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCDF.Location = new System.Drawing.Point(556, 110);
            this.TxtCDF.Name = "TxtCDF";
            this.TxtCDF.Size = new System.Drawing.Size(150, 30);
            this.TxtCDF.TabIndex = 49;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblTitle.Location = new System.Drawing.Point(312, 23);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(168, 26);
            this.LblTitle.TabIndex = 51;
            this.LblTitle.Text = "Calculate Z Score";
            this.LblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // FrmZScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 215);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblCDF);
            this.Controls.Add(this.TxtCDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtsigma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtmu);
            this.Controls.Add(this.LblNumberOfData);
            this.Controls.Add(this.TxtX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmZScore";
            this.Text = "Zscore";
            this.Load += new System.EventHandler(this.ThomasFieringModel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumberOfData;
        private System.Windows.Forms.TextBox TxtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtmu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtsigma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtZ;
        private System.Windows.Forms.Label LblCDF;
        private System.Windows.Forms.TextBox TxtCDF;
        private System.Windows.Forms.Label LblTitle;
    }
}