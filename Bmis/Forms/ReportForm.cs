using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Bmis.Classes;
using System.Threading.Tasks;

namespace Bmis.Forms
{
    public partial class ReportForm : Form
    {
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ApiService _api = new ApiService();
        private int _residentId;

        public ReportForm(int residentId)
        {
            InitializeComponent();
            this._residentId = residentId;

            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(this.reportViewer1);
        }

        private async void ReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable resDt = await _api.GetResidentDataSmart(_residentId);

                if (resDt == null || resDt.Rows.Count == 0)
                {
                    MessageBox.Show("Resident not found in Live API or Local Database.");
                    return;
                }

                DataTable offDt = new DataTable();
                DataTable setDt = new DataTable();

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ResidentDS", resDt));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("OfficialsDS", offDt));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("SettingsDS", setDt));

                string reportPath = Path.Combine(Application.StartupPath, "BarangayClearance.rdlc");

                if (File.Exists(reportPath))
                {
                    this.reportViewer1.LocalReport.ReportPath = reportPath;
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Report file missing at: " + reportPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Report Loading Error: " + ex.Message);
            }
        }
    }
}