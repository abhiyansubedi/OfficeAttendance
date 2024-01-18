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
            this.lbSysOutputInfo = new System.Windows.Forms.ListBox();
            this.cmsDemoEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbVer = new System.Windows.Forms.Label();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.firstMenu6 = new StandaloneSDKDemo.FirstMenu();
            this.firstMenu5 = new StandaloneSDKDemo.FirstMenu();
            this.firstMenu4 = new StandaloneSDKDemo.FirstMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicSmall = new System.Windows.Forms.PictureBox();
            this.firstMenu3 = new StandaloneSDKDemo.FirstMenu();
            this.firstMenu2 = new StandaloneSDKDemo.FirstMenu();
            this.firstMenu1 = new StandaloneSDKDemo.FirstMenu();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRTOutputInfo = new System.Windows.Forms.ListBox();
            this.cmsDeviceRTEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearInfoMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PrgSTA = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlMiddle = new System.Windows.Forms.Panel();
            this.pnlPersonalize = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.pnlAccess = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlTerminal = new System.Windows.Forms.Panel();
            this.labAD = new System.Windows.Forms.Label();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDemoEvent.SuspendLayout();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.PnlBottom.SuspendLayout();
            this.cmsDeviceRTEvent.SuspendLayout();
            this.PnlMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSysOutputInfo
            // 
            this.lbSysOutputInfo.ContextMenuStrip = this.cmsDemoEvent;
            this.lbSysOutputInfo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSysOutputInfo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSysOutputInfo.FormattingEnabled = true;
            this.lbSysOutputInfo.ItemHeight = 12;
            this.lbSysOutputInfo.Location = new System.Drawing.Point(4, 33);
            this.lbSysOutputInfo.Margin = new System.Windows.Forms.Padding(6);
            this.lbSysOutputInfo.Name = "lbSysOutputInfo";
            this.lbSysOutputInfo.Size = new System.Drawing.Size(874, 304);
            this.lbSysOutputInfo.TabIndex = 77;
            this.lbSysOutputInfo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbSysOutputInfo_DrawItem);
            // 
            // cmsDemoEvent
            // 
            this.cmsDemoEvent.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDemoEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearInfoMenuItem});
            this.cmsDemoEvent.Name = "contextMenuStripDevice";
            this.cmsDemoEvent.Size = new System.Drawing.Size(145, 40);
            // 
            // ClearInfoMenuItem
            // 
            this.ClearInfoMenuItem.Name = "ClearInfoMenuItem";
            this.ClearInfoMenuItem.Size = new System.Drawing.Size(144, 36);
            this.ClearInfoMenuItem.Text = "Clear";
            this.ClearInfoMenuItem.Click += new System.EventHandler(this.ClearInfoMenuItem_Click);
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVer.ForeColor = System.Drawing.Color.Black;
            this.lbVer.Location = new System.Drawing.Point(596, 358);
            this.lbVer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(390, 29);
            this.lbVer.TabIndex = 80;
            this.lbVer.Text = "Demo Version:     SDK Version:";
            // 
            // PnlTop
            // 
            this.PnlTop.AutoSize = true;
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(67)))));
            this.PnlTop.Controls.Add(this.firstMenu6);
            this.PnlTop.Controls.Add(this.firstMenu5);
            this.PnlTop.Controls.Add(this.firstMenu4);
            this.PnlTop.Controls.Add(this.pictureBox1);
            this.PnlTop.Controls.Add(this.PicSmall);
            this.PnlTop.Controls.Add(this.firstMenu3);
            this.PnlTop.Controls.Add(this.firstMenu2);
            this.PnlTop.Controls.Add(this.firstMenu1);
            this.PnlTop.Controls.Add(this.PicClose);
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Margin = new System.Windows.Forms.Padding(6);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1870, 92);
            this.PnlTop.TabIndex = 83;
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.PnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            this.PnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseUp);
            // 
            // firstMenu6
            // 
            this.firstMenu6.ActiveColor = System.Drawing.SystemColors.WindowFrame;
            this.firstMenu6.BackColor = System.Drawing.Color.Transparent;
            this.firstMenu6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstMenu6.Caption = "अन्य";
            this.firstMenu6.DefaultColor = System.Drawing.Color.Transparent;
            this.firstMenu6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstMenu6.Location = new System.Drawing.Point(1360, 0);
            this.firstMenu6.Margin = new System.Windows.Forms.Padding(6);
            this.firstMenu6.Name = "firstMenu6";
            this.firstMenu6.Size = new System.Drawing.Size(220, 85);
            this.firstMenu6.TabIndex = 10;
            this.firstMenu6.TextFont = new System.Drawing.Font("Preeti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstMenu6.MouseSelected += new StandaloneSDKDemo.FirstMenu.MouseSelectedEventHandler(this.firstMenu6_MouseSelected);
            // 
            // firstMenu5
            // 
            this.firstMenu5.ActiveColor = System.Drawing.SystemColors.WindowFrame;
            this.firstMenu5.BackColor = System.Drawing.Color.Transparent;
            this.firstMenu5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstMenu5.Caption = "अनुमति";
            this.firstMenu5.DefaultColor = System.Drawing.Color.Transparent;
            this.firstMenu5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstMenu5.Location = new System.Drawing.Point(1140, 0);
            this.firstMenu5.Margin = new System.Windows.Forms.Padding(6);
            this.firstMenu5.Name = "firstMenu5";
            this.firstMenu5.Size = new System.Drawing.Size(220, 85);
            this.firstMenu5.TabIndex = 9;
            this.firstMenu5.TextFont = new System.Drawing.Font("Preeti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstMenu5.MouseSelected += new StandaloneSDKDemo.FirstMenu.MouseSelectedEventHandler(this.firstMenu5_MouseSelected);
            // 
            // firstMenu4
            // 
            this.firstMenu4.ActiveColor = System.Drawing.SystemColors.WindowFrame;
            this.firstMenu4.BackColor = System.Drawing.Color.Transparent;
            this.firstMenu4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstMenu4.Caption = "डाटा";
            this.firstMenu4.DefaultColor = System.Drawing.Color.Transparent;
            this.firstMenu4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstMenu4.Location = new System.Drawing.Point(920, 0);
            this.firstMenu4.Margin = new System.Windows.Forms.Padding(6);
            this.firstMenu4.Name = "firstMenu4";
            this.firstMenu4.Size = new System.Drawing.Size(220, 85);
            this.firstMenu4.TabIndex = 8;
            this.firstMenu4.TextFont = new System.Drawing.Font("Preeti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstMenu4.MouseSelected += new StandaloneSDKDemo.FirstMenu.MouseSelectedEventHandler(this.firstMenu4_MouseSelected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StandaloneSDKDemo.Properties.Resources.main_logo;
            this.pictureBox1.Location = new System.Drawing.Point(34, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicHome_MouseClick);
            // 
            // PicSmall
            // 
            this.PicSmall.Location = new System.Drawing.Point(0, 0);
            this.PicSmall.Name = "PicSmall";
            this.PicSmall.Size = new System.Drawing.Size(100, 50);
            this.PicSmall.TabIndex = 11;
            this.PicSmall.TabStop = false;
            // 
            // firstMenu3
            // 
            this.firstMenu3.ActiveColor = System.Drawing.SystemColors.WindowFrame;
            this.firstMenu3.BackColor = System.Drawing.Color.Transparent;
            this.firstMenu3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstMenu3.Caption = "सेटिङ";
            this.firstMenu3.DefaultColor = System.Drawing.Color.Transparent;
            this.firstMenu3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstMenu3.Location = new System.Drawing.Point(700, 0);
            this.firstMenu3.Margin = new System.Windows.Forms.Padding(6);
            this.firstMenu3.Name = "firstMenu3";
            this.firstMenu3.Size = new System.Drawing.Size(220, 85);
            this.firstMenu3.TabIndex = 5;
            this.firstMenu3.TextFont = new System.Drawing.Font("Preeti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstMenu3.MouseSelected += new StandaloneSDKDemo.FirstMenu.MouseSelectedEventHandler(this.firstMenu3_MouseSelected);
            // 
            // firstMenu2
            // 
            this.firstMenu2.ActiveColor = System.Drawing.SystemColors.WindowFrame;
            this.firstMenu2.BackColor = System.Drawing.Color.Transparent;
            this.firstMenu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstMenu2.Caption = "प्रयोगकर्ता";
            this.firstMenu2.DefaultColor = System.Drawing.Color.Transparent;
            this.firstMenu2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstMenu2.Location = new System.Drawing.Point(480, 0);
            this.firstMenu2.Margin = new System.Windows.Forms.Padding(6);
            this.firstMenu2.Name = "firstMenu2";
            this.firstMenu2.Size = new System.Drawing.Size(220, 85);
            this.firstMenu2.TabIndex = 4;
            this.firstMenu2.TextFont = new System.Drawing.Font("Preeti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstMenu2.MouseSelected += new StandaloneSDKDemo.FirstMenu.MouseSelectedEventHandler(this.firstMenu2_MouseSelected);
            // 
            // firstMenu1
            // 
            this.firstMenu1.ActiveColor = System.Drawing.SystemColors.WindowFrame;
            this.firstMenu1.BackColor = System.Drawing.Color.Transparent;
            this.firstMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstMenu1.Caption = "टर्मिनल";
            this.firstMenu1.DefaultColor = System.Drawing.Color.Transparent;
            this.firstMenu1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstMenu1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstMenu1.Location = new System.Drawing.Point(260, 0);
            this.firstMenu1.Margin = new System.Windows.Forms.Padding(6);
            this.firstMenu1.Name = "firstMenu1";
            this.firstMenu1.Size = new System.Drawing.Size(220, 85);
            this.firstMenu1.TabIndex = 3;
            this.firstMenu1.TextFont = new System.Drawing.Font("Preeti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstMenu1.MouseSelected += new StandaloneSDKDemo.FirstMenu.MouseSelectedEventHandler(this.firstMenu1_MouseSelected);
            // 
            // PicClose
            // 
            this.PicClose.Location = new System.Drawing.Point(0, 0);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(100, 50);
            this.PicClose.TabIndex = 12;
            this.PicClose.TabStop = false;
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PnlBottom.Controls.Add(this.label2);
            this.PnlBottom.Controls.Add(this.label1);
            this.PnlBottom.Controls.Add(this.lbRTOutputInfo);
            this.PnlBottom.Controls.Add(this.PrgSTA);
            this.PnlBottom.Controls.Add(this.label3);
            this.PnlBottom.Controls.Add(this.lbSysOutputInfo);
            this.PnlBottom.Controls.Add(this.lbVer);
            this.PnlBottom.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlBottom.Location = new System.Drawing.Point(0, 910);
            this.PnlBottom.Margin = new System.Windows.Forms.Padding(6);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(1868, 400);
            this.PnlBottom.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(894, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 29);
            this.label2.TabIndex = 85;
            this.label2.Text = "Device Real-Time Event:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 84;
            this.label1.Text = "Demo Event:";
            // 
            // lbRTOutputInfo
            // 
            this.lbRTOutputInfo.ContextMenuStrip = this.cmsDeviceRTEvent;
            this.lbRTOutputInfo.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRTOutputInfo.FormattingEnabled = true;
            this.lbRTOutputInfo.ItemHeight = 25;
            this.lbRTOutputInfo.Location = new System.Drawing.Point(894, 33);
            this.lbRTOutputInfo.Margin = new System.Windows.Forms.Padding(6);
            this.lbRTOutputInfo.Name = "lbRTOutputInfo";
            this.lbRTOutputInfo.Size = new System.Drawing.Size(964, 304);
            this.lbRTOutputInfo.TabIndex = 83;
            // 
            // cmsDeviceRTEvent
            // 
            this.cmsDeviceRTEvent.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDeviceRTEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearInfoMenuItem1});
            this.cmsDeviceRTEvent.Name = "contextMenuStripDevice";
            this.cmsDeviceRTEvent.Size = new System.Drawing.Size(145, 40);
            // 
            // ClearInfoMenuItem1
            // 
            this.ClearInfoMenuItem1.Name = "ClearInfoMenuItem1";
            this.ClearInfoMenuItem1.Size = new System.Drawing.Size(144, 36);
            this.ClearInfoMenuItem1.Text = "Clear";
            this.ClearInfoMenuItem1.Click += new System.EventHandler(this.ClearInfoMenuItem1_Click);
            // 
            // PrgSTA
            // 
            this.PrgSTA.Location = new System.Drawing.Point(2, 358);
            this.PrgSTA.Margin = new System.Windows.Forms.Padding(6);
            this.PrgSTA.Name = "PrgSTA";
            this.PrgSTA.Size = new System.Drawing.Size(564, 29);
            this.PrgSTA.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1146, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(703, 29);
            this.label3.TabIndex = 81;
            this.label3.Text = "Copyright © 2017 ZKTECO CO., LTD. All Rights Reserved.";
            // 
            // PnlMiddle
            // 
            this.PnlMiddle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlMiddle.Controls.Add(this.pnlPersonalize);
            this.PnlMiddle.Controls.Add(this.pnlUser);
            this.PnlMiddle.Controls.Add(this.pnlOther);
            this.PnlMiddle.Controls.Add(this.pnlAccess);
            this.PnlMiddle.Controls.Add(this.pnlData);
            this.PnlMiddle.Controls.Add(this.pnlTerminal);
            this.PnlMiddle.Controls.Add(this.labAD);
            this.PnlMiddle.Location = new System.Drawing.Point(0, 85);
            this.PnlMiddle.Margin = new System.Windows.Forms.Padding(6);
            this.PnlMiddle.Name = "PnlMiddle";
            this.PnlMiddle.Size = new System.Drawing.Size(1868, 812);
            this.PnlMiddle.TabIndex = 86;
            // 
            // pnlPersonalize
            // 
            this.pnlPersonalize.Location = new System.Drawing.Point(1714, 17);
            this.pnlPersonalize.Margin = new System.Windows.Forms.Padding(6);
            this.pnlPersonalize.Name = "pnlPersonalize";
            this.pnlPersonalize.Size = new System.Drawing.Size(32, 33);
            this.pnlPersonalize.TabIndex = 3;
            // 
            // pnlUser
            // 
            this.pnlUser.Location = new System.Drawing.Point(1684, 17);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(6);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(32, 33);
            this.pnlUser.TabIndex = 2;
            // 
            // pnlOther
            // 
            this.pnlOther.Location = new System.Drawing.Point(1802, 17);
            this.pnlOther.Margin = new System.Windows.Forms.Padding(6);
            this.pnlOther.Name = "pnlOther";
            this.pnlOther.Size = new System.Drawing.Size(32, 33);
            this.pnlOther.TabIndex = 6;
            // 
            // pnlAccess
            // 
            this.pnlAccess.Location = new System.Drawing.Point(1772, 17);
            this.pnlAccess.Margin = new System.Windows.Forms.Padding(6);
            this.pnlAccess.Name = "pnlAccess";
            this.pnlAccess.Size = new System.Drawing.Size(32, 33);
            this.pnlAccess.TabIndex = 5;
            // 
            // pnlData
            // 
            this.pnlData.Location = new System.Drawing.Point(1742, 17);
            this.pnlData.Margin = new System.Windows.Forms.Padding(6);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(32, 33);
            this.pnlData.TabIndex = 4;
            // 
            // pnlTerminal
            // 
            this.pnlTerminal.Location = new System.Drawing.Point(1654, 17);
            this.pnlTerminal.Margin = new System.Windows.Forms.Padding(6);
            this.pnlTerminal.Name = "pnlTerminal";
            this.pnlTerminal.Size = new System.Drawing.Size(32, 33);
            this.pnlTerminal.TabIndex = 1;
            // 
            // labAD
            // 
            this.labAD.AutoSize = true;
            this.labAD.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAD.Location = new System.Drawing.Point(170, 323);
            this.labAD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labAD.Name = "labAD";
            this.labAD.Size = new System.Drawing.Size(1553, 78);
            this.labAD.TabIndex = 0;
            this.labAD.Text = "Recommend For The New Generation Firmware";
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.propertyToolStripMenuItem.Text = "Property";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1868, 1317);
            this.Controls.Add(this.PnlMiddle);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
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
            this.PnlBottom.ResumeLayout(false);
            this.PnlBottom.PerformLayout();
            this.cmsDeviceRTEvent.ResumeLayout(false);
            this.PnlMiddle.ResumeLayout(false);
            this.PnlMiddle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel PnlMiddle;
        private System.Windows.Forms.PictureBox PicClose;
        private FirstMenu firstMenu1;
        private FirstMenu firstMenu3;
        private FirstMenu firstMenu2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PicSmall;
        private System.Windows.Forms.PictureBox pictureBox1;
        public  System.Windows.Forms.ListBox lbSysOutputInfo;
        public  System.Windows.Forms.ProgressBar PrgSTA;
        private FirstMenu firstMenu4;
        private System.Windows.Forms.Label labAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRTOutputInfo;
        private System.Windows.Forms.Label label2;
        private FirstMenu firstMenu5;
        private FirstMenu firstMenu6;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.Panel pnlAccess;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlPersonalize;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlTerminal;
        private System.Windows.Forms.ContextMenuStrip cmsDemoEvent;
        private System.Windows.Forms.ToolStripMenuItem ClearInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDeviceRTEvent;
        private System.Windows.Forms.ToolStripMenuItem ClearInfoMenuItem1;
    }
}

