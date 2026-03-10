using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using Bmis.Classes;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Bmis.Forms
{
    public partial class AddResidentForm : Form
    {
        private Bmis.Classes.DatabaseHelper db = new Bmis.Classes.DatabaseHelper();

        public AddResidentForm()
        {
            InitializeComponent();
        }

        #region UI Dragging Logic
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Please enter a name.");
                    return;
                }

                byte[] imgData = null;
                if (residentPic.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        residentPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        imgData = ms.ToArray();
                    }
                }

                string sql = "INSERT INTO residents (full_name, age, purok, resident_image) VALUES (@name, @age, @purok, @img)";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@name", txtFullName.Text),
                    new MySqlParameter("@age", txtAge.Text),
                    new MySqlParameter("@purok", txtPurok.Text),
                    new MySqlParameter("@img", imgData)
                };

                if (db.ExecuteNonQuery(sql, parameters))
                {
                    MessageBox.Show("Resident Added Locally!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    residentPic.Image = Image.FromFile(ofd.FileName);
                    residentPic.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }
}