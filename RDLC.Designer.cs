namespace StandaloneSDKDemo
{
    partial class RDLC
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProjectDataSet5 = new StandaloneSDKDemo.ProjectDataSet5();
            this.LedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LedgerTableAdapter = new StandaloneSDKDemo.ProjectDataSet5TableAdapters.LedgerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LedgerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StandaloneSDKDemo.MonthlyReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1267, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProjectDataSet5
            // 
            this.ProjectDataSet5.DataSetName = "ProjectDataSet5";
            this.ProjectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LedgerBindingSource
            // 
            this.LedgerBindingSource.DataMember = "Ledger";
            this.LedgerBindingSource.DataSource = this.ProjectDataSet5;
            // 
            // LedgerTableAdapter
            // 
            this.LedgerTableAdapter.ClearBeforeFill = true;
            // 
            // RDLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 521);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RDLC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RDLC";
            this.Load += new System.EventHandler(this.RDLC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LedgerBindingSource;
        private ProjectDataSet5 ProjectDataSet5;
        private ProjectDataSet5TableAdapters.LedgerTableAdapter LedgerTableAdapter;
    }
}