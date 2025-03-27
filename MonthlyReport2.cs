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
using System.IO;
using System.Data.SQLite;
using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;
using System.Drawing.Printing;


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
        private void btnFromToDate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int idwYear = 2080;
            //    int idwMonth = 1;
            //    int idwDay = 1;
            //    int idwYear2 = 2080;
            //    int idwMonth2 = 12;
            //    int idwDay2 = 31;

            //    if (comboBox1.SelectedItem != null && int.TryParse(comboBox1.SelectedItem.ToString(), out int selectedYear))
            //    {
            //        idwYear = selectedYear;
            //    }

            //    if (comboBox2.SelectedItem != null && int.TryParse(comboBox2.SelectedItem.ToString(), out int selectedMonth))
            //    {
            //        idwMonth = selectedMonth;
            //    }

            //    if (comboBox3.SelectedItem != null && int.TryParse(comboBox3.SelectedItem.ToString(), out int selectedDate))
            //    {
            //        idwDay = selectedDate;
            //    }

            //    if (comboBox6.SelectedItem != null && int.TryParse(comboBox6.SelectedItem.ToString(), out int selectedYear2))
            //    {
            //        idwYear2 = selectedYear2;
            //    }

            //    if (comboBox5.SelectedItem != null && int.TryParse(comboBox5.SelectedItem.ToString(), out int selectedMonth2))
            //    {
            //        idwMonth2 = selectedMonth2;
            //    }

            //    if (comboBox4.SelectedItem != null && int.TryParse(comboBox4.SelectedItem.ToString(), out int selectedDate2))
            //    {
            //        idwDay2 = selectedDate2;
            //    }

            //    DateConverter englishDateFrom;
            //    DateConverter englishDateTo;
            //    string fromDate = string.Empty; // Initialize with default value
            //    string toDate = string.Empty; // Initialize with default value

            //    if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null &&
            //        comboBox6.SelectedItem != null && comboBox5.SelectedItem != null && comboBox4.SelectedItem != null) // Year, Month, and Day selected
            //    {
            //        englishDateFrom = DateConverter.ConvertToEnglish(idwYear, idwMonth, idwDay);
            //        englishDateTo = DateConverter.ConvertToEnglish(idwYear2, idwMonth2, idwDay2);

            //        fromDate = $"{englishDateFrom.Year}-{englishDateFrom.Month:D2}-{englishDateFrom.Day:D2} 00:00:00";
            //        toDate = $"{englishDateTo.Year}-{englishDateTo.Month:D2}-{englishDateTo.Day:D2} 23:59:59";
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please select valid dates from the combo boxes.");
            //        return;
            //    }

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

            //    MonthlyReport.SDK.sta_readLogByPeriod(MonthlyReport.lbSysOutputInfo, dt_periodLog, fromDate, toDate);

            //    DataTable finalTable = dt_periodLog.Clone();
            //    if (!string.IsNullOrEmpty(txtBoxName.Text))
            //    {
            //        string selectedUserName = txtBoxName.Text;
            //        DataRow[] filteredRows = dt_periodLog.Select($"[User Name] = '{selectedUserName}'");

            //        foreach (DataRow row in filteredRows)
            //        {
            //            finalTable.ImportRow(row);
            //        }

            //        string previousDate = string.Empty;
            //        foreach (DataRow row in finalTable.Rows.Cast<DataRow>().ToList())
            //        {
            //            string currentDate = DateTime.Parse(row["Verify Date"].ToString()).ToString("yyyy-MM-dd");

            //            if (currentDate == previousDate)
            //            {
            //                finalTable.Rows.Remove(row);
            //            }
            //            previousDate = currentDate;
            //        }
            //    }
            //    else
            //    {
            //        finalTable = dt_periodLog.Copy();
            //    }

            //    finalTable.AcceptChanges();
            //    gv_Attlog.DataSource = finalTable;

            //    DeleteDataFromDatabase();
            //    InsertDataIntoDatabase(finalTable);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred: " + ex.Message);
            //}
        }

        private void btnFilter_Click_2(object sender, EventArgs e)
        {
            try
            {
                int idwYear = 2080;
                int idwMonth = 1;
                int idwDay = 1;

                // Fetch selected year, month, and day from combo boxes
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

                // Convert Nepali date to English date
                DateConverter englishDateFrom;
                DateConverter englishDateTo;
                string fromDate = string.Empty;
                string toDate = string.Empty;

                if (comboBox1Date.SelectedItem != null && comboBoxMonth.SelectedItem != null && comboBoxYear.SelectedItem != null) // Year, Month, and Day selected
                {
                    englishDateFrom = DateConverter.ConvertToEnglish(idwYear, idwMonth, idwDay);
                    englishDateTo = DateConverter.ConvertToEnglish(idwYear, idwMonth, idwDay);
                }
                else if (comboBoxMonth.SelectedItem != null && comboBoxYear.SelectedItem != null) // Year and Month selected
                {
                    englishDateFrom = DateConverter.ConvertToEnglish(idwYear, idwMonth, 1);
                    englishDateTo = DateConverter.ConvertToEnglish(idwYear, idwMonth, DateTime.DaysInMonth(idwYear, idwMonth));
                }
                else if (comboBoxYear.SelectedItem != null) // Only Year selected
                {
                    englishDateFrom = DateConverter.ConvertToEnglish(idwYear, 1, 1);
                    englishDateTo = DateConverter.ConvertToEnglish(idwYear, 12, 31);
                }
                else
                {
                    englishDateFrom = DateConverter.ConvertToEnglish(idwYear, idwMonth, idwDay);
                    englishDateTo = DateConverter.ConvertToEnglish(idwYear, idwMonth, idwDay);
                }

                // Format date range
                fromDate = $"{englishDateFrom.Year:0000}-{englishDateFrom.Month:00}-{englishDateFrom.Day:00} 00:00:00";
                toDate = $"{englishDateTo.Year:0000}-{englishDateTo.Month:00}-{englishDateTo.Day:00} 23:59:59";

                // Fetch data from SDK
                DataTable dt_periodLog = new DataTable("dt_periodLog");
                gv_Attlog.Columns.Clear();
                dt_periodLog.Columns.Add("Organization_ID", typeof(int));
                dt_periodLog.Columns.Add("User ID", typeof(string));
                dt_periodLog.Columns.Add("User Name", typeof(string));
                dt_periodLog.Columns.Add("Verify Date", typeof(string));
                dt_periodLog.Columns.Add("Nepali Verify Date", typeof(string));
                dt_periodLog.Columns.Add("Verify Type", typeof(int));
                dt_periodLog.Columns.Add("Verify State", typeof(int));
                dt_periodLog.Columns.Add("WorkCode", typeof(int));
                dt_periodLog.Columns.Add("Time In", typeof(string));
                dt_periodLog.Columns.Add("Time Out", typeof(string));
                dt_periodLog.Columns.Add("Status", typeof(string));

                if (!string.IsNullOrEmpty(fromDate) && !string.IsNullOrEmpty(toDate))
                {
                    MonthlyReport.SDK.sta_readLogByPeriod(MonthlyReport.lbSysOutputInfo, dt_periodLog, fromDate, toDate);
                }
                else
                {
                    MessageBox.Show("Please select valid dates from the combo boxes.");
                    return;
                }

                // Create final filtered table
                DataTable finalTable = dt_periodLog.Clone();

                // Filter by username if provided
                if (!string.IsNullOrEmpty(txtBoxName.Text))
                {
                    string selectedUserName = txtBoxName.Text;
                    DataRow[] filteredRows = dt_periodLog.Select($"[User Name] = '{selectedUserName}'");

                    foreach (DataRow row in filteredRows)
                    {
                        finalTable.ImportRow(row);
                    }
                }
                else
                {
                    finalTable = dt_periodLog.Copy();
                }

                // Remove duplicate rows based on User ID and Verify Date
                HashSet<string> uniqueCombinations = new HashSet<string>();
                List<DataRow> rowsToDelete = new List<DataRow>();

                foreach (DataRow row in finalTable.Rows)
                {
                    string userId = row["User ID"].ToString();
                    string verifyDate = row["Verify Date"].ToString();

                    // Ensure valid date parsing
                    if (DateTime.TryParse(verifyDate, out DateTime currentDateTime))
                    {
                        string currentDate = currentDateTime.ToString("yyyy-MM-dd");
                        string combination = $"{userId}_{currentDate}";

                        if (uniqueCombinations.Contains(combination))
                        {
                            rowsToDelete.Add(row);
                        }
                        else
                        {
                            uniqueCombinations.Add(combination);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid date format found: {verifyDate}");
                    }
                }

                // Remove duplicate rows
                foreach (DataRow row in rowsToDelete)
                {
                    finalTable.Rows.Remove(row);
                }
                finalTable.AcceptChanges();

                // Display filtered data
                gv_Attlog.DataSource = finalTable;

                // Save data if records exist
                if (finalTable.Rows.Count > 0)
                {
                    DeleteDataFromDatabase();
                    InsertDataIntoDatabase(finalTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private RDLC rdlcForm;

        private void btnExport_Click_1(object sender, EventArgs e)
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
                            string headingText1 = label2.Text;
                            string headingText = comboBoxYear.Text;
                            string headingText2 = label3.Text;
                            string headingText3 = comboBoxMonth.Text;
                            string headingText4 = label4.Text;
                            string headingText5 = comboBox1Date.Text;
                            string headingText6 = label6.Text;
                            string headingText7 = txtBoxName.Text;

                            // Create a table with 2 columns for the headings
                            PdfPTable headingTable = new PdfPTable(2);
                            headingTable.WidthPercentage = 100; // Make the table fill the width of the page

                            // First heading (left side)
                            string combinedHeading = $"{headingText1}: {headingText}  \n \n {headingText2}: {headingText3}";
                            var headingFont = iTextSharp.text.FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                            PdfPCell leftCell = new PdfPCell(new Phrase(combinedHeading, headingFont))
                            {
                                HorizontalAlignment = Element.ALIGN_LEFT,
                                Border = PdfPCell.NO_BORDER // No border for a cleaner look
                            };

                            // Second heading (right side)
                            string combinedHeading2 = $"{headingText4}: {headingText5} \n \n {headingText6}: {headingText7}";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                // Calculate the date range: last 365 days from the current date
                DateTime current = DateTime.Now; // Current date and time
                DateTime from = current.AddDays(-365); // Subtract 365 days from the current date

                // Format the dates as strings
                string fromDate = from.ToString("yyyy-MM-dd 00:00:00");
                string toDate = current.ToString("yyyy-MM-dd 23:59:59");

                // Create a DataTable to store the logs
                DataTable dt_periodLog = new DataTable("dt_periodLog");
                gv_Attlog.AutoGenerateColumns = true;
                gv_Attlog.Columns.Clear();

                // Define columns for the DataTable
                dt_periodLog.Columns.Add("Organization_ID", typeof(int));
                dt_periodLog.Columns.Add("User ID", typeof(string));
                dt_periodLog.Columns.Add("User Name", typeof(string));
                dt_periodLog.Columns.Add("Nepali Verify Date", typeof(string));
                dt_periodLog.Columns.Add("Verify Date", typeof(string));
                dt_periodLog.Columns.Add("Verify Type", typeof(int));
                dt_periodLog.Columns.Add("Verify State", typeof(int));
                dt_periodLog.Columns.Add("WorkCode", typeof(int));
                dt_periodLog.Columns.Add("Time In", typeof(string));
                dt_periodLog.Columns.Add("Time Out", typeof(string));
                dt_periodLog.Columns.Add("Status", typeof(string));

                // Set the DataTable as the data source for the grid view
               
                // Fetch data from the SDK using the calculated date range
                MonthlyReport.SDK.sta_readAttLog(MonthlyReport.lbSysOutputInfo, dt_periodLog);
               
         

                // Display filtered data
                gv_Attlog.DataSource = dt_periodLog;

                DeleteDataFromDatabase();
                InsertDataIntoDatabase(dt_periodLog);
                // Save data if records exist
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void MonthlyReport2_Load(object sender, EventArgs e)
        {

        }

        private void gv_Attlog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Set this to Commercial if applicable

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";
                saveFileDialog.FileName = "EmployeeData.xlsx";

                // Show the dialog and check if the user clicked the save button
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Create a new Excel package
                        using (var package = new ExcelPackage())
                        {
                            // Create a new worksheet
                            var worksheet = package.Workbook.Worksheets.Add("Employee Data");

                            // Prepare heading texts
                            string headingText1 = label2.Text;
                            string headingText = comboBoxYear.Text;
                            string headingText2 = label3.Text;
                            string headingText3 = comboBoxMonth.Text;
                            string headingText4 = label4.Text;
                            string headingText5 = comboBox1Date.Text;
                            string headingText6 = label6.Text;
                            string headingText7 = txtBoxName.Text;

                            // Write headings to the Excel sheet
                            worksheet.Cells[1, 1].Value = $"{headingText1}: {headingText}";
                            worksheet.Cells[2, 1].Value = $"{headingText2}: {headingText3}";
                            worksheet.Cells[1, 3].Value = $"{headingText4}: {headingText5}";
                            worksheet.Cells[2, 3].Value = $"{headingText6}: {headingText7}";


                            var headingFont = worksheet.Cells[1, 1, 2, 3].Style;
                            headingFont.Font.Size = 14; // Set font size (increase as needed)
                            headingFont.Font.Bold = true; // Make it bold

                            // Add a blank line for spacing
                            worksheet.Cells[4, 1].Value = "";

                            // Add headers to the Excel sheet
                            for (int i = 0; i < gv_Attlog.Columns.Count; i++)
                            {
                                worksheet.Cells[5, i + 1].Value = gv_Attlog.Columns[i].HeaderText;
                                worksheet.Cells[5, i + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                                worksheet.Cells[5, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                worksheet.Cells[5, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray); // Light Gray Background
                            }

                            // Add data from DataGridView to the Excel sheet
                            for (int i = 0; i < gv_Attlog.Rows.Count; i++)
                            {
                                for (int j = 0; j < gv_Attlog.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 6, j + 1].Value = gv_Attlog.Rows[i].Cells[j].Value?.ToString();
                                    worksheet.Cells[i + 6, j + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                                }
                            }

                            // Auto fit columns
                            worksheet.Cells.AutoFitColumns();

                            // Save the Excel file
                            package.SaveAs(new FileInfo(saveFileDialog.FileName));
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
                btnExport_Click_1(sender, e); // Export to PDF and open Print dialog
                button3_Click(sender, e);     // Export to Excel and open Print dialog
            }
        }
    }
}

