using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Data.SqlClient;

namespace StandaloneSDKDemo
{
    public partial class MonthlyReport2 : UserControl
    {
        DataTable test;
        static HttpClient client = new HttpClient();
        public MonthlyReport2(Main Parent)
        {
            InitializeComponent();
            MonthlyReport = Parent;
            PopulateComboBox();
        }
        private Main MonthlyReport;

        private void PopulateComboBox()
        {
            for (int year = 2050; year <= 2090; year++)
            {
                comboBoxYear.Items.Add(year.ToString());
            }
            for (int date = 1; date <= 32; date++)
            {
                comboBox1Date.Items.Add(date.ToString());
            }
        }

        public bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

    

        private void btnFilter_Click(object sender, EventArgs e)
        {
        }



        int MapNepaliMonthToEnglishMonth(string nepaliMonth)
        {
            switch (nepaliMonth)
            {
                case "Baisakh":
                    return 1;
                case "Jestha":
                    return 2;
                case "Ashadh":
                    return 3;
                case "Shrawan":
                    return 4;
                case "Bhadra":
                    return 5;
                case "Ashwin":
                    return 6;
                case "Kartik":
                    return 7;
                case "Mangsir":
                    return 8;
                case "Poush":
                    return 9;
                case "Magh":
                    return 10;
                case "Falgun":
                    return 11;
                case "Chaitra":
                    return 12;
                default:
                    throw new ArgumentException("Invalid Nepali month");
            }
        }

       

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click_2(object sender, EventArgs e)
        {
            try
            {
                int idwYear = 2080;
                int idwMonth = 1;
                int idwDay = 1;

                // Fetch selected year, month, and day from the combo boxes
                if (comboBoxYear.SelectedItem != null && int.TryParse(comboBoxYear.SelectedItem.ToString(), out int selectedYear))
                {
                    idwYear = selectedYear;
                }

                if (comboBoxMonth.SelectedItem != null)
                {
                    string selectedMonth = comboBoxMonth.SelectedItem.ToString();
                    idwMonth = MapNepaliMonthToEnglishMonth(selectedMonth);
                }

                if (comboBox1Date.SelectedItem != null && int.TryParse(comboBox1Date.SelectedItem.ToString(), out int selectedDay))
                {
                    idwDay = selectedDay;
                }

                // Set fromDate and toDate based on selected values
                DateConverter englishDateFrom;
                DateConverter englishDateTo;
                string fromDate = string.Empty; // Initialize with default value
                string toDate = string.Empty; // Initialize with default value

                if (comboBox1Date.SelectedItem != null && comboBoxMonth.SelectedItem != null && comboBoxYear.SelectedItem != null) // Year, Month, and Day selected
                {
                    englishDateFrom = DateConverter.ConvertToEnglish(idwYear, idwMonth, idwDay);
                    englishDateTo = DateConverter.ConvertToEnglish(idwYear, idwMonth, idwDay);

                    fromDate = $"{englishDateFrom.Year}-{englishDateFrom.Month:D2}-{englishDateFrom.Day:D2} 00:00:00";
                    toDate = $"{englishDateTo.Year}-{englishDateTo.Month:D2}-{englishDateTo.Day:D2} 23:59:59";
                }
                else if (comboBoxMonth.SelectedItem != null && comboBoxYear.SelectedItem != null) // Year and Month selected
                {
                    englishDateFrom = DateConverter.ConvertToEnglish(idwYear, idwMonth, 1);
                    englishDateTo = DateConverter.ConvertToEnglish(idwYear, idwMonth, DateTime.DaysInMonth(idwYear, idwMonth));
                    fromDate = $"{englishDateFrom.Year}-{englishDateFrom.Month:D2}-{englishDateFrom.Day:D2} 00:00:00";
                    toDate = $"{englishDateTo.Year}-{englishDateTo.Month:D2}-{englishDateTo.Day:D2} 23:59:59";
                }
                else // Only Year selected
                {
                    englishDateFrom = DateConverter.ConvertToEnglish(idwYear, 1, 1);
                    englishDateTo = DateConverter.ConvertToEnglish(idwYear, 12, 31);
                    fromDate = $"{englishDateFrom.Year}-{englishDateFrom.Month:D2}-{englishDateFrom.Day:D2} 00:00:00";
                    toDate = $"{englishDateTo.Year}-{englishDateTo.Month:D2}-{englishDateTo.Day:D2} 23:59:59";
                }

                // Fetch data
                DataTable dt_periodLog = new DataTable("dt_periodLog");
                gv_Attlog.Columns.Clear();
                dt_periodLog.Columns.Add("User ID", System.Type.GetType("System.String"));
                dt_periodLog.Columns.Add("User Name", System.Type.GetType("System.String"));
                dt_periodLog.Columns.Add("Verify Date", System.Type.GetType("System.String"));
                dt_periodLog.Columns.Add("Verify Type", System.Type.GetType("System.Int32"));
                dt_periodLog.Columns.Add("Verify State", System.Type.GetType("System.Int32"));
                dt_periodLog.Columns.Add("WorkCode", System.Type.GetType("System.Int32"));
                dt_periodLog.Columns.Add("Time In", System.Type.GetType("System.String"));
                dt_periodLog.Columns.Add("Time Out", System.Type.GetType("System.String"));
                dt_periodLog.Columns.Add("Status", System.Type.GetType("System.String"));

                // Ensure that fromDate and toDate have been set before calling sta_readLogByPeriod
                if (!string.IsNullOrEmpty(fromDate) && !string.IsNullOrEmpty(toDate))
                {
                    MonthlyReport.SDK.sta_readLogByPeriod(MonthlyReport.lbSysOutputInfo, dt_periodLog, fromDate, toDate);
                }
                else
                {
                    MessageBox.Show("Please select valid dates from the combo boxes.");
                    return;
                }

                // Filter data based on selected user ID
                DataTable finalTable = dt_periodLog.Clone();
                if (txtBoxName.Text != null)
                {
                    string selectedUserName = txtBoxName.Text.ToString();
                    DataRow[] filteredRows = dt_periodLog.Select($"[User Name] = '{selectedUserName}'");

                    foreach (DataRow row in filteredRows)
                    {
                        finalTable.ImportRow(row);
                    }

                    // Process the filtered table to merge rows with the same date
                    string previousDate = string.Empty;
                    List<DataRow> rowsToDelete = new List<DataRow>();

                    foreach (DataRow row in finalTable.Rows)
                    {
                        DateTime currentDateTime = DateTime.Parse(row["Verify Date"].ToString());
                        string currentDate = currentDateTime.ToString("yyyy-MM-dd");

                        if (currentDate == previousDate)
                        {
                            rowsToDelete.Add(row);
                        }
                        else
                        {
                            previousDate = currentDate;
                        }
                    }

                    foreach (DataRow row in rowsToDelete)
                    {
                        finalTable.Rows.Remove(row);
                    }
                    finalTable.AcceptChanges();
                }
                else
                {
                    finalTable = dt_periodLog;
                }

                gv_Attlog.DataSource = finalTable;
                DeleteDataFromDatabase();
                InsertDataIntoDatabase(finalTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private RDLC rdlcForm;

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            rdlcForm = Application.OpenForms.OfType<RDLC>().FirstOrDefault();

            if (rdlcForm == null)
            {

                rdlcForm = new RDLC();
                rdlcForm.Show();
            }


            rdlcForm.SetReportParameters(comboBoxYear.Text, txtBoxName.Text, comboBoxMonth.Text, comboBox1Date.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox6.Text, comboBox5.Text, comboBox4.Text);

            if (comboBoxYear.SelectedItem == null)
            {
                comboBoxYear.Text = null;
                rdlcForm.SetReportParameters(comboBoxYear.Text, txtBoxName.Text, comboBoxMonth.Text, comboBox1Date.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox6.Text, comboBox5.Text, comboBox4.Text);

            }

            if (comboBox1Date.SelectedItem == null)
            {
                comboBox1Date.Text = null;
                rdlcForm.SetReportParameters(comboBoxYear.Text, txtBoxName.Text, comboBoxMonth.Text, comboBox1Date.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox6.Text, comboBox5.Text, comboBox4.Text);

            }

            if (comboBoxMonth.SelectedItem == null)
            {
                comboBoxMonth.Text = null;
                rdlcForm.SetReportParameters(comboBoxYear.Text, txtBoxName.Text, comboBoxMonth.Text, comboBox1Date.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox6.Text, comboBox5.Text, comboBox4.Text);

            }

            if (txtBoxName.Text == null)
            {
                txtBoxName.Text = null;
                rdlcForm.SetReportParameters(comboBoxYear.Text, txtBoxName.Text, comboBoxMonth.Text, comboBox1Date.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox6.Text, comboBox5.Text, comboBox4.Text);

            }

            if (comboBox1.SelectedItem == null)
            {
                comboBox1.SelectedItem = null;
                rdlcForm.SetReportParameters(comboBoxYear.Text, txtBoxName.Text, comboBoxMonth.Text, comboBox1Date.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox6.Text, comboBox5.Text, comboBox4.Text);

            }
            if (comboBox2.SelectedItem == null)
            {
                comboBox2.SelectedItem = null;
                rdlcForm.SetReportParameters(comboBoxYear.Text, txtBoxName.Text, comboBoxMonth.Text, comboBox1Date.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox6.Text, comboBox5.Text, comboBox4.Text);

            }
            if (comboBox3.SelectedItem == null)
            {
                comboBox3.SelectedItem = null;
                rdlcForm.SetReportParameters(comboBoxYear.Text, txtBoxName.Text, comboBoxMonth.Text, comboBox1Date.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox6.Text, comboBox5.Text, comboBox4.Text);

            }
            if (comboBox4.SelectedItem == null)
            {
                comboBox1.SelectedItem = null;
                rdlcForm.SetReportParameters(comboBoxYear.Text, txtBoxName.Text, comboBoxMonth.Text, comboBox1Date.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox6.Text, comboBox5.Text, comboBox4.Text);

            }
            if (comboBox5.SelectedItem == null)
            {
                comboBox1.SelectedItem = null;
                rdlcForm.SetReportParameters(comboBoxYear.Text, txtBoxName.Text, comboBoxMonth.Text, comboBox1Date.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox6.Text, comboBox5.Text, comboBox4.Text);

            }
            if (comboBox6.SelectedItem == null)
            {
                comboBox1.SelectedItem = null;
                rdlcForm.SetReportParameters(comboBoxYear.Text, txtBoxName.Text, comboBoxMonth.Text, comboBox1Date.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox6.Text, comboBox5.Text, comboBox4.Text);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            txtBoxName.Text = "";
            comboBoxYear.Text = "";
            comboBoxMonth.Text = "";
            comboBox1Date.Text = "";
        }

        private void DeleteDataFromDatabase()
        {
            string connectionString = @"Data Source=DESKTOP-82VS1OF\SQLEXPRESS; Initial Catalog=Project;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM Ledger", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertDataIntoDatabase(DataTable dt_periodLog)
        {
            string connectionString = @"Data Source=DESKTOP-82VS1OF\SQLEXPRESS; Initial Catalog=Project;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataRow row in dt_periodLog.Rows)
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO Ledger (UserID, UserName, VerifyDate, VerifyType, VerifyState, WorkCode, TimeIn, TimeOut, Status) VALUES (@UserID,@UserName, @VerifyDate, @VerifyType, @VerifyState, @WorkCode, @TimeIn, @TimeOut, @Status)", connection))
                    {
                        command.Parameters.AddWithValue("@UserID", row["User ID"]);
                        command.Parameters.AddWithValue("@UserName", row["User Name"]);
                        command.Parameters.AddWithValue("@VerifyDate", row["Verify Date"]);
                        command.Parameters.AddWithValue("@VerifyType", row["Verify Type"]);
                        command.Parameters.AddWithValue("@VerifyState", row["Verify State"]);
                        command.Parameters.AddWithValue("@WorkCode", row["WorkCode"]);
                        command.Parameters.AddWithValue("@TimeIn", row["Time In"]);
                        command.Parameters.AddWithValue("@TimeOut", row["Time Out"]);
                        command.Parameters.AddWithValue("@Status", row["Status"]);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            DataTable dt_periodLog = new DataTable("dt_periodLog");
            gv_Attlog.AutoGenerateColumns = true;
            gv_Attlog.Columns.Clear();
            dt_periodLog.Columns.Add("User ID", System.Type.GetType("System.String"));
            dt_periodLog.Columns.Add("User Name", System.Type.GetType("System.String"));

            dt_periodLog.Columns.Add("Verify Date", System.Type.GetType("System.String"));
            dt_periodLog.Columns.Add("Verify Type", System.Type.GetType("System.Int32"));
            dt_periodLog.Columns.Add("Verify State", System.Type.GetType("System.Int32"));
            dt_periodLog.Columns.Add("WorkCode", System.Type.GetType("System.Int32"));
            dt_periodLog.Columns.Add("Time In", System.Type.GetType("System.String"));
            dt_periodLog.Columns.Add("Time Out", System.Type.GetType("System.String"));
            dt_periodLog.Columns.Add("Status", System.Type.GetType("System.String"));
            gv_Attlog.DataSource = dt_periodLog;

            MonthlyReport.SDK.sta_readAttLog(MonthlyReport.lbSysOutputInfo, dt_periodLog);
            DeleteDataFromDatabase();
            InsertDataIntoDatabase(dt_periodLog);

            Cursor = Cursors.Default;
        }

        private void MonthlyReport2_Load(object sender, EventArgs e)
        {

        }

        private void gv_Attlog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

