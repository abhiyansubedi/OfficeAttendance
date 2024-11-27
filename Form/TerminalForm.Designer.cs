using System.Windows.Forms;

namespace StandaloneSDKDemo
{
    partial class TerminalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminalForm));
            this.TabTerminal = new System.Windows.Forms.TabControl();
            this.pDeviceInfo = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGetSystemInfo = new System.Windows.Forms.Button();
            this.txtFaceAlg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlatForm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFPAlg = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFirmwareVer = new System.Windows.Forms.TextBox();
            this.txtManufactureTime = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGetDataInfo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFaceCnt = new System.Windows.Forms.TextBox();
            this.txtAdminCnt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtUserCnt = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPWDCnt = new System.Windows.Forms.TextBox();
            this.txtOpLogCnt = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtAttLogCnt = new System.Windows.Forms.TextBox();
            this.txtFPCnt = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtCommKey1 = new System.Windows.Forms.TextBox();
            this.btnTCPConnect = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.labPort = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.labIP = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtCommKey2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRSConnect = new System.Windows.Forms.Button();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labSerialPort = new System.Windows.Forms.Label();
            this.txtDeviceID1 = new System.Windows.Forms.TextBox();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.labRate = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.rbVUSB = new System.Windows.Forms.RadioButton();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.btnUSBConnect = new System.Windows.Forms.Button();
            this.txtCommKey3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeviceID2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ImgTab = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabTerminal.SuspendLayout();
            this.pDeviceInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // TabTerminal
            // 
            this.TabTerminal.Controls.Add(this.pDeviceInfo);
            this.TabTerminal.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabTerminal.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTerminal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TabTerminal.Location = new System.Drawing.Point(0, 0);
            this.TabTerminal.Name = "TabTerminal";
            this.TabTerminal.SelectedIndex = 0;
            this.TabTerminal.Size = new System.Drawing.Size(1429, 1020);
            this.TabTerminal.TabIndex = 81;
            // 
            // pDeviceInfo
            // 
            this.pDeviceInfo.Controls.Add(this.groupBox2);
            this.pDeviceInfo.ImageIndex = 1;
            this.pDeviceInfo.Location = new System.Drawing.Point(4, 33);
            this.pDeviceInfo.Name = "pDeviceInfo";
            this.pDeviceInfo.Size = new System.Drawing.Size(1421, 983);
            this.pDeviceInfo.TabIndex = 0;
            this.pDeviceInfo.Text = "DeviceInfo";
            this.pDeviceInfo.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 211);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1402, 627);
            this.tabControl1.TabIndex = 84;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGetSystemInfo);
            this.tabPage1.Controls.Add(this.txtFaceAlg);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPlatForm);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMac);
            this.tabPage1.Controls.Add(this.txtDeviceName);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSerialNumber);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.txtFPAlg);
            this.tabPage1.Controls.Add(this.txtManufacturer);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txtFirmwareVer);
            this.tabPage1.Controls.Add(this.txtManufactureTime);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1394, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Device Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnGetSystemInfo
            // 
            this.btnGetSystemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.btnGetSystemInfo.Enabled = false;
            this.btnGetSystemInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetSystemInfo.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSystemInfo.ForeColor = System.Drawing.Color.White;
            this.btnGetSystemInfo.Location = new System.Drawing.Point(975, 167);
            this.btnGetSystemInfo.Name = "btnGetSystemInfo";
            this.btnGetSystemInfo.Size = new System.Drawing.Size(183, 35);
            this.btnGetSystemInfo.TabIndex = 18;
            this.btnGetSystemInfo.Text = "GetDeviceInfo";
            this.btnGetSystemInfo.UseVisualStyleBackColor = false;
            this.btnGetSystemInfo.Click += new System.EventHandler(this.btnGetSystemInfo_Click);
            // 
            // txtFaceAlg
            // 
            this.txtFaceAlg.BackColor = System.Drawing.Color.White;
            this.txtFaceAlg.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaceAlg.Location = new System.Drawing.Point(975, 61);
            this.txtFaceAlg.Name = "txtFaceAlg";
            this.txtFaceAlg.Size = new System.Drawing.Size(218, 29);
            this.txtFaceAlg.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(804, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Face Algorithm";
            // 
            // txtPlatForm
            // 
            this.txtPlatForm.BackColor = System.Drawing.Color.White;
            this.txtPlatForm.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.txtPlatForm.Location = new System.Drawing.Point(533, 20);
            this.txtPlatForm.Name = "txtPlatForm";
            this.txtPlatForm.Size = new System.Drawing.Size(217, 24);
            this.txtPlatForm.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Name";
            // 
            // txtMac
            // 
            this.txtMac.BackColor = System.Drawing.Color.White;
            this.txtMac.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMac.Location = new System.Drawing.Point(533, 55);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(217, 29);
            this.txtMac.TabIndex = 15;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.BackColor = System.Drawing.Color.White;
            this.txtDeviceName.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceName.Location = new System.Drawing.Point(171, 23);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(190, 29);
            this.txtDeviceName.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(445, 58);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 23);
            this.label21.TabIndex = 14;
            this.label21.Text = "MAC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plat Form";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.Color.White;
            this.txtSerialNumber.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.Location = new System.Drawing.Point(171, 99);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(190, 29);
            this.txtSerialNumber.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "FP Algorithm";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(28, 99);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 23);
            this.label20.TabIndex = 12;
            this.label20.Text = "SerialNumber";
            // 
            // txtFPAlg
            // 
            this.txtFPAlg.BackColor = System.Drawing.Color.White;
            this.txtFPAlg.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFPAlg.Location = new System.Drawing.Point(975, 23);
            this.txtFPAlg.Name = "txtFPAlg";
            this.txtFPAlg.Size = new System.Drawing.Size(218, 29);
            this.txtFPAlg.TabIndex = 5;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.BackColor = System.Drawing.Color.White;
            this.txtManufacturer.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturer.Location = new System.Drawing.Point(533, 96);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(217, 29);
            this.txtManufacturer.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "Firmware Version";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(405, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 23);
            this.label19.TabIndex = 10;
            this.label19.Text = "Manufacturer";
            // 
            // txtFirmwareVer
            // 
            this.txtFirmwareVer.BackColor = System.Drawing.Color.White;
            this.txtFirmwareVer.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirmwareVer.Location = new System.Drawing.Point(171, 61);
            this.txtFirmwareVer.Name = "txtFirmwareVer";
            this.txtFirmwareVer.Size = new System.Drawing.Size(190, 29);
            this.txtFirmwareVer.TabIndex = 7;
            // 
            // txtManufactureTime
            // 
            this.txtManufactureTime.BackColor = System.Drawing.Color.White;
            this.txtManufactureTime.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufactureTime.Location = new System.Drawing.Point(975, 99);
            this.txtManufactureTime.Name = "txtManufactureTime";
            this.txtManufactureTime.Size = new System.Drawing.Size(218, 29);
            this.txtManufactureTime.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(788, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "Manufacture Time";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGetDataInfo);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtFaceCnt);
            this.tabPage2.Controls.Add(this.txtAdminCnt);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.txtUserCnt);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.txtPWDCnt);
            this.tabPage2.Controls.Add(this.txtOpLogCnt);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.txtAttLogCnt);
            this.tabPage2.Controls.Add(this.txtFPCnt);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1394, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Device Capacity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGetDataInfo
            // 
            this.btnGetDataInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.btnGetDataInfo.Enabled = false;
            this.btnGetDataInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDataInfo.ForeColor = System.Drawing.Color.White;
            this.btnGetDataInfo.Location = new System.Drawing.Point(953, 151);
            this.btnGetDataInfo.Name = "btnGetDataInfo";
            this.btnGetDataInfo.Size = new System.Drawing.Size(192, 37);
            this.btnGetDataInfo.TabIndex = 26;
            this.btnGetDataInfo.Text = "GetDeviceCapacity";
            this.btnGetDataInfo.UseVisualStyleBackColor = false;
            this.btnGetDataInfo.Click += new System.EventHandler(this.btnGetDataInfo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Face Count";
            // 
            // txtFaceCnt
            // 
            this.txtFaceCnt.BackColor = System.Drawing.Color.White;
            this.txtFaceCnt.Location = new System.Drawing.Point(188, 108);
            this.txtFaceCnt.Name = "txtFaceCnt";
            this.txtFaceCnt.Size = new System.Drawing.Size(201, 32);
            this.txtFaceCnt.TabIndex = 24;
            // 
            // txtAdminCnt
            // 
            this.txtAdminCnt.BackColor = System.Drawing.Color.White;
            this.txtAdminCnt.Location = new System.Drawing.Point(597, 26);
            this.txtAdminCnt.Name = "txtAdminCnt";
            this.txtAdminCnt.Size = new System.Drawing.Size(202, 32);
            this.txtAdminCnt.TabIndex = 15;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(48, 31);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(105, 24);
            this.label24.TabIndex = 12;
            this.label24.Text = "User Count";
            // 
            // txtUserCnt
            // 
            this.txtUserCnt.BackColor = System.Drawing.Color.White;
            this.txtUserCnt.Location = new System.Drawing.Point(188, 31);
            this.txtUserCnt.Name = "txtUserCnt";
            this.txtUserCnt.Size = new System.Drawing.Size(201, 32);
            this.txtUserCnt.TabIndex = 13;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(458, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(123, 24);
            this.label25.TabIndex = 14;
            this.label25.Text = "Admin Count";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(925, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(104, 24);
            this.label26.TabIndex = 16;
            this.label26.Text = "Pwd Count";
            // 
            // txtPWDCnt
            // 
            this.txtPWDCnt.BackColor = System.Drawing.Color.White;
            this.txtPWDCnt.Location = new System.Drawing.Point(1076, 21);
            this.txtPWDCnt.Name = "txtPWDCnt";
            this.txtPWDCnt.Size = new System.Drawing.Size(190, 32);
            this.txtPWDCnt.TabIndex = 17;
            // 
            // txtOpLogCnt
            // 
            this.txtOpLogCnt.BackColor = System.Drawing.Color.White;
            this.txtOpLogCnt.Location = new System.Drawing.Point(1076, 62);
            this.txtOpLogCnt.Name = "txtOpLogCnt";
            this.txtOpLogCnt.Size = new System.Drawing.Size(190, 32);
            this.txtOpLogCnt.TabIndex = 23;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(39, 73);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(128, 24);
            this.label27.TabIndex = 18;
            this.label27.Text = "AttLog Count";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(918, 70);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(119, 24);
            this.label28.TabIndex = 22;
            this.label28.Text = "Oplog Count";
            // 
            // txtAttLogCnt
            // 
            this.txtAttLogCnt.BackColor = System.Drawing.Color.White;
            this.txtAttLogCnt.Location = new System.Drawing.Point(188, 70);
            this.txtAttLogCnt.Name = "txtAttLogCnt";
            this.txtAttLogCnt.Size = new System.Drawing.Size(201, 32);
            this.txtAttLogCnt.TabIndex = 19;
            // 
            // txtFPCnt
            // 
            this.txtFPCnt.BackColor = System.Drawing.Color.White;
            this.txtFPCnt.Location = new System.Drawing.Point(597, 64);
            this.txtFPCnt.Name = "txtFPCnt";
            this.txtFPCnt.Size = new System.Drawing.Size(202, 32);
            this.txtFPCnt.TabIndex = 21;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(474, 67);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(88, 24);
            this.label29.TabIndex = 20;
            this.label29.Text = "FP Count";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Location = new System.Drawing.Point(1, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1375, 827);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication with Device";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(11, 31);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1305, 181);
            this.tabControl2.TabIndex = 21;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtCommKey1);
            this.tabPage5.Controls.Add(this.btnTCPConnect);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.txtPort);
            this.tabPage5.Controls.Add(this.labPort);
            this.tabPage5.Controls.Add(this.txtIP);
            this.tabPage5.Controls.Add(this.labIP);
            this.tabPage5.ForeColor = System.Drawing.Color.White;
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1297, 146);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "TCP/IP";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtCommKey1
            // 
            this.txtCommKey1.BackColor = System.Drawing.Color.White;
            this.txtCommKey1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommKey1.Location = new System.Drawing.Point(662, 25);
            this.txtCommKey1.MaxLength = 6;
            this.txtCommKey1.Name = "txtCommKey1";
            this.txtCommKey1.Size = new System.Drawing.Size(93, 32);
            this.txtCommKey1.TabIndex = 17;
            this.txtCommKey1.Text = "0";
            this.txtCommKey1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommKey1_KeyPress);
            // 
            // btnTCPConnect
            // 
            this.btnTCPConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.btnTCPConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTCPConnect.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTCPConnect.Location = new System.Drawing.Point(432, 93);
            this.btnTCPConnect.Name = "btnTCPConnect";
            this.btnTCPConnect.Size = new System.Drawing.Size(119, 38);
            this.btnTCPConnect.TabIndex = 0;
            this.btnTCPConnect.Text = "Connect";
            this.btnTCPConnect.UseVisualStyleBackColor = false;
            this.btnTCPConnect.Click += new System.EventHandler(this.btnTCPConnect_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(556, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 24);
            this.label15.TabIndex = 16;
            this.label15.Text = "CommKey";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.White;
            this.txtPort.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txtPort.Location = new System.Drawing.Point(402, 25);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(93, 32);
            this.txtPort.TabIndex = 13;
            this.txtPort.Text = "4370";
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPort.Location = new System.Drawing.Point(351, 28);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(47, 24);
            this.labPort.TabIndex = 15;
            this.labPort.Text = "Port";
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.White;
            this.txtIP.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(132, 25);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(136, 32);
            this.txtIP.TabIndex = 12;
            this.txtIP.Text = "192.168.1.201";
            // 
            // labIP
            // 
            this.labIP.AutoSize = true;
            this.labIP.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIP.Location = new System.Drawing.Point(88, 28);
            this.labIP.Name = "labIP";
            this.labIP.Size = new System.Drawing.Size(28, 24);
            this.labIP.TabIndex = 14;
            this.labIP.Text = "IP";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txtCommKey2);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.btnRSConnect);
            this.tabPage6.Controls.Add(this.cbBaudRate);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.labSerialPort);
            this.tabPage6.Controls.Add(this.txtDeviceID1);
            this.tabPage6.Controls.Add(this.cbSerialPort);
            this.tabPage6.Controls.Add(this.labRate);
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1297, 146);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "RS232/RS485";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtCommKey2
            // 
            this.txtCommKey2.BackColor = System.Drawing.Color.White;
            this.txtCommKey2.Location = new System.Drawing.Point(1068, 28);
            this.txtCommKey2.MaxLength = 6;
            this.txtCommKey2.Name = "txtCommKey2";
            this.txtCommKey2.Size = new System.Drawing.Size(133, 29);
            this.txtCommKey2.TabIndex = 23;
            this.txtCommKey2.Text = "0";
            this.txtCommKey2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommKey2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(951, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "CommKey";
            // 
            // btnRSConnect
            // 
            this.btnRSConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.btnRSConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSConnect.ForeColor = System.Drawing.Color.White;
            this.btnRSConnect.Location = new System.Drawing.Point(413, 93);
            this.btnRSConnect.Name = "btnRSConnect";
            this.btnRSConnect.Size = new System.Drawing.Size(125, 36);
            this.btnRSConnect.TabIndex = 21;
            this.btnRSConnect.Text = "Connect";
            this.btnRSConnect.UseVisualStyleBackColor = false;
            this.btnRSConnect.Click += new System.EventHandler(this.btnRSConnect_Click);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.BackColor = System.Drawing.Color.White;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(739, 28);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(126, 30);
            this.cbBaudRate.TabIndex = 6;
            this.cbBaudRate.Text = "115200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Device ID";
            // 
            // labSerialPort
            // 
            this.labSerialPort.AutoSize = true;
            this.labSerialPort.Location = new System.Drawing.Point(303, 34);
            this.labSerialPort.Name = "labSerialPort";
            this.labSerialPort.Size = new System.Drawing.Size(97, 23);
            this.labSerialPort.TabIndex = 7;
            this.labSerialPort.Text = "Serial Port";
            // 
            // txtDeviceID1
            // 
            this.txtDeviceID1.BackColor = System.Drawing.Color.White;
            this.txtDeviceID1.Location = new System.Drawing.Point(142, 29);
            this.txtDeviceID1.MaxLength = 3;
            this.txtDeviceID1.Name = "txtDeviceID1";
            this.txtDeviceID1.Size = new System.Drawing.Size(94, 29);
            this.txtDeviceID1.TabIndex = 19;
            this.txtDeviceID1.Text = "1";
            this.txtDeviceID1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeviceID1_KeyPress);
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.BackColor = System.Drawing.Color.White;
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbSerialPort.Location = new System.Drawing.Point(421, 28);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(142, 30);
            this.cbSerialPort.TabIndex = 5;
            this.cbSerialPort.Text = "COM1";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Location = new System.Drawing.Point(632, 31);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(92, 23);
            this.labRate.TabIndex = 8;
            this.labRate.Text = "BaudRate";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.rbVUSB);
            this.tabPage7.Controls.Add(this.rbUSB);
            this.tabPage7.Controls.Add(this.btnUSBConnect);
            this.tabPage7.Controls.Add(this.txtCommKey3);
            this.tabPage7.Controls.Add(this.label8);
            this.tabPage7.Controls.Add(this.txtDeviceID2);
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Location = new System.Drawing.Point(4, 31);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1297, 146);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "USB";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // rbVUSB
            // 
            this.rbVUSB.AutoSize = true;
            this.rbVUSB.Checked = true;
            this.rbVUSB.Location = new System.Drawing.Point(22, 25);
            this.rbVUSB.Name = "rbVUSB";
            this.rbVUSB.Size = new System.Drawing.Size(175, 27);
            this.rbVUSB.TabIndex = 3;
            this.rbVUSB.TabStop = true;
            this.rbVUSB.Text = "Virtual USBClient";
            this.rbVUSB.UseVisualStyleBackColor = true;
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.Location = new System.Drawing.Point(22, 58);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(116, 27);
            this.rbUSB.TabIndex = 21;
            this.rbUSB.Text = "USBClient";
            this.rbUSB.UseVisualStyleBackColor = true;
            // 
            // btnUSBConnect
            // 
            this.btnUSBConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.btnUSBConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSBConnect.ForeColor = System.Drawing.Color.White;
            this.btnUSBConnect.Location = new System.Drawing.Point(403, 95);
            this.btnUSBConnect.Name = "btnUSBConnect";
            this.btnUSBConnect.Size = new System.Drawing.Size(127, 35);
            this.btnUSBConnect.TabIndex = 4;
            this.btnUSBConnect.Text = "Connect";
            this.btnUSBConnect.UseVisualStyleBackColor = false;
            this.btnUSBConnect.Click += new System.EventHandler(this.btnUSBConnect_Click);
            // 
            // txtCommKey3
            // 
            this.txtCommKey3.BackColor = System.Drawing.Color.White;
            this.txtCommKey3.Location = new System.Drawing.Point(723, 31);
            this.txtCommKey3.MaxLength = 6;
            this.txtCommKey3.Name = "txtCommKey3";
            this.txtCommKey3.Size = new System.Drawing.Size(150, 29);
            this.txtCommKey3.TabIndex = 3;
            this.txtCommKey3.Text = "0";
            this.txtCommKey3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommKey3_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(607, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "CommKey";
            // 
            // txtDeviceID2
            // 
            this.txtDeviceID2.BackColor = System.Drawing.Color.White;
            this.txtDeviceID2.Location = new System.Drawing.Point(430, 31);
            this.txtDeviceID2.MaxLength = 3;
            this.txtDeviceID2.Name = "txtDeviceID2";
            this.txtDeviceID2.Size = new System.Drawing.Size(100, 29);
            this.txtDeviceID2.TabIndex = 1;
            this.txtDeviceID2.Text = "1";
            this.txtDeviceID2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeviceID2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Device ID";
            // 
            // ImgTab
            // 
            this.ImgTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgTab.ImageStream")));
            this.ImgTab.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgTab.Images.SetKeyName(0, "download.png");
            this.ImgTab.Images.SetKeyName(1, "repeat.png");
            this.ImgTab.Images.SetKeyName(2, "vision.png");
            this.ImgTab.Images.SetKeyName(3, "document.png");
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(758, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 66;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(758, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 65;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(466, 127);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(34, 13);
            this.label31.TabIndex = 63;
            this.label31.Text = "Value";
            // 
            // dataGridView5
            // 
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView5.Location = new System.Drawing.Point(26, 7);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(234, 320);
            this.dataGridView5.TabIndex = 57;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.HeaderText = "";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Width = 30;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Value";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(544, 124);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 22);
            this.textBox22.TabIndex = 64;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(544, 61);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 22);
            this.textBox23.TabIndex = 62;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(466, 64);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 13);
            this.label32.TabIndex = 61;
            this.label32.Text = "Name";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Location = new System.Drawing.Point(38, 18);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(318, 369);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(310, 340);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "NMS Param";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView6);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(310, 340);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Main Param";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView6.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView6.Location = new System.Drawing.Point(38, 11);
            this.dataGridView6.MultiSelect = false;
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersVisible = false;
            this.dataGridView6.RowTemplate.Height = 23;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(234, 320);
            this.dataGridView6.TabIndex = 58;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.HeaderText = "";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.Width = 30;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Value";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // TerminalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.TabTerminal);
            this.DoubleBuffered = true;
            this.Name = "TerminalForm";
            this.Size = new System.Drawing.Size(1429, 863);
            this.TabTerminal.ResumeLayout(false);
            this.pDeviceInfo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabTerminal;
        private System.Windows.Forms.TabPage pDeviceInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtPlatForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFPAlg;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtFirmwareVer;
        private System.Windows.Forms.TextBox txtManufactureTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAdminCnt;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtUserCnt;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtPWDCnt;
        private System.Windows.Forms.TextBox txtOpLogCnt;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtAttLogCnt;
        private System.Windows.Forms.TextBox txtFPCnt;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCommKey1;
        private System.Windows.Forms.Button btnTCPConnect;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labIP;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.Label labSerialPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ImageList ImgTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeviceID1;
        private System.Windows.Forms.TextBox txtFaceAlg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeviceID2;
        private System.Windows.Forms.Button btnRSConnect;
        private System.Windows.Forms.TextBox txtCommKey2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCommKey3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUSBConnect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFaceCnt;
        private System.Windows.Forms.Button btnGetSystemInfo;
        private System.Windows.Forms.Button btnGetDataInfo;
        private System.Windows.Forms.RadioButton rbUSB;
        private System.Windows.Forms.RadioButton rbVUSB;
    }
}