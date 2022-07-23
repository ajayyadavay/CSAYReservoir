namespace CSAY_RESERVOIR
{
    partial class FrmAbout
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
            this.LblStart = new System.Windows.Forms.Label();
            this.LblRequirement = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStart.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblStart.Location = new System.Drawing.Point(83, 19);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(489, 26);
            this.LblStart.TabIndex = 44;
            this.LblStart.Text = "WATER RESOURCE PLANNING AND MANAGEMENT";
            // 
            // LblRequirement
            // 
            this.LblRequirement.AutoSize = true;
            this.LblRequirement.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRequirement.ForeColor = System.Drawing.Color.DarkViolet;
            this.LblRequirement.Location = new System.Drawing.Point(115, 81);
            this.LblRequirement.Name = "LblRequirement";
            this.LblRequirement.Size = new System.Drawing.Size(463, 52);
            this.LblRequirement.TabIndex = 46;
            this.LblRequirement.Text = "Requirement: Dot Net Framework 4.6.1\r\n(Created by: Ajay Yadav (github.com/ajayyad" +
    "avay))";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnExit.Location = new System.Drawing.Point(437, 179);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(157, 37);
            this.BtnExit.TabIndex = 47;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 238);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblRequirement);
            this.Controls.Add(this.LblStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Label LblRequirement;
        private System.Windows.Forms.Button BtnExit;
    }
}