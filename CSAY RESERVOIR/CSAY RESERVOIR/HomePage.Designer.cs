namespace CSAY_RESERVOIR
{
    partial class FrmHomePage
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
            this.LblNavigateFor = new System.Windows.Forms.Label();
            this.BtnProceed = new System.Windows.Forms.Button();
            this.ComboBoxMain = new System.Windows.Forms.ComboBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.LblStart = new System.Windows.Forms.Label();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.LblNavigateTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNavigateFor
            // 
            this.LblNavigateFor.AutoSize = true;
            this.LblNavigateFor.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNavigateFor.ForeColor = System.Drawing.Color.Black;
            this.LblNavigateFor.Location = new System.Drawing.Point(171, 73);
            this.LblNavigateFor.Name = "LblNavigateFor";
            this.LblNavigateFor.Size = new System.Drawing.Size(140, 29);
            this.LblNavigateFor.TabIndex = 41;
            this.LblNavigateFor.Text = "Navigate For";
            // 
            // BtnProceed
            // 
            this.BtnProceed.BackColor = System.Drawing.Color.White;
            this.BtnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProceed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnProceed.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProceed.ForeColor = System.Drawing.Color.Green;
            this.BtnProceed.Location = new System.Drawing.Point(344, 370);
            this.BtnProceed.Name = "BtnProceed";
            this.BtnProceed.Size = new System.Drawing.Size(246, 37);
            this.BtnProceed.TabIndex = 42;
            this.BtnProceed.Text = "Proceed";
            this.BtnProceed.UseVisualStyleBackColor = false;
            this.BtnProceed.Click += new System.EventHandler(this.BtnProceed_Click);
            // 
            // ComboBoxMain
            // 
            this.ComboBoxMain.AllowDrop = true;
            this.ComboBoxMain.BackColor = System.Drawing.Color.White;
            this.ComboBoxMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxMain.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMain.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ComboBoxMain.FormattingEnabled = true;
            this.ComboBoxMain.Location = new System.Drawing.Point(176, 105);
            this.ComboBoxMain.Name = "ComboBoxMain";
            this.ComboBoxMain.Size = new System.Drawing.Size(521, 37);
            this.ComboBoxMain.Sorted = true;
            this.ComboBoxMain.TabIndex = 43;
            this.ComboBoxMain.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMain_SelectedIndexChanged);
            this.ComboBoxMain.SelectedValueChanged += new System.EventHandler(this.ComboBoxMain_SelectedValueChanged);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Green;
            this.BtnExit.Location = new System.Drawing.Point(707, 370);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(157, 37);
            this.BtnExit.TabIndex = 44;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.Color.White;
            this.BtnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAbout.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.Color.Green;
            this.BtnAbout.Location = new System.Drawing.Point(46, 370);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(157, 37);
            this.BtnAbout.TabIndex = 45;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStart.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblStart.Location = new System.Drawing.Point(208, 24);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(489, 26);
            this.LblStart.TabIndex = 46;
            this.LblStart.Text = "WATER RESOURCE PLANNING AND MANAGEMENT";
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.AllowDrop = true;
            this.comboBoxBranch.BackColor = System.Drawing.Color.White;
            this.comboBoxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBranch.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBranch.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(176, 255);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(521, 37);
            this.comboBoxBranch.Sorted = true;
            this.comboBoxBranch.TabIndex = 48;
            // 
            // LblNavigateTo
            // 
            this.LblNavigateTo.AutoSize = true;
            this.LblNavigateTo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNavigateTo.ForeColor = System.Drawing.Color.Black;
            this.LblNavigateTo.Location = new System.Drawing.Point(171, 205);
            this.LblNavigateTo.Name = "LblNavigateTo";
            this.LblNavigateTo.Size = new System.Drawing.Size(117, 26);
            this.LblNavigateTo.TabIndex = 47;
            this.LblNavigateTo.Text = "Navigate To";
            // 
            // FrmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 447);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.LblNavigateTo);
            this.Controls.Add(this.LblStart);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.ComboBoxMain);
            this.Controls.Add(this.BtnProceed);
            this.Controls.Add(this.LblNavigateFor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmHomePage";
            this.Text = "CSAY WRPM HomePage";
            this.Load += new System.EventHandler(this.FrmHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNavigateFor;
        private System.Windows.Forms.Button BtnProceed;
        private System.Windows.Forms.ComboBox ComboBoxMain;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Label LblNavigateTo;
    }
}