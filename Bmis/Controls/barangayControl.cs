using Bmis.Forms;
using Bmis.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace Bmis.Controls
{
    public partial class barangayControl : UserControl
    {
        private DatabaseHelper db = new DatabaseHelper();

        public barangayControl()
        {
            InitializeComponent();
            searchProfile.SetPlaceholder("Search for profile.....");
            LoadResidentList();
            dgvResidents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResidents.MultiSelect = false;
        }

        private void LoadResidentList()
        {
            try
            {
                string query = "SELECT id, full_name, age, purok FROM residents";
                dgvResidents.DataSource = db.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("List Loading Error: " + ex.Message);
            }
        }

        private void searchProfile_TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT id, full_name, age, purok FROM residents WHERE full_name LIKE '%{searchProfile.Text}%'";
            dgvResidents.DataSource = db.ExecuteQuery(query);
        }

        private void generateClearanceBtn_Click(object sender, EventArgs e)
        {
            // CurrentRow works even if you just clicked a single cell
            if (dgvResidents.CurrentRow != null && dgvResidents.CurrentRow.Index >= 0)
            {
                try
                {
                    // Get the ID from the currently active row
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