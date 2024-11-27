namespace StandaloneSDKDemo
{
    partial class MonthlyReport2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyReport2));
            this.button2 = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.gv_Attlog = new System.Windows.Forms.DataGridView();
            this.Organization_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.comboBox1Date = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Attlog)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(232)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1415, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 185;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(232)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1052, 33);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(122, 37);
            this.btnExport.TabIndex = 176;
            this.btnExport.Text = "PDF";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(232)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(826, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 37);
            this.button1.TabIndex = 175;
            this.button1.Text = "ReadData";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(52, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 172;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1192, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 171;
            this.label3.Text = "Month";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090"});
            this.comboBoxYear.Location = new System.Drawing.Point(154, 25);
            this.comboBoxYear.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(244, 24);
            this.comboBoxYear.TabIndex = 164;
            // 
            // gv_Attlog
            // 
            this.gv_Attlog.AllowUserToAddRows = false;
            this.gv_Attlog.AllowUserToOrderColumns = true;
            this.gv_Attlog.AllowUserToResizeRows = false;
            this.gv_Attlog.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gv_Attlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Attlog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(143)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Attlog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Attlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Attlog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Organization_ID,
            this.ID,
            this.Column4,
            this.Date,
            this.VType,
            this.VState,
            this.Workcode,
            this.Column1,
            this.Column2,
            this.Column3});
            this.gv_Attlog.Location = new System.Drawing.Point(36, 84);
            this.gv_Attlog.Margin = new System.Windows.Forms.Padding(4);
            this.gv_Attlog.MultiSelect = false;
            this.gv_Attlog.Name = "gv_Attlog";
            this.gv_Attlog.ReadOnly = true;
            this.gv_Attlog.RowHeadersWidth = 20;
            this.gv_Attlog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Attlog.RowTemplate.Height = 23;
            this.gv_Attlog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Attlog.Size = new System.Drawing.Size(1587, 397);
            this.gv_Attlog.TabIndex = 167;
            this.gv_Attlog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Attlog_CellContentClick);
            // 
            // Organization_ID
            // 
            this.Organization_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Organization_ID.DataPropertyName = "Organization_ID";
            this.Organization_ID.HeaderText = "Organization_ID";
            this.Organization_ID.Name = "Organization_ID";
            this.Organization_ID.ReadOnly = true;
            this.Organization_ID.Width = 188;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "User ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Username";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Verify Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // VType
            // 
            this.VType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VType.DataPropertyName = "VType";
            this.VType.FillWeight = 80F;
            this.VType.HeaderText = "Verify Type";
            this.VType.Name = "VType";
            this.VType.ReadOnly = true;
            // 
            // VState
            // 
            this.VState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VState.DataPropertyName = "VState";
            this.VState.FillWeight = 80F;
            this.VState.HeaderText = "Verify State";
            this.VState.Name = "VState";
            this.VState.ReadOnly = true;
            // 
            // Workcode
            // 
            this.Workcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Workcode.DataPropertyName = "Workcode";
            this.Workcode.FillWeight = 80F;
            this.Workcode.HeaderText = "WorkCode";
            this.Workcode.Name = "Workcode";
            this.Workcode.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Time In";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Time Out";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 170;
            this.label2.Text = "Fiscal Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 169;
            this.label1.Text = "Monthly Ledger  Report";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.BackColor = System.Drawing.Color.White;
            this.comboBoxMonth.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "Baisakh",
            "Jestha",
            "Ashadh",
            "Shrawan",
            "Bhadra",
            "Ashwin",
            "Kartik",
            "Mangsir",
            "Poush",
            "Magh",
            "Falgun",
            "Chaitra"});
            this.comboBoxMonth.Location = new System.Drawing.Point(1304, 19);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(182, 29);
            this.comboBoxMonth.TabIndex = 165;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(232)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(618, 33);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(153, 37);
            this.btnFilter.TabIndex = 168;
            this.btnFilter.Text = "Filter Data";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_2);
            // 
            // comboBox1Date
            // 
            this.comboBox1Date.BackColor = System.Drawing.Color.White;
            this.comboBox1Date.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1Date.FormattingEnabled = true;
            this.comboBox1Date.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.comboBox1Date.Location = new System.Drawing.Point(127, 128);
            this.comboBox1Date.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1Date.Name = "comboBox1Date";
            this.comboBox1Date.Size = new System.Drawing.Size(271, 29);
            this.comboBox1Date.TabIndex = 166;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1181, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 29);
            this.label6.TabIndex = 186;
            this.label6.Text = "Username";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Corbel", 10.2F);
            this.txtBoxName.ForeColor = System.Drawing.Color.Black;
            this.txtBoxName.Location = new System.Drawing.Point(1304, 128);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(182, 27);
            this.txtBoxName.TabIndex = 187;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.gv_Attlog);
            this.panel1.Location = new System.Drawing.Point(20, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1643, 500);
            this.panel1.TabIndex = 188;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1564, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 188;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(232)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1244, 33);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 37);
            this.button3.TabIndex = 187;
            this.button3.Text = "Excel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MonthlyReport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBox1Date);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MonthlyReport2";
            this.Size = new System.Drawing.Size(1681, 807);
            this.Load += new System.EventHandler(this.MonthlyReport2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Attlog)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.DataGridView gv_Attlog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox comboBox1Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn VType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
