namespace CSAY_RESERVOIR
{
    partial class FrmTFMAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTFMAbout));
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblRequirement = new System.Windows.Forms.Label();
            this.LblStart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnExit.Location = new System.Drawing.Point(39, 440);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(157, 37);
            this.BtnExit.TabIndex = 51;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblRequirement
            // 
            this.LblRequirement.AutoSize = true;
            this.LblRequirement.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRequirement.ForeColor = System.Drawing.Color.DarkViolet;
            this.LblRequirement.Location = new System.Drawing.Point(239, 74);
            this.LblRequirement.Name = "LblRequirement";
            this.LblRequirement.Size = new System.Drawing.Size(463, 52);
            this.LblRequirement.TabIndex = 50;
            this.LblRequirement.Text = "Requirement:  Dot Net Framework 4.6.1\r\n(Created by: Ajay Yadav (github.com/ajayya" +
    "davay))";
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStart.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblStart.Location = new System.Drawing.Point(239, 22);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(489, 52);
            this.LblStart.TabIndex = 48;
            this.LblStart.Text = "WATER RESOURCE PLANNING AND MANAGEMENT\r\n                 THOMAS FIERING METHOD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(35, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 253);
            this.label2.TabIndex = 52;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(458, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 161);
            this.label3.TabIndex = 53;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(458, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 161);
            this.label1.TabIndex = 54;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FrmTFMAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblRequirement);
            this.Controls.Add(this.LblStart);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTFMAbout";
            this.Text = "TFMAbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblRequirement;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}