using Bmis.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bmis.Classes;
using System.IO;

namespace Bmis.Forms
{
    public partial class Dashboard : Form
    {
        private dashboardControl dashboardControl = new dashboardControl();
        private recordControl recordControl = new recordControl();
        private barangayControl barangayControl = new barangayControl();
        private blotterControl blotterControl = new blotterControl();
        private listControl officialControl = new listControl();
        private organizationControl organizeControl = new organizationControl();
        private reportControl reportControl = new reportControl();
        private settingControl settingControl = new settingControl();
        private userControl userControl = new userControl();
        private purokControl purokControl = new purokControl();

        public Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            EnabledDoubleBuffering(mainPanel);

            dashboardControl.Dock = DockStyle.Fill;
            recordControl.Dock = DockStyle.Fill;
            barangayControl.Dock = DockStyle.Fill;
            blotterControl.Dock = DockStyle.Fill;
            officialControl.Dock = DockStyle.Fill;
            organizeControl.Dock = DockStyle.Fill;
            reportControl.Dock = DockStyle.Fill;
            settingControl.Dock = DockStyle.Fill;
            userControl.Dock = DockStyle.Fill;
            purokControl.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(dashboardControl);
        }

        private void ShowControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }

        private void EnabledDoubleBuffering(Panel mainPanel)
        {
            mainPanel.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(mainPanel, true, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ShowControl(dashboardControl);
        }

        private void recordsBtn_Click(object sender, EventArgs e)
        {
            ShowControl(recordControl);
        }

        private void barangayBtn_Click(object sender, EventArgs e)
        {
            ShowControl(barangayControl);
        }

        private void blotterBtn_Click(object sender, EventArgs e)
        {
            ShowControl(blotterControl);
        }

        private void officialBtn_Click(object sender, EventArgs e)
        {
            ShowControl(officialControl);
        }

        private void organizeBtn_Click(object sender, EventArgs e)
        {
            ShowControl(organizeControl);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            ShowControl(reportControl);
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            ShowControl(settingControl);
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            ShowControl(userControl);
        }

        private void purokBtn_Click(object sender, EventArgs e)
        {
            ShowControl(purokControl);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT setting_value FROM system_settings WHERE setting_name = 'sidebar_logo'";

            try
            {
                DataTable dt = db.ExecuteQuery(query);
                if (dt.Rows.Count > 0 && dt.Rows[0]["setting_value"] != DBNull.Value)
                {
                    byte[] imgData = (byte[])dt.Rows[0]["setting_value"];
                    if (imgData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imgData))
                        {
                            if (barangayPicture.Image != null) barangayPicture.Image.Dispose();
                            barangayPicture.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }

        private void editPic_Click(object sender, EventArgs e)
        {
            using (EditPicture picForm = new EditPicture())
            {
                if (picForm.ShowDialog() == DialogResult.OK)
                {
                    if (picForm.SelectedImage != null)
                    {
                        if (barangayPicture.Image != null) barangayPicture.Image.Dispose();
                        barangayPicture.Image = (Image)picForm.SelectedImage.Clone();
                    }
                }
            }
        }

    }
}