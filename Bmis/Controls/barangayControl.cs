using Bmis.Forms;
using Bmis.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Bmis.Controls
{
    public partial class barangayControl : UserControl
    {
        private DatabaseHelper db = new DatabaseHelper();
        private ApiService api = new ApiService();

        public barangayControl()
        {
            InitializeComponent();
            searchProfile.SetPlaceholder("Search for profile.....");
            LoadResidentList();
            dgvResidents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResidents.MultiSelect = false;
        }

        private async void LoadResidentList()
        {
            try
            {
                DataTable localData = db.ExecuteQuery("SELECT id, full_name, age, purok FROM residents");

                DataTable liveData = await api.GetEmployeeData("employee-details");

                if (liveData != null)
                {
                    localData.Merge(liveData);
                }

                dgvResidents.DataSource = localData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("List Loading Error: " + ex.Message);
            }
        }

        private async void searchProfile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = searchProfile.Text;

                string localQuery = "SELECT id, full_name, age, purok FROM residents WHERE full_name LIKE @name";
                MySqlParameter[] param = { new MySqlParameter("@name", "%" + searchText + "%") };
                DataTable localData = db.ExecuteQuery(localQuery, param);

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    LoadResidentList();
                    return;
                }

                dgvResidents.DataSource = localData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        private void generateClearanceBtn_Click(object sender, EventArgs e)
        {
            if (dgvResidents.CurrentRow != null && dgvResidents.CurrentRow.Index >= 0)
            {
                try
                {
                    int id = Convert.ToInt32(dgvResidents.CurrentRow.Cells["id"].Value);
                    ReportForm reportWindow = new ReportForm(id);
                    reportWindow.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating report: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a resident from the list first.");
            }
        }

        private void addResidentBtn_Click(object sender, EventArgs e)
        {
            using (AddResidentForm addForm = new AddResidentForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadResidentList();
                }
            }
        }
    }
}