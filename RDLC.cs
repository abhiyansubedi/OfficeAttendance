using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandaloneSDKDemo
{
    public partial class RDLC : Form
    {
        public RDLC()
        {
            InitializeComponent();
        }

        private void RDLC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProjectDataSet5.Ledger' table. You can move, or remove it, as needed.
            this.LedgerTableAdapter.Fill(this.ProjectDataSet5.Ledger);

            this.reportViewer1.RefreshReport();
        }

        public void SetReportParameters(string year, string id, string month, string date, string fromyear, string frommonth, string fromdate, string toyear, string tomonth, string todate)
        {
            try
            {
                // Ensure parameters are not null or empty and provide default values if necessary
                year = string.IsNullOrEmpty(year) ? "Default" : year;
                id = string.IsNullOrEmpty(id) ? "Default" : id;
                month = string.IsNullOrEmpty(month) ? "Default" : month;
                date = string.IsNullOrEmpty(date) ? "Default" : date;
                fromyear = string.IsNullOrEmpty(fromyear) ? "Default" : fromyear;
                frommonth = string.IsNullOrEmpty(frommonth) ? "Default" : frommonth;
                fromdate = string.IsNullOrEmpty(fromdate) ? "Default" : fromdate;
                toyear = string.IsNullOrEmpty(toyear) ? "Default" : toyear;
                tomonth = string.IsNullOrEmpty(tomonth) ? "Default" : tomonth;
                todate = string.IsNullOrEmpty(todate) ? "Default" : todate;

                // Create a list to hold the report parameters
                var reportParameters = new List<ReportParameter>
        {
            new ReportParameter("YearParameter", year),
            new ReportParameter("UserIDParameter", id),
            new ReportParameter("MonthParameter", month),
            new ReportParameter("DateParameter", date),
            new ReportParameter("FromYearParameter",fromyear),
            new ReportParameter("FromMonthParameter",frommonth),
            new ReportParameter("FromDateParameter",fromdate),
            new ReportParameter("ToYearParameter",toyear),
            new ReportParameter("ToMonthParameter",tomonth),
            new ReportParameter("ToDateParameter",todate),



        };

                // Set the parameters to the report
                this.reportViewer1.LocalReport.SetParameters(reportParameters);

                // Refresh the report to apply the parameters
                this.reportViewer1.RefreshReport();
            }
            catch (LocalProcessingException ex)
            {
                MessageBox.Show($"Error setting report parameters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
