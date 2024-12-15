using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using System.Data.SQLite;
using System.Threading;
using System.Management;
using System.IO;
using System.Data.SQLite;

namespace StandaloneSDKDemo
{
    public partial class TerminalForm : UserControl
    {
        public TerminalForm(Main Parent)
        {
            InitializeComponent();
            Terminal = Parent;
            MonthlyReport = Parent;
        }
        private Main MonthlyReport;
        DataTable test;
        private Main Terminal;
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private static int iMachineNumber = 1;
        


        #region ConnetDevice
        /********************************************************************************************************************************************
        * Before you refer to this demo,we strongly suggest you read the development manual deeply first.                                           *
        * This part is for demonstrating the communication with your device.There are 3 communication ways: "TCP/IP","Serial Port" and "USB Client".*
        * The communication way which you can use during to the model of the device.                                                                 *
        * *******************************************************************************************************************************************/

        //If your device supports the TCP/IP communications, you can refer to this.
        //when you are using the TCP/IP communication,you can distinguish different devices by their IP address.

        private void getDeviceInfo()
        {
            string sFirmver = "";
            string sMac = "";
            string sPlatform = "";
            string sSN = "";
            string sProductTime = "";
            string sDeviceName = "";
            int iFPAlg = 0;
            int iFaceAlg = 0;
            string sProducter = "";

            Terminal.SDK.sta_GetDeviceInfo(Terminal.lbSysOutputInfo, out sFirmver, out sMac, out sPlatform, out sSN, out sProductTime, out sDeviceName, out iFPAlg, out iFaceAlg, out sProducter);
            txtFirmwareVer.Text = sFirmver;
            txtMac.Text = sMac;
            txtSerialNumber.Text = sSN;
            txtPlatForm.Text = sPlatform;
            txtDeviceName.Text = sDeviceName;
            txtFPAlg.Text = iFPAlg.ToString().Trim();
            txtFaceAlg.Text = iFaceAlg.ToString().Trim();
            txtManufacturer.Text = sProducter;
            txtManufactureTime.Text = sProductTime;
        }

        private void getCapacityInfo()
        {
            int adminCnt = 0;
            int userCount = 0;
            int fpCnt = 0;
            int recordCnt = 0;
            int pwdCnt = 0;
            int oplogCnt = 0;
            int faceCnt = 0;
            Terminal.SDK.sta_GetCapacityInfo(Terminal.lbSysOutputInfo, out adminCnt, out userCount, out fpCnt, out recordCnt, out pwdCnt, out oplogCnt, out faceCnt);

            txtAdminCnt.Text = adminCnt.ToString();
            txtUserCnt.Text = userCount.ToString();
            txtFPCnt.Text = fpCnt.ToString();
            txtAttLogCnt.Text = recordCnt.ToString();
            txtPWDCnt.Text = pwdCnt.ToString();
            txtOpLogCnt.Text = oplogCnt.ToString();
            txtFaceCnt.Text = faceCnt.ToString();
        }

        private void btnTCPConnect_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int ret = Terminal.SDK.sta_ConnectTCP(Terminal.lbSysOutputInfo, txtIP.Text.Trim(), txtPort.Text.Trim(), txtCommKey1.Text.Trim());

            if (Terminal.SDK.GetConnectState())
            {
                Terminal.SDK.sta_getBiometricType();
            }
            if (ret == 1)
            {
                this.txtIP.ReadOnly = true;
                this.txtPort.ReadOnly = true;
                this.txtCommKey1.ReadOnly = true;

                this.btnRSConnect.Enabled = false;
                this.btnUSBConnect.Enabled = false;

                this.btnGetSystemInfo.Enabled = true;
                this.btnGetDataInfo.Enabled = true;

                getCapacityInfo();
                getDeviceInfo();

                btnTCPConnect.Text = "DisConnect";
                btnTCPConnect.Refresh();

            }
            else if (ret == -2)
            {
                btnTCPConnect.Text = "Connect";
                btnTCPConnect.Refresh();
                this.txtDeviceID1.ReadOnly = false;
                this.txtIP.ReadOnly = false;
                this.txtPort.ReadOnly = false;
                this.txtCommKey1.ReadOnly = false;

                this.btnRSConnect.Enabled = true;
                this.btnUSBConnect.Enabled = true;

                this.btnGetSystemInfo.Enabled = false;
                this.btnGetDataInfo.Enabled = false;
            }
            Cursor = Cursors.Default;
        }

