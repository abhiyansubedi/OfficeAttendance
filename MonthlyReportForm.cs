using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using StandaloneSDKDemo.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace StandaloneSDKDemo
{
    public partial class MonthlyReportForm : UserControl
    {
        DataTable test;
        static HttpClient client = new HttpClient();
        public MonthlyReportForm(Main Parent)
        {
            InitializeComponent();
            MonthlyReport = Parent;
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

        public void MonthFilter()
        {
            // Assuming selectedMonth and selectedYear are fetched from the combo boxes
            string selectedMonth = comboBoxMonth.SelectedItem?.ToString();
            string selectedYear = comboBoxYear.SelectedItem?.ToString();

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
            gv_Attlog.DataSource = dt_periodLog;

            // Populate dt_periodLog here
            // For example, you can add rows manually or fetch from some source
            // dt_periodLog.Rows.Add(...);

          
            foreach (DataRow row in dt_periodLog.Rows)
            {
                DateTime englishDate = Convert.ToDateTime(row["Verify Date"]);
                DateConverter nepaliDate = DateConverter.ConvertToNepali(englishDate.Year, englishDate.Month, englishDate.Day);

                if (selectedMonth != null && selectedYear != null)
                {
                    var monthMapping = new Dictionary<string, int>
                {
                    { "Baisakh", 1 },
                    { "Jestha", 2 },
                    { "Ashadh", 3 },
                    { "Shrawan", 4 },
                    { "Bhadra", 5 },
                    { "Ashwin", 6 },
                    { "Kartik", 7 },
                    { "Mangsir", 8 },
                    { "Poush", 9 },
                    { "Magh", 10 },
                    { "Falgun", 11 },
                    { "Chaitra", 12 }
                };

                    int monthNumber = monthMapping[selectedMonth];
                    bool isLeapYear = IsLeapYear(nepaliDate.Year);

                    if ((nepaliDate.Year == int.Parse(selectedYear)) && (nepaliDate.Month == monthNumber))
                    {
                        if (nepaliDate.Month == 12 && nepaliDate.Day == 30 && !isLeapYear)
                        {
                            row.Delete();
                        }
                    }
                    else
                    {
                        row.Delete();
                    }
                }
                else if (selectedMonth != null)
                {
                    var monthMapping = new Dictionary<string, int>
                    {
                    { "Baisakh", 1 },
                    { "Jestha", 2 },
                    { "Ashadh", 3 },
                    { "Shrawan", 4 },
                    { "Bhadra", 5 },
                    { "Ashwin", 6 },
                    { "Kartik", 7 },
                    { "Mangsir", 8 },
                    { "Poush", 9 },
                    { "Magh", 10 },
                    { "Falgun", 11 },
                    { "Chaitra", 12 }
                    };
                    int monthNumber = monthMapping[selectedMonth];
                    if (nepaliDate.Month != monthNumber)
                    {
                        row.Delete();
                    }
                }
                else if (selectedYear != null)
                {
                    if (nepaliDate.Year != int.Parse(selectedYear))
                    {
                        row.Delete();
                    }
                }

                row["Verify Date"] = $"{nepaliDate.Year}/{nepaliDate.Month}/{nepaliDate.Day}";
            }

            dt_periodLog.AcceptChanges();
            gv_Attlog.DataSource = dt_periodLog;

        }
        public bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        private void button1_Click_1(object sender, EventArgs e)
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
            Cursor = Cursors.Default;

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MonthFilter();
            //Cursor = Cursors.WaitCursor;
            //string fromTime = "2080";
            //string toTime = "2081";
            //DataTable dt_periodLog = new DataTable("dt_periodLog");
            //gv_Attlog.AutoGenerateColumns = true;
            //gv_Attlog.Columns.Clear();
            //dt_periodLog.Columns.Add("User ID", System.Type.GetType("System.String"));
            //dt_periodLog.Columns.Add("Verify Date", System.Type.GetType("System.String"));
            //dt_periodLog.Columns.Add("Verify Type", System.Type.GetType("System.Int32"));
            //dt_periodLog.Columns.Add("Verify State", System.Type.GetType("System.Int32"));
            //dt_periodLog.Columns.Add("WorkCode", System.Type.GetType("System.Int32"));
            //dt_periodLog.Columns.Add("Time In", System.Type.GetType("System.String"));
            //dt_periodLog.Columns.Add("Time Out", System.Type.GetType("System.String"));
            //dt_periodLog.Columns.Add("Status", System.Type.GetType("System.String"));
            //gv_Attlog.DataSource = dt_periodLog;
            ////main data
            //MonthlyReport.SDK.sta_readLogByPeriod(MonthlyReport.lbSysOutputInfo, dt_periodLog, fromTime, toTime);
            //Cursor = Cursors.Default;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            
            //    int idwYear = 2080;
            //    int idwMonth = 1;
            //    int idwDay = 1;

            //    // Fetch selected year, month, and day from the combo boxes
            //    if (comboBox3.SelectedItem != null && int.TryParse(comboBox3.SelectedItem.ToString(), out int selectedYear))
            //    {
            //        idwYear = selectedYear;
            //    }

            //    if (comboBox4.SelectedItem != null && int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedMonth))
            //    {
            //        idwMonth = selectedMonth;
            //    }

            //    if (comboBox1.SelectedItem != null && int.TryParse(comboBox1.SelectedItem.ToString(), out int selectedDay))
            //    {
            //        idwDay = selectedDay;
            //    }

            //    // Set fromDate and toDate based on selected values
            //    DateConverter englishDateFrom;
            //    DateConverter englishDateTo;
            //    string fromDate;
            //    string toDate;

            //    if (comboBox1.SelectedItem != null && comboBox4.SelectedItem != null && comboBox3.SelectedItem != null) // Year, Month, and Day selected
            //    {
            //        englishDateFrom = DateConverter.ConvertToEnglish(idwYear, idwMonth, idwDay);
            //        englishDateTo = DateConverter.ConvertToEnglish(idwYear, idwMonth, idwDay);

            //        fromDate = $"{englishDateFrom.Year}-{englishDateFrom.Month:D2}-{englishDateFrom.Day:D2} 00:00:00";
            //        toDate = $"{englishDateTo.Year}-{englishDateTo.Month:D2}-{englishDateTo.Day:D2} 00:00:00";
                    
            //    }
            //    //else if (comboBox4.SelectedItem!= null)// Year and Date selected
            //    //{
            //    //    englishDateFrom = DateConverter.ConvertToEnglish(idwYear, idwMonth, idwDay);
            //    //    englishDateTo = DateConverter.ConvertToEnglish(idwYear, idwMonth, idwDay);
            //    //    fromDate = $"{englishDateFrom.Year}-{englishDateFrom.Month:D2}-{englishDateFrom.Day:D2} 00:00:00";
            //    //    toDate = fromDate; // Same day
            //    //}
            //    else if (comboBox4.SelectedItem != null) // Year and Month selected
            //    {
            //        englishDateFrom = DateConverter.ConvertToEnglish(idwYear, idwMonth, 1);
            //        englishDateTo = DateConverter.ConvertToEnglish(idwYear, idwMonth, 32);
            //        fromDate = $"{englishDateFrom.Year}-{englishDateFrom.Month:D2}-{englishDateFrom.Day:D2} 00:00:00";
            //        toDate = $"{englishDateTo.Year}-{englishDateTo.Month:D2}-{englishDateTo.Day:D2} 23:59:59";
            //    }
            //    else // Only Year selected
            //    {
            //        englishDateFrom = DateConverter.ConvertToEnglish(idwYear, 1, 1);
            //        englishDateTo = DateConverter.ConvertToEnglish(idwYear, 12, 31);
            //        fromDate = $"{englishDateFrom.Year}-{englishDateFrom.Month:D2}-{englishDateFrom.Day:D2} 00:00:00";
            //        toDate = $"{englishDateTo.Year}-{englishDateTo.Month:D2}-{englishDateTo.Day:D2} 23:59:59";
            //    }

            //    //// Step 3: Concatenate with "23:59:59"
            //    //string toTime = datePart + " 23:59:59";

            //    DataTable dt_periodLog = new DataTable("dt_periodLog");
            //    gv_Attlog.Columns.Clear();
            //    dt_periodLog.Columns.Add("User ID", System.Type.GetType("System.String"));
            //    dt_periodLog.Columns.Add("Verify Date", System.Type.GetType("System.String"));
            //    dt_periodLog.Columns.Add("Verify Type", System.Type.GetType("System.Int32"));
            //    dt_periodLog.Columns.Add("Verify State", System.Type.GetType("System.Int32"));
            //    dt_periodLog.Columns.Add("WorkCode", System.Type.GetType("System.Int32"));
            //    dt_periodLog.Columns.Add("Time In", System.Type.GetType("System.String"));
            //    dt_periodLog.Columns.Add("Time Out", System.Type.GetType("System.String"));
            //    dt_periodLog.Columns.Add("Status", System.Type.GetType("System.String"));
            //    gv_Attlog.DataSource = dt_periodLog;
            //    MonthlyReport.SDK.sta_readLogByPeriod(MonthlyReport.lbSysOutputInfo, dt_periodLog, fromDate, toDate);
            //}

            ////        var monthMapping = new Dictionary<string, int>
            ////{
            ////    { "Baisakh", 1 },
            ////    { "Jestha", 2 },
            ////    { "Ashadh", 3 },
            ////    { "Shrawan", 4 },
            ////    { "Bhadra", 5 },
            ////    { "Ashwin", 6 },
            ////    { "Kartik", 7 },
            ////    { "Mangsir", 8 },
            ////    { "Poush", 9 },
            ////    { "Magh", 10 },
            ////    { "Falgun", 11 },
            ////    { "Chaitra", 12 }
            ////};

            ////        List<DataRow> rowsToDelete = new List<DataRow>();

            ////        foreach (DataRow row in dt_periodLog.Rows)
            ////        {
            ////            DateTime englishDate = Convert.ToDateTime(row["Verify Date"]);
            ////            DateConverter nepaliDate = DateConverter.ConvertToNepali(englishDate.Year, englishDate.Month, englishDate.Day);

            ////            if (selectedMonth != null && selectedYear != null)
            ////            {
            ////                int monthNumber = monthMapping[selectedMonth];
            ////                bool isLeapYear = IsLeapYear(nepaliDate.Year);

            ////                if ((nepaliDate.Year == int.Parse(selectedYear)) && (nepaliDate.Month == monthNumber))
            ////                {
            ////                    if (nepaliDate.Month == 12 && nepaliDate.Day == 30 && !isLeapYear)
            ////                    {
            ////                        rowsToDelete.Add(row);
            ////                    }
            ////                }
            ////                else
            ////                {
            ////                    rowsToDelete.Add(row);
            ////                }
            ////            }
            ////            else if (selectedMonth != null)
            ////            {
            ////                int monthNumber = monthMapping[selectedMonth];

            ////                if (nepaliDate.Month != monthNumber)
            ////                {
            ////                    rowsToDelete.Add(row);
            ////                }
            ////            }
            ////            else if (selectedYear != null)
            ////            {
            ////                if (nepaliDate.Year != int.Parse(selectedYear))
            ////                {
            ////                    rowsToDelete.Add(row);
            ////                }
            ////            }

            ////            row["Verify Date"] = $"{nepaliDate.Year}/{nepaliDate.Month}/{nepaliDate.Day}";


            ////        }

            ////        foreach (DataRow row in rowsToDelete)
            ////        {
            ////            row.Delete();
            ////        }

            ////        dt_periodLog.AcceptChanges();
            ////        gv_Attlog.DataSource = dt_periodLog;
            ////        MonthlyReport.SDK.sta_readAttLog(MonthlyReport.lbSysOutputInfo, dt_periodLog);


            ////    }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred: " + ex.Message);
            //}





        }

        private void btnFilter_Click(object sender, EventArgs e)
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
                string fromDate;
                string toDate;

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
                else  // Only Year selected
                {
                    englishDateFrom = DateConverter.ConvertToEnglish(idwYear, 1, 1);
                    englishDateTo = DateConverter.ConvertToEnglish(idwYear, 12, 31);
                    fromDate = $"{englishDateFrom.Year}-{englishDateFrom.Month:D2}-{englishDateFrom.Day:D2} 00:00:00";
                    toDate = $"{englishDateTo.Year}-{englishDateTo.Month:D2}-{englishDateTo.Day:D2} 23:59:59";
                }

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
                gv_Attlog.DataSource = dt_periodLog;
                MonthlyReport.SDK.sta_readLogByPeriod(MonthlyReport.lbSysOutputInfo, dt_periodLog, fromDate, toDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
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


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
