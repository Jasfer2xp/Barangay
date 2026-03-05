using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bmis.Controls;
using Bmis.Forms;
using Bmis.Classes;

namespace Bmis.Controls
{
    public partial class recordControl : UserControl
    {
        public recordControl()
        {
            InitializeComponent();
            searchInput.SetPlaceholder("Search Profile Name...");
        }

        private void addProfileBtn_Click(object sender, EventArgs e)
        {
            using (ResidentProfile residentProfileForm = new ResidentProfile())
            {
                residentProfileForm.ShowDialog();
            }
        }
    }
}