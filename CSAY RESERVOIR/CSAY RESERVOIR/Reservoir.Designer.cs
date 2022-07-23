namespace CSAY_RESERVOIR
{
    partial class FrmReservoir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCapacity = new System.Windows.Forms.TextBox();
            this.LblMessage = new System.Windows.Forms.Label();
            this.LblCapacity = new System.Windows.Forms.Label();
            this.TxtInitialStorage = new System.Windows.Forms.TextBox();
            this.LblInitialstorage = new System.Windows.Forms.Label();
            this.TxtStart = new System.Windows.Forms.TextBox();
            this.LblStart = new System.Windows.Forms.Label();
            this.LblNumberOfData = new System.Windows.Forms.Label();
            this.TxtNumberOfData = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInflow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEvapotrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOverFlow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RUNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.IMPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EXPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectedGridOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyFromGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToGidCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutFromGridCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveOneSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearValueOfSelectedCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveAllGridsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.EXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCapacity);
            this.groupBox1.Controls.Add(this.LblMessage);
            this.groupBox1.Controls.Add(this.LblCapacity);
            this.groupBox1.Controls.Add(this.TxtInitialStorage);
            this.groupBox1.Controls.Add(this.LblInitialstorage);
            this.groupBox1.Controls.Add(this.TxtStart);
            this.groupBox1.Controls.Add(this.LblStart);
            this.groupBox1.Controls.Add(this.LblNumberOfData);
            this.groupBox1.Controls.Add(this.TxtNumberOfData);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(92, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // TxtCapacity
            // 
            this.TxtCapacity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCapacity.Location = new System.Drawing.Point(620, 61);
            this.TxtCapacity.Name = "TxtCapacity";
            this.TxtCapacity.Size = new System.Drawing.Size(135, 30);
            this.TxtCapacity.TabIndex = 48;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblMessage.Location = new System.Drawing.Point(47, 113);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(664, 46);
            this.LblMessage.TabIndex = 49;
            this.LblMessage.Text = "Menu appears on right click\r\n\"Number of Data\" and \"Start\" to be entered first the" +
    "n \"Import from Excel\" on the menu";
            // 
            // LblCapacity
            // 
            this.LblCapacity.AutoSize = true;
            this.LblCapacity.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCapacity.ForeColor = System.Drawing.Color.DarkViolet;
            this.LblCapacity.Location = new System.Drawing.Point(629, 30);
            this.LblCapacity.Name = "LblCapacity";
            this.LblCapacity.Size = new System.Drawing.Size(117, 26);
            this.LblCapacity.TabIndex = 47;
            this.LblCapacity.Text = "Capacity (K)";
            // 
            // TxtInitialStorage
            // 
            this.TxtInitialStorage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInitialStorage.Location = new System.Drawing.Point(427, 61);
            this.TxtInitialStorage.Name = "TxtInitialStorage";
            this.TxtInitialStorage.Size = new System.Drawing.Size(135, 30);
            this.TxtInitialStorage.TabIndex = 46;
            // 
            // LblInitialstorage
            // 
            this.LblInitialstorage.AutoSize = true;
            this.LblInitialstorage.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInitialstorage.ForeColor = System.Drawing.Color.DarkViolet;
            this.LblInitialstorage.Location = new System.Drawing.Point(422, 30);
            this.LblInitialstorage.Name = "LblInitialstorage";
            this.LblInitialstorage.Size = new System.Drawing.Size(139, 26);
            this.LblInitialstorage.TabIndex = 45;
            this.LblInitialstorage.Text = "Initial Storage";
            // 
            // TxtStart
            // 
            this.TxtStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStart.Location = new System.Drawing.Point(256, 61);
            this.TxtStart.Name = "TxtStart";
            this.TxtStart.Size = new System.Drawing.Size(135, 30);
            this.TxtStart.TabIndex = 44;
            this.TxtStart.TextChanged += new System.EventHandler(this.TxtStart_TextChanged);
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStart.ForeColor = System.Drawing.Color.DarkViolet;
            this.LblStart.Location = new System.Drawing.Point(296, 32);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(60, 26);
            this.LblStart.TabIndex = 43;
            this.LblStart.Text = "Start";
            // 
            // LblNumberOfData
            // 
            this.LblNumberOfData.AutoSize = true;
            this.LblNumberOfData.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberOfData.ForeColor = System.Drawing.Color.DarkViolet;
            this.LblNumberOfData.Location = new System.Drawing.Point(59, 32);
            this.LblNumberOfData.Name = "LblNumberOfData";
            this.LblNumberOfData.Size = new System.Drawing.Size(153, 26);
            this.LblNumberOfData.TabIndex = 40;
            this.LblNumberOfData.Text = "Number of data";
            // 
            // TxtNumberOfData
            // 
            this.TxtNumberOfData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumberOfData.Location = new System.Drawing.Point(51, 61);
            this.TxtNumberOfData.Name = "TxtNumberOfData";
            this.TxtNumberOfData.Size = new System.Drawing.Size(161, 30);
            this.TxtNumberOfData.TabIndex = 39;
            this.TxtNumberOfData.TextChanged += new System.EventHandler(this.TxtNumberOfData_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTime,
            this.ColStorage,
            this.ColInflow,
            this.ColDemand,
            this.ColEvapotrans,
            this.ColRelease,
            this.ColSum,
            this.ColOverFlow});
            this.dataGridView.Location = new System.Drawing.Point(92, 245);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(859, 376);
            this.dataGridView.TabIndex = 30;
            // 
            // ColTime
            // 
            this.ColTime.HeaderText = "Time (T)";
            this.ColTime.Name = "ColTime";
            this.ColTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColStorage
            // 
            this.ColStorage.HeaderText = "Storage  S(T)";
            this.ColStorage.Name = "ColStorage";
            this.ColStorage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColInflow
            // 
            this.ColInflow.HeaderText = "Inflow  Q(T)";
            this.ColInflow.Name = "ColInflow";
            this.ColInflow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDemand
            // 
            this.ColDemand.HeaderText = "Demand  D(T)";
            this.ColDemand.Name = "ColDemand";
            this.ColDemand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColEvapotrans
            // 
            this.ColEvapotrans.HeaderText = "Evapotrans  E(T)";
            this.ColEvapotrans.Name = "ColEvapotrans";
            this.ColEvapotrans.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColRelease
            // 
            this.ColRelease.HeaderText = "Release  R(T)";
            this.ColRelease.Name = "ColRelease";
            this.ColRelease.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColSum
            // 
            this.ColSum.HeaderText = "Storage  S(T+1)";
            this.ColSum.Name = "ColSum";
            this.ColSum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColOverFlow
            // 
            this.ColOverFlow.HeaderText = "OverFlow  O(T)";
            this.ColOverFlow.Name = "ColOverFlow";
            this.ColOverFlow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RUNToolStripMenuItem,
            this.toolStripMenuItem2,
            this.IMPORTToolStripMenuItem,
            this.EXPORTToolStripMenuItem,
            this.toolStripMenuItem1,
            this.CopyFromGridToolStripMenuItem,
            this.PasteToGidCellsToolStripMenuItem,
            this.CutFromGridCellsToolStripMenuItem,
            this.toolStripMenuItem5,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem3,
            this.EXITToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 204);
            // 
            // RUNToolStripMenuItem
            // 
            this.RUNToolStripMenuItem.Name = "RUNToolStripMenuItem";
            this.RUNToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.RUNToolStripMenuItem.Text = "RUN";
            this.RUNToolStripMenuItem.Click += new System.EventHandler(this.RUNToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // IMPORTToolStripMenuItem
            // 
            this.IMPORTToolStripMenuItem.Name = "IMPORTToolStripMenuItem";
            this.IMPORTToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.IMPORTToolStripMenuItem.Text = "Import From Excel";
            this.IMPORTToolStripMenuItem.Click += new System.EventHandler(this.IMPORTToolStripMenuItem_Click);
            // 
            // EXPORTToolStripMenuItem
            // 
            this.EXPORTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllGridToolStripMenuItem,
            this.SelectedGridOnlyToolStripMenuItem});
            this.EXPORTToolStripMenuItem.Name = "EXPORTToolStripMenuItem";
            this.EXPORTToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.EXPORTToolStripMenuItem.Text = "Export To Excel";
            // 
            // AllGridToolStripMenuItem
            // 
            this.AllGridToolStripMenuItem.Name = "AllGridToolStripMenuItem";
            this.AllGridToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.AllGridToolStripMenuItem.Text = "All Cells";
            this.AllGridToolStripMenuItem.Click += new System.EventHandler(this.AllGridToolStripMenuItem_Click);
            // 
            // SelectedGridOnlyToolStripMenuItem
            // 
            this.SelectedGridOnlyToolStripMenuItem.Name = "SelectedGridOnlyToolStripMenuItem";
            this.SelectedGridOnlyToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SelectedGridOnlyToolStripMenuItem.Text = "Selected Cells Only";
            this.SelectedGridOnlyToolStripMenuItem.Click += new System.EventHandler(this.SelectedGridOnlyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // CopyFromGridToolStripMenuItem
            // 
            this.CopyFromGridToolStripMenuItem.Name = "CopyFromGridToolStripMenuItem";
            this.CopyFromGridToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.CopyFromGridToolStripMenuItem.Text = "Copy From Grid Cells";
            this.CopyFromGridToolStripMenuItem.Click += new System.EventHandler(this.CopyFromGridToolStripMenuItem_Click);
            // 
            // PasteToGidCellsToolStripMenuItem
            // 
            this.PasteToGidCellsToolStripMenuItem.Name = "PasteToGidCellsToolStripMenuItem";
            this.PasteToGidCellsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.PasteToGidCellsToolStripMenuItem.Text = "Paste To Gid Cells";
            this.PasteToGidCellsToolStripMenuItem.Click += new System.EventHandler(this.PasteToGidCellsToolStripMenuItem_Click);
            // 
            // CutFromGridCellsToolStripMenuItem
            // 
            this.CutFromGridCellsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveOneSelectedRowToolStripMenuItem,
            this.ClearValueOfSelectedCellsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.RemoveAllGridsToolStripMenuItem});
            this.CutFromGridCellsToolStripMenuItem.Name = "CutFromGridCellsToolStripMenuItem";
            this.CutFromGridCellsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.CutFromGridCellsToolStripMenuItem.Text = "Clear";
            // 
            // RemoveOneSelectedRowToolStripMenuItem
            // 
            this.RemoveOneSelectedRowToolStripMenuItem.Name = "RemoveOneSelectedRowToolStripMenuItem";
            this.RemoveOneSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.RemoveOneSelectedRowToolStripMenuItem.Text = "Remove One Selected Row";
            this.RemoveOneSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.RemoveOneSelectedRowToolStripMenuItem_Click);
            // 
            // ClearValueOfSelectedCellsToolStripMenuItem
            // 
            this.ClearValueOfSelectedCellsToolStripMenuItem.Name = "ClearValueOfSelectedCellsToolStripMenuItem";
            this.ClearValueOfSelectedCellsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.ClearValueOfSelectedCellsToolStripMenuItem.Text = "Clear Value Of Selected Cells";
            this.ClearValueOfSelectedCellsToolStripMenuItem.Click += new System.EventHandler(this.ClearValueOfSelectedCellsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(254, 6);
            // 
            // RemoveAllGridsToolStripMenuItem
            // 
            this.RemoveAllGridsToolStripMenuItem.Name = "RemoveAllGridsToolStripMenuItem";
            this.RemoveAllGridsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.RemoveAllGridsToolStripMenuItem.Text = "Remove All Grids";
            this.RemoveAllGridsToolStripMenuItem.Click += new System.EventHandler(this.RemoveAllGridsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(200, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(200, 6);
            // 
            // EXITToolStripMenuItem
            // 
            this.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem";
            this.EXITToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.EXITToolStripMenuItem.Text = "EXIT";
            this.EXITToolStripMenuItem.Click += new System.EventHandler(this.EXITToolStripMenuItem_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTitle.Location = new System.Drawing.Point(422, 38);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(299, 26);
            this.LblTitle.TabIndex = 50;
            this.LblTitle.Text = "Standard Operation Policy (SOP)";
            // 
            // FrmReservoir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 655);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmReservoir";
            this.Text = "Standard Operation Policy";
            this.Load += new System.EventHandler(this.FrmReservoir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtStart;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Label LblNumberOfData;
        private System.Windows.Forms.TextBox TxtNumberOfData;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox TxtInitialStorage;
        private System.Windows.Forms.Label LblInitialstorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInflow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEvapotrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOverFlow;
        private System.Windows.Forms.TextBox TxtCapacity;
        private System.Windows.Forms.Label LblCapacity;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RUNToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem IMPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EXPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectedGridOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CopyFromGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToGidCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutFromGridCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveOneSelectedRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearValueOfSelectedCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem RemoveAllGridsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem EXITToolStripMenuItem;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

