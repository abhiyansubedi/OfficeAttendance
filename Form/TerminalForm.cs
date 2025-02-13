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
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using StandaloneSDKDemo.Helper;

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

            // Pre-defined local IP
            string ipAddress = "192.168.1.201";

            // Attempt to connect via TCP
            int ret = Terminal.SDK.sta_ConnectTCP(Terminal.lbSysOutputInfo, ipAddress, txtPort.Text.Trim(), txtCommKey1.Text.Trim());

            if (ret == 1) // Connection successful
            {
                txtIP.ReadOnly = true;
                txtPort.ReadOnly = true;
                txtCommKey1.ReadOnly = true;

                btnRSConnect.Enabled = false;
                btnUSBConnect.Enabled = false;

                btnGetSystemInfo.Enabled = true;
                btnGetDataInfo.Enabled = true;

                getCapacityInfo();
                getDeviceInfo();

                btnTCPConnect.Text = "Disconnect";
                btnTCPConnect.Refresh();
            }
            else if (ret == -2) // Connection failed
            {
                MessageBox.Show("Failed to connect to the device. Please check the port or device configuration.",
                                "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnTCPConnect.Text = "Connect";
                btnTCPConnect.Refresh();

                txtDeviceID1.ReadOnly = false;
                txtIP.ReadOnly = false;
                txtPort.ReadOnly = false;
                txtCommKey1.ReadOnly = false;

                btnRSConnect.Enabled = true;
                btnUSBConnect.Enabled = true;

                btnGetSystemInfo.Enabled = false;
                btnGetDataInfo.Enabled = false;
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
            dt_periodLog.Columns.Add("Nepali Verify Date", System.Type.GetType("System.String"));
            dt_periodLog.Columns.Add("Verify Type", System.Type.GetType("System.Int32"));
            dt_periodLog.Columns.Add("Verify State", System.Type.GetType("System.Int32"));
            dt_periodLog.Columns.Add("WorkCode", System.Type.GetType("System.Int32"));
            dt_periodLog.Columns.Add("Time In", System.Type.GetType("System.String"));
            dt_periodLog.Columns.Add("Time Out", System.Type.GetType("System.String"));
            dt_periodLog.Columns.Add("Status", System.Type.GetType("System.String"));


            MonthlyReport.SDK.sta_readAttLog(MonthlyReport.lbSysOutputInfo, dt_periodLog);

           
            SaveAttendanceToDB(dt_periodLog);
            PostAttendance();


            Cursor = Cursors.Default;


        }


        public void SaveAttendanceToDB(DataTable dt_periodLog)
        {
            string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Office.db");
            string connectionString = $"Data Source={dbFilePath};";
            int organization_id = 0;

            // Retrieve Organization ID
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

            // Process attendance records
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                foreach (DataRow row in dt_periodLog.Rows)
                {
                    // Ensure "Time In" is not null and can be parsed into a DateTime
                    if (row["Time In"] != DBNull.Value && DateTime.TryParse(row["Time In"].ToString(), out DateTime timeIn))
                    {
                        DateTime? maxPostedDateTime = null;

                        // Fetch max Local_Date_Time (stored as TEXT in the "yyyy-MM-dd HH:mm:ss" format)
                        using (SQLiteCommand command = new SQLiteCommand(
                            "SELECT MAX(checkin_time) FROM Attendance WHERE Posted_Date_Time IS NOT NULL", connection))
                        {
                            object result = command.ExecuteScalar();
                            if (result != DBNull.Value && DateTime.TryParse(result.ToString(), out DateTime parsedDateTime))
                            {
                                maxPostedDateTime = parsedDateTime;
                            }
                        }

                        // Convert "Time In" string to match the format of Local_Date_Time (yyyy-MM-dd HH:mm:ss)
                        string timeInFormatted = timeIn.ToString("yyyy-MM-dd HH:mm:ss");

                        // Compare Time In with maxLocalDateTime
                        if (maxPostedDateTime == null || timeInFormatted.CompareTo(maxPostedDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss")) > 0)
                        {
                            // Insert new attendance record
                            using (SQLiteCommand insertCommand = new SQLiteCommand(
                                "INSERT INTO Attendance (organization_id, employee_id, checkin_time, checkout_time, verify_date, Posted_Date_Time, Local_Date_Time)" +
                                " VALUES (@organization_id, @employee_id, @checkin_time, @checkout_time, @verify_date, @Posted_Date_Time, @Local_Date_Time)", connection))
                            {
                                insertCommand.Parameters.AddWithValue("@organization_id", organization_id);

                                // Add employee ID if it exists and is valid
                                if (row["User ID"] != DBNull.Value && int.TryParse(row["User ID"].ToString(), out int employeeId))
                                {
                                    insertCommand.Parameters.AddWithValue("@employee_id", employeeId);
                                }

                                // Add check-in time
                                insertCommand.Parameters.AddWithValue("@checkin_time", row["Time In"].ToString());

                                // Only add check-out time if it's not null
                                if (row["Time Out"] != DBNull.Value)
                                {
                                    insertCommand.Parameters.AddWithValue("@checkout_time", row["Time Out"].ToString());
                                }

                                // Only add verify date if it's not null
                                if (row["Verify Date"] != DBNull.Value)
                                {
                                    insertCommand.Parameters.AddWithValue("@verify_date", row["Verify Date"].ToString());
                                }

                                // Assuming null for Posted_Date_Time (no need to add DBNull)
                                insertCommand.Parameters.AddWithValue("@Posted_Date_Time", DBNull.Value);

                                // Set current local time for Local_Date_Time (stored as TEXT)
                                insertCommand.Parameters.AddWithValue("@Local_Date_Time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                               
                                try
                                {
                                    insertCommand.ExecuteNonQuery();
                                     
                                    


                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error inserting data: " + ex.Message);
                                }
                               
                            }
                        }
                    }
                }
            }
            }





        private void DeleteDataFromDatabase()
        {
            string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Office.db");
            string connectionString = $"Data Source={dbFilePath};";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                 
                string maxDateTimeQuery = "SELECT MAX(Local_Date_Time) FROM Attendance";
                string maxLocalDateTime = string.Empty;

                using (SQLiteCommand command = new SQLiteCommand(maxDateTimeQuery, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maxLocalDateTime = result.ToString();
                    }
                }

               
                if (!string.IsNullOrEmpty(maxLocalDateTime))
                {
                    string deleteQuery = "DELETE FROM Attendance WHERE Local_Date_Time != @maxLocalDateTime";

                    using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@maxLocalDateTime", maxLocalDateTime);
                        deleteCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        async Task PostAttendance()
        {
            string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Office.db");
            string connectionString = $"Data Source={dbFilePath};";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT organization_id, employee_id, checkin_time, checkout_time, verify_date FROM Attendance WHERE Posted_Date_Time IS NULL";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            using (HttpClient hc = new HttpClient { BaseAddress = new Uri("http://103.140.0.164:8000/api/attendance") })
                            {
                                while (reader.Read())
                                {
                                    // Extract row data
                                    int organization_id = reader.GetInt32(0);
                                    int employee_id = reader.GetInt32(1);
                                    string checkin_time = reader.GetString(2);
                                    string checkout_time = reader.GetString(3);
                                    string verify_date = reader.GetString(4);

                                    var data = new
                                    {
                                        organization_id,
                                        employee_id,
                                        checkin_time,
                                        checkout_time,
                                        verify_date
                                    };

                                    
                                    StringContent content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                                    try
                                    {
                                        HttpResponseMessage response = await hc.PostAsync("", content);

                                        if (response.IsSuccessStatusCode)
                                        {
                                            string responseData = await response.Content.ReadAsStringAsync();
                                            Console.WriteLine("Data posted successfully. Response: " + responseData);

                                            
                                            using (SQLiteCommand updateCommand = new SQLiteCommand("UPDATE Attendance SET Posted_Date_Time = @Posted_Date_Time WHERE organization_id = @organization_id AND employee_id = @employee_id AND checkin_time = @checkin_time AND checkout_time = @checkout_time AND verify_date = @verify_date ", connection))
                                            {
                                                updateCommand.Parameters.AddWithValue("@Posted_Date_Time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                                                
                                                // Assign the necessary parameters for the WHERE clause
                                                updateCommand.Parameters.AddWithValue("@organization_id", organization_id);
                                                updateCommand.Parameters.AddWithValue("@employee_id", employee_id);
                                                updateCommand.Parameters.AddWithValue("@checkin_time", checkin_time);
                                                updateCommand.Parameters.AddWithValue("@checkout_time", checkout_time);
                                                updateCommand.Parameters.AddWithValue("@verify_date", verify_date);

                                                updateCommand.ExecuteNonQuery();
                                            }

                                           



                                        }
                                        else
                                        {
                                            string errorResponse = await response.Content.ReadAsStringAsync();
                                            Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                                            Console.WriteLine("Error Response: " + errorResponse);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Exception while posting data: {ex.Message}");
                                    }
                                    
                                }
                                DeleteDataFromDatabase();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
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




