using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bmis.Classes;

namespace Bmis.Forms
{
    public partial class EditPicture : Form
    {
        public Image SelectedImage { get; private set; }

        public EditPicture()
        {
            InitializeComponent();
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    uploadPicture.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (uploadPicture.Image == null) return;

            try
            {
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    uploadPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }

                DatabaseHelper db = new DatabaseHelper();
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE system_settings SET setting_value = @img WHERE setting_name = 'sidebar_logo'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@img", imageBytes);
                    cmd.ExecuteNonQuery();
                }

                this.SelectedImage = uploadPicture.Image;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}