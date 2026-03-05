using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Bmis.Classes;

namespace Bmis.Forms
{
    public partial class ReportForm : Form
    {
        // Manually defining the viewer to bypass the "can't drag" issue
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DatabaseHelper db = new DatabaseHelper();
        private int _residentId;

        public ReportForm(int residentId)
        {
            InitializeComponent();
            this._residentId = residentId;

            // This forces the viewer to appear on your form
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(this.reportViewer1);
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Pulling the three tables you created
                DataTable resDt = db.ExecuteQuery($"SELECT * FROM residents WHERE id = {_residentId}");
                DataTable offDt = db.ExecuteQuery("SELECT * FROM officials WHERE is_active = 1 ORDER BY rank_order ASC");
                DataTable setDt = db.ExecuteQuery("SELECT * FROM system_settings");

                reportViewer1.LocalReport.DataSources.Clear();

                // IMPORTANT: These names ("ResidentDS") must match the Dataset names in your RDLC
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ResidentDS", resDt));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("OfficialsDS", offDt));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("SettingsDS", setDt));

                // Path to your template
                this.reportViewer1.LocalReport.ReportPath = "BarangayClearance.rdlc";

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Report Error: " + ex.Message);
            }
        }
    }
}