        private void btnRSConnect_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int ret = Terminal.SDK.sta_ConnectRS(Terminal.lbSysOutputInfo, txtDeviceID1.Text.Trim(), cbSerialPort.Text.Trim(), cbBaudRate.Text.Trim(), txtCommKey2.Text.Trim());
            if (ret == 1)
            {
                this.txtDeviceID1.ReadOnly = true;
                this.txtCommKey2.ReadOnly = true;
                this.cbSerialPort.Enabled = false;
                this.cbBaudRate.Enabled = false;

                this.btnTCPConnect.Enabled = false;
                this.btnUSBConnect.Enabled = false;

                this.btnGetSystemInfo.Enabled = true;
                this.btnGetDataInfo.Enabled = true;

                getCapacityInfo();
                getDeviceInfo();

                btnRSConnect.Text = "DisConnect";
                btnRSConnect.Refresh();
            }
            else if (ret == -2)
            {
                btnRSConnect.Text = "Connect";
                btnRSConnect.Refresh();
                this.txtDeviceID1.ReadOnly = false;
                this.txtCommKey2.ReadOnly = false;
                this.cbSerialPort.Enabled = true;
                this.cbBaudRate.Enabled = true;

                this.btnTCPConnect.Enabled = true;
                this.btnUSBConnect.Enabled = true;

                this.btnGetSystemInfo.Enabled = false;
                this.btnGetDataInfo.Enabled = false;
            }
            Cursor = Cursors.Default;
        }

        private void btnUSBConnect_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int ret = Terminal.SDK.sta_ConnectUSB(Terminal.lbSysOutputInfo, txtDeviceID2.Text.Trim(), txtCommKey3.Text.Trim());
            if (ret == 1)
            {
                this.txtDeviceID2.ReadOnly = true;
                this.txtCommKey3.ReadOnly = true;

                this.btnTCPConnect.Enabled = false;
                this.btnRSConnect.Enabled = false;

                this.btnGetSystemInfo.Enabled = true;
                this.btnGetDataInfo.Enabled = true;

                getCapacityInfo();
                getDeviceInfo();

                btnUSBConnect.Text = "DisConnect";
                btnUSBConnect.Refresh();
            }
            else if (ret == -2)
            {
                btnUSBConnect.Text = "Connect";
                btnUSBConnect.Refresh();
                this.txtDeviceID2.ReadOnly = false;
                this.txtCommKey3.ReadOnly = false;

                this.btnTCPConnect.Enabled = true;
                this.btnRSConnect.Enabled = true;

                this.btnGetSystemInfo.Enabled = false;
                this.btnGetDataInfo.Enabled = false;
            }
            Cursor = Cursors.Default;
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCommKey1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDeviceID1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCommKey2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDeviceID2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCommKey3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        private void btnGetSystemInfo_Click(object sender, EventArgs e)
        {
            getDeviceInfo();
        }

        private void btnGetDataInfo_Click(object sender, EventArgs e)
        {
            getCapacityInfo();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public int GetMachineNumber()
        {
            return iMachineNumber;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            DataTable dt_periodLog = new DataTable("dt_periodLog");

            dt_periodLog.Columns.Add("Organization_ID", System.Type.GetType("System.Int32"));
            dt_periodLog.Columns.Add("User ID", System.Type.GetType("System.String"));
            dt_periodLog.Columns.Add("User Name", System.Type.GetType("System.String"));

            dt_periodLog.Columns.Add("Verify Date", System.Type.GetType("System.String"));
            dt_periodLog.Columns.Add("Verify Type", System.Type.GetType("System.Int32"));
            dt_periodLog.Columns.Add("Verify State", System.Type.GetType("System.Int32"));
            dt_periodLog.Columns.Add("WorkCode", System.Type.GetType("System.Int32"));
            dt_periodLog.Columns.Add("Time In", System.Type.GetType("System.String"));
            dt_periodLog.Columns.Add("Time Out", System.Type.GetType("System.String"));
            dt_periodLog.Columns.Add("Status", System.Type.GetType("System.String"));


            MonthlyReport.SDK.sta_readAttLog(MonthlyReport.lbSysOutputInfo, dt_periodLog);

            SaveAttendanceToDB(dt_periodLog);

            Cursor = Cursors.Default;


        }


        public void SaveAttendanceToDB(DataTable dt_periodLog)
        {
            string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Office.db");
            string connectionString = $"Data Source={dbFilePath};";
            int organization_id = 0;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Organization_ID FROM Organization LIMIT 1"; // SQLite uses LIMIT instead of TOP

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        organization_id = Convert.ToInt32(result);
                    }
                }
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                foreach (DataRow row in dt_periodLog.Rows)
                {
                    using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Attendance (organization_id,employee_id,checkin_time,checkout_time,verify_date,Posted_Date_Time) VALUES (@organization_id,@employee_id,@checkin_time,@checkout_time,@verify_date,@Posted_Date_Time)", connection))
                    {
                        command.Parameters.AddWithValue("@organization_id", organization_id);
                        if (row["User ID"] != null && int.TryParse(row["User ID"].ToString(), out int employeeId))
                        {
                            command.Parameters.AddWithValue("@employee_id", employeeId);
                        }

                        command.Parameters.AddWithValue("@verify_date", row["Verify Date"].ToString());
                        command.Parameters.AddWithValue("@checkin_time", row["Time In"].ToString());
                        command.Parameters.AddWithValue("@checkout_time", row["Time Out"].ToString());
                        command.Parameters.AddWithValue("@Posted_Date_Time", DateTime.Now.ToString());

                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}











        //int machineNumber = 1; // Replace with your device's machine number
        //string enrollNumber;
        //int verifyMode, inOutMode, year, month, day, hour, minute, second, workCode = 0, mask, helmetHat;
        //string temperature;


//try
//{
//    // Loop through attendance logs
//    while (axCZKEM1.SSR_GetGeneralLogData(
//        machineNumber,
//        out enrollNumber,
//        out verifyMode,
//        out inOutMode,
//        out year,
//        out month,
//        out day,
//        out hour,
//        out minute,
//        out second,
//        ref workCode,
//        out mask,
//        out temperature
//        ))
//    {
//        // Combine date and time components into a DateTime object




