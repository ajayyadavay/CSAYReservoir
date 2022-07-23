namespace CSAY_RESERVOIR
{
    partial class FrmReservoirOperationForHP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabElevVolArea = new System.Windows.Forms.TabPage();
            this.TabInflowEvaporation = new System.Windows.Forms.TabPage();
            this.TabParameters = new System.Windows.Forms.TabPage();
            this.LblNumberOfData = new System.Windows.Forms.Label();
            this.TxtNumberOfData = new System.Windows.Forms.TextBox();
            this.BtnImport = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColElevation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumberOfData1 = new System.Windows.Forms.TextBox();
            this.BtnImportFromExcel1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColSN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInflow1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEvaporation1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCapacity = new System.Windows.Forms.TextBox();
            this.LblCapacity = new System.Windows.Forms.Label();
            this.TxtMonthsPerPeriod = new System.Windows.Forms.TextBox();
            this.LblInitialstorage = new System.Windows.Forms.Label();
            this.TxtMinPower = new System.Windows.Forms.TextBox();
            this.LblStart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEfficiency = new System.Windows.Forms.TextBox();
            this.TxtInitialStorage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTWL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnExportToExcel = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSimulate = new System.Windows.Forms.Button();
            this.ColSav_star2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSav2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOverFlow2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStorageTP12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRelease2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEvaporation2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInflow2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStorage2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPeriod2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LblTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabElevVolArea.SuspendLayout();
            this.TabInflowEvaporation.SuspendLayout();
            this.TabParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabParameters);
            this.tabControl1.Controls.Add(this.TabElevVolArea);
            this.tabControl1.Controls.Add(this.TabInflowEvaporation);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(68, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 219);
            this.tabControl1.TabIndex = 0;
            // 
            // TabElevVolArea
            // 
            this.TabElevVolArea.Controls.Add(this.LblNumberOfData);
            this.TabElevVolArea.Controls.Add(this.TxtNumberOfData);
            this.TabElevVolArea.Controls.Add(this.BtnImport);
            this.TabElevVolArea.Controls.Add(this.dataGridView);
            this.TabElevVolArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabElevVolArea.Location = new System.Drawing.Point(4, 27);
            this.TabElevVolArea.Name = "TabElevVolArea";
            this.TabElevVolArea.Padding = new System.Windows.Forms.Padding(3);
            this.TabElevVolArea.Size = new System.Drawing.Size(914, 188);
            this.TabElevVolArea.TabIndex = 0;
            this.TabElevVolArea.Text = "Elev-Vol-Area";
            this.TabElevVolArea.UseVisualStyleBackColor = true;
            // 
            // TabInflowEvaporation
            // 
            this.TabInflowEvaporation.Controls.Add(this.label1);
            this.TabInflowEvaporation.Controls.Add(this.TxtNumberOfData1);
            this.TabInflowEvaporation.Controls.Add(this.BtnImportFromExcel1);
            this.TabInflowEvaporation.Controls.Add(this.dataGridView1);
            this.TabInflowEvaporation.Location = new System.Drawing.Point(4, 27);
            this.TabInflowEvaporation.Name = "TabInflowEvaporation";
            this.TabInflowEvaporation.Padding = new System.Windows.Forms.Padding(3);
            this.TabInflowEvaporation.Size = new System.Drawing.Size(914, 188);
            this.TabInflowEvaporation.TabIndex = 1;
            this.TabInflowEvaporation.Text = "Inflow and Evaporation";
            this.TabInflowEvaporation.UseVisualStyleBackColor = true;
            // 
            // TabParameters
            // 
            this.TabParameters.Controls.Add(this.TxtTWL);
            this.TabParameters.Controls.Add(this.label4);
            this.TabParameters.Controls.Add(this.TxtInitialStorage);
            this.TabParameters.Controls.Add(this.label3);
            this.TabParameters.Controls.Add(this.TxtCapacity);
            this.TabParameters.Controls.Add(this.LblCapacity);
            this.TabParameters.Controls.Add(this.TxtMonthsPerPeriod);
            this.TabParameters.Controls.Add(this.LblInitialstorage);
            this.TabParameters.Controls.Add(this.TxtMinPower);
            this.TabParameters.Controls.Add(this.LblStart);
            this.TabParameters.Controls.Add(this.label2);
            this.TabParameters.Controls.Add(this.TxtEfficiency);
            this.TabParameters.ForeColor = System.Drawing.Color.Black;
            this.TabParameters.Location = new System.Drawing.Point(4, 27);
            this.TabParameters.Name = "TabParameters";
            this.TabParameters.Size = new System.Drawing.Size(914, 188);
            this.TabParameters.TabIndex = 2;
            this.TabParameters.Text = "Parameters";
            this.TabParameters.UseVisualStyleBackColor = true;
            // 
            // LblNumberOfData
            // 
            this.LblNumberOfData.AutoSize = true;
            this.LblNumberOfData.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberOfData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblNumberOfData.Location = new System.Drawing.Point(52, 30);
            this.LblNumberOfData.Name = "LblNumberOfData";
            this.LblNumberOfData.Size = new System.Drawing.Size(153, 26);
            this.LblNumberOfData.TabIndex = 50;
            this.LblNumberOfData.Text = "Number of data";
            // 
            // TxtNumberOfData
            // 
            this.TxtNumberOfData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumberOfData.Location = new System.Drawing.Point(39, 59);
            this.TxtNumberOfData.Name = "TxtNumberOfData";
            this.TxtNumberOfData.Size = new System.Drawing.Size(187, 30);
            this.TxtNumberOfData.TabIndex = 49;
            this.TxtNumberOfData.TextChanged += new System.EventHandler(this.TxtNumberOfData_TextChanged);
            // 
            // BtnImport
            // 
            this.BtnImport.BackColor = System.Drawing.Color.White;
            this.BtnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnImport.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImport.ForeColor = System.Drawing.Color.Green;
            this.BtnImport.Location = new System.Drawing.Point(35, 101);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(191, 72);
            this.BtnImport.TabIndex = 48;
            this.BtnImport.Text = "Import Elevation Capacity Area";
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSN,
            this.ColElevation,
            this.ColCapacity,
            this.ColArea});
            this.dataGridView.Location = new System.Drawing.Point(403, 15);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(434, 158);
            this.dataGridView.TabIndex = 47;
            // 
            // ColSN
            // 
            this.ColSN.HeaderText = "SN";
            this.ColSN.Name = "ColSN";
            this.ColSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColElevation
            // 
            this.ColElevation.HeaderText = "Elevation (m)";
            this.ColElevation.Name = "ColElevation";
            this.ColElevation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColCapacity
            // 
            this.ColCapacity.HeaderText = "Capacity (Mm3)";
            this.ColCapacity.Name = "ColCapacity";
            this.ColCapacity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColArea
            // 
            this.ColArea.HeaderText = "Area (Mm2)";
            this.ColArea.Name = "ColArea";
            this.ColArea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 54;
            this.label1.Text = "Number of data";
            // 
            // TxtNumberOfData1
            // 
            this.TxtNumberOfData1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumberOfData1.Location = new System.Drawing.Point(45, 59);
            this.TxtNumberOfData1.Name = "TxtNumberOfData1";
            this.TxtNumberOfData1.Size = new System.Drawing.Size(187, 30);
            this.TxtNumberOfData1.TabIndex = 53;
            this.TxtNumberOfData1.TextChanged += new System.EventHandler(this.TxtNumberOfData1_TextChanged);
            // 
            // BtnImportFromExcel1
            // 
            this.BtnImportFromExcel1.BackColor = System.Drawing.Color.White;
            this.BtnImportFromExcel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImportFromExcel1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnImportFromExcel1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportFromExcel1.ForeColor = System.Drawing.Color.Green;
            this.BtnImportFromExcel1.Location = new System.Drawing.Point(41, 101);
            this.BtnImportFromExcel1.Name = "BtnImportFromExcel1";
            this.BtnImportFromExcel1.Size = new System.Drawing.Size(191, 72);
            this.BtnImportFromExcel1.TabIndex = 52;
            this.BtnImportFromExcel1.Text = "Import Inflow and Evaporation";
            this.BtnImportFromExcel1.UseVisualStyleBackColor = false;
            this.BtnImportFromExcel1.Click += new System.EventHandler(this.BtnImportFromExcel1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSN1,
            this.ColPeriod,
            this.ColInflow1,
            this.ColEvaporation1});
            this.dataGridView1.Location = new System.Drawing.Point(418, 15);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(434, 158);
            this.dataGridView1.TabIndex = 51;
            // 
            // ColSN1
            // 
            this.ColSN1.HeaderText = "SN";
            this.ColSN1.Name = "ColSN1";
            this.ColSN1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPeriod
            // 
            this.ColPeriod.HeaderText = "Period";
            this.ColPeriod.Name = "ColPeriod";
            this.ColPeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColInflow1
            // 
            this.ColInflow1.HeaderText = "Inflow (Mm3)";
            this.ColInflow1.Name = "ColInflow1";
            this.ColInflow1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColEvaporation1
            // 
            this.ColEvaporation1.HeaderText = "Evaporation (cm)";
            this.ColEvaporation1.Name = "ColEvaporation1";
            this.ColEvaporation1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TxtCapacity
            // 
            this.TxtCapacity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCapacity.Location = new System.Drawing.Point(747, 36);
            this.TxtCapacity.Name = "TxtCapacity";
            this.TxtCapacity.Size = new System.Drawing.Size(135, 30);
            this.TxtCapacity.TabIndex = 56;
            this.TxtCapacity.Text = "1250";
            // 
            // LblCapacity
            // 
            this.LblCapacity.AutoSize = true;
            this.LblCapacity.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblCapacity.Location = new System.Drawing.Point(520, 37);
            this.LblCapacity.Name = "LblCapacity";
            this.LblCapacity.Size = new System.Drawing.Size(172, 26);
            this.LblCapacity.TabIndex = 55;
            this.LblCapacity.Text = "Capacity (K), Mm3";
            // 
            // TxtMonthsPerPeriod
            // 
            this.TxtMonthsPerPeriod.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonthsPerPeriod.Location = new System.Drawing.Point(311, 137);
            this.TxtMonthsPerPeriod.Name = "TxtMonthsPerPeriod";
            this.TxtMonthsPerPeriod.Size = new System.Drawing.Size(161, 30);
            this.TxtMonthsPerPeriod.TabIndex = 54;
            this.TxtMonthsPerPeriod.Text = "3";
            // 
            // LblInitialstorage
            // 
            this.LblInitialstorage.AutoSize = true;
            this.LblInitialstorage.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInitialstorage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblInitialstorage.Location = new System.Drawing.Point(8, 141);
            this.LblInitialstorage.Name = "LblInitialstorage";
            this.LblInitialstorage.Size = new System.Drawing.Size(273, 26);
            this.LblInitialstorage.TabIndex = 53;
            this.LblInitialstorage.Text = "Number of Months Per Period";
            // 
            // TxtMinPower
            // 
            this.TxtMinPower.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinPower.Location = new System.Drawing.Point(311, 89);
            this.TxtMinPower.Name = "TxtMinPower";
            this.TxtMinPower.Size = new System.Drawing.Size(161, 30);
            this.TxtMinPower.TabIndex = 52;
            this.TxtMinPower.Text = "73.5";
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblStart.Location = new System.Drawing.Point(8, 90);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(297, 26);
            this.LblStart.TabIndex = 51;
            this.LblStart.Text = "Minimum Power Per period (MW)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 50;
            this.label2.Text = "Efficiency";
            // 
            // TxtEfficiency
            // 
            this.TxtEfficiency.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEfficiency.Location = new System.Drawing.Point(311, 33);
            this.TxtEfficiency.Name = "TxtEfficiency";
            this.TxtEfficiency.Size = new System.Drawing.Size(161, 30);
            this.TxtEfficiency.TabIndex = 49;
            this.TxtEfficiency.Text = "85";
            // 
            // TxtInitialStorage
            // 
            this.TxtInitialStorage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInitialStorage.Location = new System.Drawing.Point(747, 89);
            this.TxtInitialStorage.Name = "TxtInitialStorage";
            this.TxtInitialStorage.Size = new System.Drawing.Size(135, 30);
            this.TxtInitialStorage.TabIndex = 58;
            this.TxtInitialStorage.Text = "900";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(520, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 26);
            this.label3.TabIndex = 57;
            this.label3.Text = "Initial Storage (Mm3)";
            // 
            // TxtTWL
            // 
            this.TxtTWL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTWL.Location = new System.Drawing.Point(747, 137);
            this.TxtTWL.Name = "TxtTWL";
            this.TxtTWL.Size = new System.Drawing.Size(135, 30);
            this.TxtTWL.TabIndex = 60;
            this.TxtTWL.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(520, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 26);
            this.label4.TabIndex = 59;
            this.label4.Text = "Tail Water Level (m)";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.BtnExportToExcel);
            this.groupBox3.Controls.Add(this.BtnExit);
            this.groupBox3.Controls.Add(this.BtnSimulate);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(1037, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 183);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            // 
            // BtnExportToExcel
            // 
            this.BtnExportToExcel.BackColor = System.Drawing.Color.White;
            this.BtnExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExportToExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnExportToExcel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportToExcel.ForeColor = System.Drawing.Color.Green;
            this.BtnExportToExcel.Location = new System.Drawing.Point(13, 74);
            this.BtnExportToExcel.Name = "BtnExportToExcel";
            this.BtnExportToExcel.Size = new System.Drawing.Size(202, 37);
            this.BtnExportToExcel.TabIndex = 48;
            this.BtnExportToExcel.Text = "Export to Excel";
            this.BtnExportToExcel.UseVisualStyleBackColor = false;
            this.BtnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcel_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Green;
            this.BtnExit.Location = new System.Drawing.Point(13, 129);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(202, 37);
            this.BtnExit.TabIndex = 47;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSimulate
            // 
            this.BtnSimulate.BackColor = System.Drawing.Color.White;
            this.BtnSimulate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSimulate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSimulate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimulate.ForeColor = System.Drawing.Color.Green;
            this.BtnSimulate.Location = new System.Drawing.Point(13, 20);
            this.BtnSimulate.Name = "BtnSimulate";
            this.BtnSimulate.Size = new System.Drawing.Size(202, 37);
            this.BtnSimulate.TabIndex = 43;
            this.BtnSimulate.Text = "Simulate";
            this.BtnSimulate.UseVisualStyleBackColor = false;
            this.BtnSimulate.Click += new System.EventHandler(this.BtnSimulate_Click);
            // 
            // ColSav_star2
            // 
            this.ColSav_star2.HeaderText = "Sav*";
            this.ColSav_star2.Name = "ColSav_star2";
            this.ColSav_star2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColSav2
            // 
            this.ColSav2.HeaderText = "Sav";
            this.ColSav2.Name = "ColSav2";
            this.ColSav2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColOverFlow2
            // 
            this.ColOverFlow2.HeaderText = "OverFlow  O(T)";
            this.ColOverFlow2.Name = "ColOverFlow2";
            this.ColOverFlow2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColStorageTP12
            // 
            this.ColStorageTP12.HeaderText = "Storage  S(T+1)";
            this.ColStorageTP12.Name = "ColStorageTP12";
            this.ColStorageTP12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColRelease2
            // 
            this.ColRelease2.HeaderText = "Release  R(T)";
            this.ColRelease2.Name = "ColRelease2";
            this.ColRelease2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColEvaporation2
            // 
            this.ColEvaporation2.HeaderText = "Evaporation E(T)";
            this.ColEvaporation2.Name = "ColEvaporation2";
            this.ColEvaporation2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColInflow2
            // 
            this.ColInflow2.HeaderText = "Inflow  Q(T)";
            this.ColInflow2.Name = "ColInflow2";
            this.ColInflow2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColStorage2
            // 
            this.ColStorage2.HeaderText = "Storage  S(T)";
            this.ColStorage2.Name = "ColStorage2";
            this.ColStorage2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPeriod2
            // 
            this.ColPeriod2.HeaderText = "Period";
            this.ColPeriod2.Name = "ColPeriod2";
            this.ColPeriod2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPeriod2,
            this.ColStorage2,
            this.ColInflow2,
            this.ColEvaporation2,
            this.ColRelease2,
            this.ColStorageTP12,
            this.ColOverFlow2,
            this.ColSav2,
            this.ColSav_star2});
            this.dataGridView2.Location = new System.Drawing.Point(72, 300);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(942, 367);
            this.dataGridView2.TabIndex = 47;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTitle.Location = new System.Drawing.Point(393, 19);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(501, 26);
            this.LblTitle.TabIndex = 51;
            this.LblTitle.Text = "Simulation of Reservoir Operation for Power Generation";
            // 
            // FrmReservoirOperationForHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1287, 688);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmReservoirOperationForHP";
            this.Text = "ReservoirOperationForHP";
            this.Load += new System.EventHandler(this.FrmReservoirOperationForHP_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabElevVolArea.ResumeLayout(false);
            this.TabElevVolArea.PerformLayout();
            this.TabInflowEvaporation.ResumeLayout(false);
            this.TabInflowEvaporation.PerformLayout();
            this.TabParameters.ResumeLayout(false);
            this.TabParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabParameters;
        private System.Windows.Forms.TabPage TabElevVolArea;
        private System.Windows.Forms.TabPage TabInflowEvaporation;
        private System.Windows.Forms.Label LblNumberOfData;
        private System.Windows.Forms.TextBox TxtNumberOfData;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColElevation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumberOfData1;
        private System.Windows.Forms.Button BtnImportFromExcel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInflow1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEvaporation1;
        private System.Windows.Forms.TextBox TxtTWL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtInitialStorage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCapacity;
        private System.Windows.Forms.Label LblCapacity;
        private System.Windows.Forms.TextBox TxtMonthsPerPeriod;
        private System.Windows.Forms.Label LblInitialstorage;
        private System.Windows.Forms.TextBox TxtMinPower;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEfficiency;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnExportToExcel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSimulate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSav_star2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSav2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOverFlow2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStorageTP12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRelease2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEvaporation2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInflow2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStorage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPeriod2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label LblTitle;
    }
}