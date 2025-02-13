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
using System.Data.SQLite;
using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;
using System.Drawing.Printing;

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
            //for (int year = 2050; year <= 2090; year++)
            //{
            //    comboBoxYear.Items.Add(year.ToString());
            //}
            //for (int date = 1; date <= 32; date++)
            //{
            //    comboBox1Date.Items.Add(date.ToString());
            //}
        }

        //public void MonthFilter()
        //{
        //    // Assuming selectedMonth and selectedYear are fetched from the combo boxes
        //    string selectedMonth = comboBoxMonth.SelectedItem?.ToString();
        //    string selectedYear = comboBoxYear.SelectedItem?.ToString();

        //    DataTable dt_periodLog = new DataTable("dt_periodLog");
        //    gv_Attlog.Columns.Clear();
        //    dt_periodLog.Columns.Add("User ID", System.Type.GetType("System.String"));
        //    dt_periodLog.Columns.Add("User Name", System.Type.GetType("System.String"));
        //    dt_periodLog.Columns.Add("Verify Date", System.Type.GetType("System.String"));
        //    dt_periodLog.Columns.Add("Verify Type", System.Type.GetType("System.Int32"));
        //    dt_periodLog.Columns.Add("Verify State", System.Type.GetType("System.Int32"));
        //    dt_periodLog.Columns.Add("WorkCode", System.Type.GetType("System.Int32"));
        //    dt_periodLog.Columns.Add("Time In", System.Type.GetType("System.String"));
        //    dt_periodLog.Columns.Add("Time Out", System.Type.GetType("System.String"));
        //    dt_periodLog.Columns.Add("Status", System.Type.GetType("System.String"));
        //    gv_Attlog.DataSource = dt_periodLog;

        //    // Populate dt_periodLog here
        //    // For example, you can add rows manually or fetch from some source
        //    // dt_periodLog.Rows.Add(...);

          
        //    foreach (DataRow row in dt_periodLog.Rows)
        //    {
        //        DateTime englishDate = Convert.ToDateTime(row["Verify Date"]);
        //        DateConverter nepaliDate = DateConverter.ConvertToNepali(englishDate.Year, englishDate.Month, englishDate.Day);

        //        if (selectedMonth != null && selectedYear != null)
        //        {
        //            var monthMapping = new Dictionary<string, int>
        //        {
        //            { "Baisakh", 1 },
        //            { "Jestha", 2 },
        //            { "Ashadh", 3 },
        //            { "Shrawan", 4 },
        //            { "Bhadra", 5 },
        //            { "Ashwin", 6 },
        //            { "Kartik", 7 },
        //            { "Mangsir", 8 },
        //            { "Poush", 9 },
        //            { "Magh", 10 },
        //            { "Falgun", 11 },
        //            { "Chaitra", 12 }
        //        };

        //            int monthNumber = monthMapping[selectedMonth];
        //            bool isLeapYear = IsLeapYear(nepaliDate.Year);

        //            if ((nepaliDate.Year == int.Parse(selectedYear)) && (nepaliDate.Month == monthNumber))
        //            {
        //                if (nepaliDate.Month == 12 && nepaliDate.Day == 30 && !isLeapYear)
        //                {
        //                    row.Delete();
        //                }
        //            }
        //            else
        //            {
        //                row.Delete();
        //            }
        //        }
        //        else if (selectedMonth != null)
        //        {
        //            var monthMapping = new Dictionary<string, int>
        //            {
        //            { "Baisakh", 1 },
        //            { "Jestha", 2 },
        //            { "Ashadh", 3 },
        //            { "Shrawan", 4 },
        //            { "Bhadra", 5 },
        //            { "Ashwin", 6 },
        //            { "Kartik", 7 },
        //            { "Mangsir", 8 },
        //            { "Poush", 9 },
        //            { "Magh", 10 },
        //            { "Falgun", 11 },
        //            { "Chaitra", 12 }
        //            };
        //            int monthNumber = monthMapping[selectedMonth];
        //            if (nepaliDate.Month != monthNumber)
        //            {
        //                row.Delete();
        //            }
        //        }
        //        else if (selectedYear != null)
        //        {
        //            if (nepaliDate.Year != int.Parse(selectedYear))
        //            {
        //                row.Delete();
        //            }
        //        }

        //        row["Verify Date"] = $"{nepaliDate.Year}/{nepaliDate.Month}/{nepaliDate.Day}";
        //    }

        //    dt_periodLog.AcceptChanges();
        //    gv_Attlog.DataSource = dt_periodLog;

        //}
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
                int idwYear2 = 2080;
                int idwMonth2 = 12;
                int idwDay2 = 31;

                if (comboBox1.SelectedItem != null && int.TryParse(comboBox1.SelectedItem.ToString(), out int selectedYear))
                {
                    idwYear = selectedYear;
                }

                if (comboBox2.SelectedItem != null && int.TryParse(comboBox2.SelectedItem.ToString(), out int selectedMonth))
                {
                    idwMonth = selectedMonth;
                }

                if (comboBox3.SelectedItem != null && int.TryParse(comboBox3.SelectedItem.ToString(), out int selectedDate))
                {
                    idwDay = selectedDate;
                }

                if (comboBox6.SelectedItem != null && int.TryParse(comboBox6.SelectedItem.ToString(), out int selectedYear2))
                {
                    idwYear2 = selectedYear2;
                }

                if (comboBox5.SelectedItem != null && int.TryParse(comboBox5.SelectedItem.ToString(), out int selectedMonth2))
                {
                    idwMonth2 = selectedMonth2;
                }

                if (comboBox4.SelectedItem != null && int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedDate2))
                {
                    idwDay2 = selectedDate2;
                }

                DateConverter englishDateFrom;
                DateConverter englishDateTo;
                string fromDate = string.Empty; // Initialize with default value
                string toDate = string.Empty; // Initialize with default value

                if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null &&
                    comboBox6.SelectedItem != null && comboBox5.SelectedItem != null && comboBox4.SelectedItem != null) // Year, Month, and Day selected
                {
                    englishDateFrom = DateConverter.ConvertToEnglish(idwYear, idwMonth, idwDay);
                    englishDateTo = DateConverter.ConvertToEnglish(idwYear2, idwMonth2, idwDay2);

                    fromDate = $"{englishDateFrom.Year}-{englishDateFrom.Month:D2}-{englishDateFrom.Day:D2} 00:00:00";
                    toDate = $"{englishDateTo.Year}-{englishDateTo.Month:D2}-{englishDateTo.Day:D2} 23:59:59";
                }
                else
                {
                    MessageBox.Show("Please select valid dates from the combo boxes.");
                    return;
                }

                DataTable dt_periodLog = new DataTable("dt_periodLog");
                gv_Attlog.Columns.Clear();
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
                gv_Attlog.DataSource = dt_periodLog;

                MonthlyReport.SDK.sta_readLogByPeriod(MonthlyReport.lbSysOutputInfo, dt_periodLog, fromDate, toDate);

                DataTable finalTable = dt_periodLog.Clone();
                if (!string.IsNullOrEmpty(txtBoxName.Text))
                {
                    string selectedUserName = txtBoxName.Text;
                    DataRow[] filteredRows = dt_periodLog.Select($"[User Name] = '{selectedUserName}'");

                    foreach (DataRow row in filteredRows)
                    {
                        finalTable.ImportRow(row);
                    }

                    string previousDate = string.Empty;
                    foreach (DataRow row in finalTable.Rows.Cast<DataRow>().ToList())
                    {
                        string currentDate = DateTime.Parse(row["Verify Date"].ToString()).ToString("yyyy-MM-dd");

                        if (currentDate == previousDate)
                        {
                            finalTable.Rows.Remove(row);
                        }
                        previousDate = currentDate;
                    }
                }
                else
                {
                    finalTable = dt_periodLog.Copy();
                }

                finalTable.AcceptChanges();
                gv_Attlog.DataSource = finalTable;

                DeleteDataFromDatabase();
                InsertDataIntoDatabase(finalTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void InsertDataIntoDatabase(DataTable dt_periodLog)
        {
            string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Office.db");
            string connectionString = $"Data Source={dbFilePath};";


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                foreach (DataRow row in dt_periodLog.Rows)
                {
                    using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Ledger (Organization_ID,UserID, UserName, VerifyDate, VerifyType, VerifyState, WorkCode, TimeIn, TimeOut, Status) VALUES (@Organization_ID,@UserID,@UserName, @VerifyDate, @VerifyType, @VerifyState, @WorkCode, @TimeIn, @TimeOut, @Status)", connection))
                    {
                        command.Parameters.AddWithValue("@Organization_ID", row["Organization_ID"]);
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
        private void DeleteDataFromDatabase()
        {
            string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Office.db");
            string connectionString = $"Data Source={dbFilePath};";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Ledger", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save a PDF File";
                saveFileDialog.FileName = "Office.pdf";

                // Show the dialog and check if the user clicked the save button
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            // Create PDF document
                            var document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);
                            var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, fs);
                            document.Open();

                            // Prepare heading texts
                            string headingText1 = label6.Text;
                            string headingText = txtBoxName.Text;
                            string headingText2 = lblFrom.Text;
                            string headingText3 = comboBox1.Text;
                            string headingText4 = comboBox2.Text;
                            string headingText5 = comboBox3.Text;
                            string headingText6 = lblTo.Text;
                            string headingText7 = comboBox6.Text;
                            string headingText8 = comboBox5.Text;
                            string headingText9 = comboBox4.Text;

                            // Create a table with 2 columns for the headings
                            PdfPTable headingTable = new PdfPTable(2);
                            headingTable.WidthPercentage = 100; // Make the table fill the width of the page

                            // First heading (left side)
                            string combinedHeading = $"{headingText1}: {headingText} \n\n {headingText2}: {headingText3}/{headingText4}/{headingText5} \n\n {headingText6}: {headingText7}/{headingText8}/{headingText9}";
                            var headingFont = iTextSharp.text.FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                            PdfPCell leftCell = new PdfPCell(new Phrase(combinedHeading, headingFont))
                            {
                                HorizontalAlignment = Element.ALIGN_LEFT,
                                Border = PdfPCell.NO_BORDER // No border for a cleaner look
                            };

                            // Second heading (right side)
                            string combinedHeading2 = null;
                            PdfPCell rightCell = new PdfPCell(new Phrase(combinedHeading2, headingFont))
                            {
                                HorizontalAlignment = Element.ALIGN_RIGHT,
                                Border = PdfPCell.NO_BORDER // No border for a cleaner look
                            };

                            // Add the cells to the table
                            headingTable.AddCell(leftCell);
                            headingTable.AddCell(rightCell);

                            // Add the table to the document
                            document.Add(headingTable);
                            document.Add(new iTextSharp.text.Paragraph("\n")); // Add a blank line for spacing

                            // Create a PDF table with the same number of columns as the DataGridView
                            PdfPTable pdfTable = new PdfPTable(gv_Attlog.Columns.Count);
                            float[] columnWidths = new float[gv_Attlog.Columns.Count];
                            for (int i = 0; i < columnWidths.Length; i++)
                            {
                                columnWidths[i] = 1f; // Set each column to the same width factor
                            }
                            pdfTable.SetWidths(columnWidths);
                            pdfTable.WidthPercentage = 100; // Make table fill the page width

                            // Add headers to the PDF table
                            for (int i = 0; i < gv_Attlog.Columns.Count; i++)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(gv_Attlog.Columns[i].HeaderText))
                                {
                                    HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER,
                                    VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE,
                                    BackgroundColor = new iTextSharp.text.BaseColor(200, 200, 200) // Light Gray Background
                                };
                                pdfTable.AddCell(cell);
                            }

                            // Add data from DataGridView to the PDF table
                            for (int i = 0; i < gv_Attlog.Rows.Count; i++)
                            {
                                for (int j = 0; j < gv_Attlog.Columns.Count; j++)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(gv_Attlog.Rows[i].Cells[j].Value?.ToString()))
                                    {
                                        HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER,
                                        VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE
                                    };
                                    pdfTable.AddCell(cell);
                                }
                            }

                            // Add the table to the PDF document
                            document.Add(pdfTable);

                            // Close the document
                            document.Close();
                            writer.Close();
                        }

                        MessageBox.Show("Data exported to PDF successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while exporting data to PDF: " + ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";
                saveFileDialog.FileName = "Office.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var package = new ExcelPackage())
                        {
                            var worksheet = package.Workbook.Worksheets.Add("Office Data");

                            // Prepare heading texts
                            string headingText1 = label6.Text;
                            string headingText = txtBoxName.Text;
                            string headingText2 = lblFrom.Text;
                            string headingText3 = comboBox1.Text;
                            string headingText4 = comboBox2.Text;
                            string headingText5 = comboBox3.Text;
                            string headingText6 = lblTo.Text;
                            string headingText7 = comboBox6.Text;
                            string headingText8 = comboBox5.Text;
                            string headingText9 = comboBox4.Text;

                            // Set headings
                            worksheet.Cells[1, 1].Value = $"{headingText1}: {headingText}";
                            worksheet.Cells[2, 1].Value = $"{headingText2}: {headingText3}/{headingText4}/{headingText5}";
                            worksheet.Cells[3, 1].Value = $"{headingText6}: {headingText7}/{headingText8}/{headingText9}";

                            // Increase height and width for heading cells
                            worksheet.Row(1).Height = 30; // Adjust heading row height as needed
                            worksheet.Row(2).Height = 30;
                            worksheet.Row(3).Height = 30;
                            worksheet.Column(1).Width = 30; // Adjust width for the heading column as needed

                            // Apply styles individually to each heading cell
                            worksheet.Cells[1, 1].Style.Font.Size = 14;
                            worksheet.Cells[1, 1].Style.Font.Bold = true;

                            worksheet.Cells[2, 1].Style.Font.Size = 14;
                            worksheet.Cells[2, 1].Style.Font.Bold = true;

                            worksheet.Cells[3, 1].Style.Font.Size = 14;
                            worksheet.Cells[3, 1].Style.Font.Bold = true;


                            worksheet.Cells[4, 1].Value = "";

                            // Add headers to the Excel table
                            for (int i = 0; i < gv_Attlog.Columns.Count; i++)
                            {
                                worksheet.Cells[5, i + 1].Value = gv_Attlog.Columns[i].HeaderText;
                                worksheet.Cells[5, i + 1].Style.Font.Bold = true;
                                worksheet.Cells[5, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                worksheet.Cells[5, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                                // Set width for each data table column
                                worksheet.Column(i + 1).Width = 18; // Adjust as needed for all columns
                            }

                            // Add data from DataGridView to the Excel worksheet
                            for (int i = 0; i < gv_Attlog.Rows.Count; i++)
                            {
                                for (int j = 0; j < gv_Attlog.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 6, j + 1].Value = gv_Attlog.Rows[i].Cells[j].Value?.ToString();
                                    worksheet.Cells[i + 6, j + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                                }
                            }

                            FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                            package.SaveAs(excelFile);
                        }

                        MessageBox.Show("Data exported to Excel successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while exporting data to Excel: " + ex.Message);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;

            // Show the PrintDialog
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Call the export functions based on the format desired (PDF/Excel)
                btnExport_Click(sender, e); // Export to PDF and open Print dialog
                button3_Click(sender, e);     // Export to Excel and open Print dialog
            }
        }

        private void gv_Attlog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
