namespace StandaloneSDKDemo
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbSysOutputInfo = new System.Windows.Forms.ListBox();
            this.cmsDemoEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnMonthlyReports = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnTerminal = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicSmall = new System.Windows.Forms.PictureBox();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRTOutputInfo = new System.Windows.Forms.ListBox();
            this.cmsDeviceRTEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearInfoMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlMiddle = new System.Windows.Forms.Panel();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PrgSTA = new System.Windows.Forms.ToolStripProgressBar();
            this.lbVer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmsDemoEvent.SuspendLayout();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.cmsDeviceRTEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSysOutputInfo
            // 
            this.lbSysOutputInfo.ContextMenuStrip = this.cmsDemoEvent;
            this.lbSysOutputInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSysOutputInfo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSysOutputInfo.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSysOutputInfo.FormattingEnabled = true;
            this.lbSysOutputInfo.ItemHeight = 20;
            this.lbSysOutputInfo.Location = new System.Drawing.Point(0, 33);
            this.lbSysOutputInfo.Margin = new System.Windows.Forms.Padding(4);
            this.lbSysOutputInfo.Name = "lbSysOutputInfo";
            this.lbSysOutputInfo.Size = new System.Drawing.Size(767, 182);
            this.lbSysOutputInfo.TabIndex = 77;
            this.lbSysOutputInfo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbSysOutputInfo_DrawItem);
            this.lbSysOutputInfo.SelectedIndexChanged += new System.EventHandler(this.lbSysOutputInfo_SelectedIndexChanged);
            // 
            // cmsDemoEvent
            // 
            this.cmsDemoEvent.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDemoEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearInfoMenuItem});
            this.cmsDemoEvent.Name = "contextMenuStripDevice";
            this.cmsDemoEvent.Size = new System.Drawing.Size(113, 28);
            // 
            // ClearInfoMenuItem
            // 
            this.ClearInfoMenuItem.Name = "ClearInfoMenuItem";
            this.ClearInfoMenuItem.Size = new System.Drawing.Size(112, 24);
            this.ClearInfoMenuItem.Text = "Clear";
            this.ClearInfoMenuItem.Click += new System.EventHandler(this.ClearInfoMenuItem_Click);
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(144)))));
            this.PnlTop.Controls.Add(this.btnAttendance);
            this.PnlTop.Controls.Add(this.btnMonthlyReports);
            this.PnlTop.Controls.Add(this.btnLeave);
            this.PnlTop.Controls.Add(this.btnRole);
            this.PnlTop.Controls.Add(this.btnHomepage);
            this.PnlTop.Controls.Add(this.btnUsers);
            this.PnlTop.Controls.Add(this.btnTerminal);
            this.PnlTop.Controls.Add(this.btnEmployees);
            this.PnlTop.Controls.Add(this.btnSettings);
            this.PnlTop.Controls.Add(this.pictureBox1);
            this.PnlTop.Controls.Add(this.PicSmall);
            this.PnlTop.Controls.Add(this.PicClose);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlTop.ForeColor = System.Drawing.Color.White;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1679, 70);
            this.PnlTop.TabIndex = 83;
            this.PnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTop_Paint_1);
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.PnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            this.PnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseUp);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btnAttendance.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAttendance.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendance.Image")));
            this.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAttendance.Location = new System.Drawing.Point(1209, -9);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(139, 78);
            this.btnAttendance.TabIndex = 16;
            this.btnAttendance.Text = "हाजिरी";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.OnMainNavButtonClicked);
            // 
            // btnMonthlyReports
            // 
            this.btnMonthlyReports.BackColor = System.Drawing.Color.Transparent;
            this.btnMonthlyReports.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnMonthlyReports.FlatAppearance.BorderSize = 0;
            this.btnMonthlyReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMonthlyReports.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyReports.Image = ((System.Drawing.Image)(resources.GetObject("btnMonthlyReports.Image")));
            this.btnMonthlyReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMonthlyReports.Location = new System.Drawing.Point(1012, -9);
            this.btnMonthlyReports.Name = "btnMonthlyReports";
            this.btnMonthlyReports.Size = new System.Drawing.Size(191, 78);
            this.btnMonthlyReports.TabIndex = 15;
            this.btnMonthlyReports.Text = "मासिक प्रतिवेदन";
            this.btnMonthlyReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMonthlyReports.UseVisualStyleBackColor = false;
            this.btnMonthlyReports.Click += new System.EventHandler(this.OnMainNavButtonClicked);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.Transparent;
            this.btnLeave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnLeave.FlatAppearance.BorderSize = 0;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeave.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.Image = ((System.Drawing.Image)(resources.GetObject("btnLeave.Image")));
            this.btnLeave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLeave.Location = new System.Drawing.Point(1518, -9);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(139, 78);
            this.btnLeave.TabIndex = 17;
            this.btnLeave.Text = "बिदा";
            this.btnLeave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.OnMainNavButtonClicked);
            // 
            // btnRole
            // 
            this.btnRole.BackColor = System.Drawing.Color.Transparent;
            this.btnRole.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnRole.FlatAppearance.BorderSize = 0;
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRole.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRole.Image = ((System.Drawing.Image)(resources.GetObject("btnRole.Image")));
            this.btnRole.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRole.Location = new System.Drawing.Point(1357, -8);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(139, 78);
            this.btnRole.TabIndex = 18;
            this.btnRole.Text = "भूमिका";
            this.btnRole.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRole.UseVisualStyleBackColor = false;
            this.btnRole.Click += new System.EventHandler(this.OnMainNavButtonClicked);
            // 
            // btnHomepage
            // 
            this.btnHomepage.BackColor = System.Drawing.Color.Transparent;
            this.btnHomepage.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnHomepage.FlatAppearance.BorderSize = 0;
            this.btnHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHomepage.Font = new System.Drawing.Font("Dubai", 11F, System.Drawing.FontStyle.Bold);
            this.btnHomepage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomepage.Image")));
            this.btnHomepage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHomepage.Location = new System.Drawing.Point(292, 0);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(152, 69);
            this.btnHomepage.TabIndex = 17;
            this.btnHomepage.Text = "होमपेज";
            this.btnHomepage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHomepage.UseVisualStyleBackColor = false;
            this.btnHomepage.Click += new System.EventHandler(this.OnMainNavButtonClicked);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.Enabled = false;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsers.Font = new System.Drawing.Font("Dubai", 11F, System.Drawing.FontStyle.Bold);
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(469, -8);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(160, 75);
            this.btnUsers.TabIndex = 13;
            this.btnUsers.Text = "प्रयोगकर्ता";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.OnMainNavButtonClicked);
            // 
            // btnTerminal
            // 
            this.btnTerminal.BackColor = System.Drawing.Color.Transparent;
            this.btnTerminal.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnTerminal.FlatAppearance.BorderSize = 0;
            this.btnTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerminal.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnTerminal.Image = ((System.Drawing.Image)(resources.GetObject("btnTerminal.Image")));
            this.btnTerminal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTerminal.Location = new System.Drawing.Point(117, -9);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Size = new System.Drawing.Size(147, 78);
            this.btnTerminal.TabIndex = 10;
            this.btnTerminal.Text = "टर्मिनल";
            this.btnTerminal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTerminal.UseVisualStyleBackColor = false;
            this.btnTerminal.Click += new System.EventHandler(this.OnMainNavButtonClicked);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployees.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployees.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployees.Location = new System.Drawing.Point(849, -8);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(147, 78);
            this.btnEmployees.TabIndex = 10;
            this.btnEmployees.Text = "कर्मचारीहरू";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.OnMainNavButtonClicked);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Enabled = false;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Bold);
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(658, -8);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(147, 78);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "सेटिङ्स";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.OnMainNavButtonClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StandaloneSDKDemo.Properties.Resources.main_logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicHome_MouseClick);
            // 
            // PicSmall
            // 
            this.PicSmall.Location = new System.Drawing.Point(0, 0);
            this.PicSmall.Margin = new System.Windows.Forms.Padding(2);
            this.PicSmall.Name = "PicSmall";
            this.PicSmall.Size = new System.Drawing.Size(67, 32);
            this.PicSmall.TabIndex = 11;
            this.PicSmall.TabStop = false;
            // 
            // PicClose
            // 
            this.PicClose.Location = new System.Drawing.Point(0, 0);
            this.PicClose.Margin = new System.Windows.Forms.Padding(2);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(67, 32);
            this.PicClose.TabIndex = 12;
            this.PicClose.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(908, 33);
            this.label2.TabIndex = 85;
            this.label2.Text = "Device Real-Time Event:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 33);
            this.label1.TabIndex = 84;
            this.label1.Text = "Device Event:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRTOutputInfo
            // 
            this.lbRTOutputInfo.ContextMenuStrip = this.cmsDeviceRTEvent;
            this.lbRTOutputInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRTOutputInfo.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRTOutputInfo.FormattingEnabled = true;
            this.lbRTOutputInfo.ItemHeight = 22;
            this.lbRTOutputInfo.Location = new System.Drawing.Point(0, 33);
            this.lbRTOutputInfo.Margin = new System.Windows.Forms.Padding(4);
            this.lbRTOutputInfo.Name = "lbRTOutputInfo";
            this.lbRTOutputInfo.Size = new System.Drawing.Size(908, 182);
            this.lbRTOutputInfo.TabIndex = 83;
            // 
            // cmsDeviceRTEvent
            // 
            this.cmsDeviceRTEvent.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDeviceRTEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearInfoMenuItem1});
            this.cmsDeviceRTEvent.Name = "contextMenuStripDevice";
            this.cmsDeviceRTEvent.Size = new System.Drawing.Size(113, 28);
            // 
            // ClearInfoMenuItem1
            // 
            this.ClearInfoMenuItem1.Name = "ClearInfoMenuItem1";
            this.ClearInfoMenuItem1.Size = new System.Drawing.Size(112, 24);
            this.ClearInfoMenuItem1.Text = "Clear";
            this.ClearInfoMenuItem1.Click += new System.EventHandler(this.ClearInfoMenuItem1_Click);
            // 
            // PnlMiddle
            // 
            this.PnlMiddle.AutoSize = true;
            this.PnlMiddle.BackColor = System.Drawing.Color.White;
            this.PnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMiddle.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlMiddle.Location = new System.Drawing.Point(0, 70);
            this.PnlMiddle.Margin = new System.Windows.Forms.Padding(4);
            this.PnlMiddle.Name = "PnlMiddle";
            this.PnlMiddle.Size = new System.Drawing.Size(1679, 295);
            this.PnlMiddle.TabIndex = 86;
            this.PnlMiddle.AutoSizeChanged += new System.EventHandler(this.PnlMiddle_AutoSizeChanged);
            this.PnlMiddle.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMiddle_Paint);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.propertyToolStripMenuItem.Text = "Property";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 365);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbSysOutputInfo);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbRTOutputInfo);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1679, 215);
            this.splitContainer1.SplitterDistance = 767;
            this.splitContainer1.TabIndex = 87;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrgSTA,
            this.lbVer,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1679, 25);
            this.statusStrip1.TabIndex = 88;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PrgSTA
            // 
            this.PrgSTA.Name = "PrgSTA";
            this.PrgSTA.Size = new System.Drawing.Size(250, 19);
            // 
            // lbVer
            // 
            this.lbVer.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(109, 20);
            this.lbVer.Text = "Demo Version";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(96, 20);
            this.toolStripStatusLabel2.Text = "SDK Version";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(414, 20);
            this.toolStripStatusLabel3.Text = "Copyright © 2017 ZKTECO CO., LTD. All Rights Reserved.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1679, 605);
            this.Controls.Add(this.PnlMiddle);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.cmsDemoEvent.ResumeLayout(false);
            this.PnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.cmsDeviceRTEvent.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel PnlMiddle;
        private System.Windows.Forms.PictureBox PicClose;
        private System.Windows.Forms.PictureBox PicSmall;
        private System.Windows.Forms.PictureBox pictureBox1;
        public  System.Windows.Forms.ListBox lbSysOutputInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRTOutputInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsDemoEvent;
        private System.Windows.Forms.ToolStripMenuItem ClearInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDeviceRTEvent;
        private System.Windows.Forms.ToolStripMenuItem ClearInfoMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripProgressBar PrgSTA;
        private System.Windows.Forms.ToolStripStatusLabel lbVer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnTerminal;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnMonthlyReports;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnRole;
    }
}

