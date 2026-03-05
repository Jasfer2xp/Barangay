using Bmis.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bmis  .Controls
{
    public partial class dashboardControl : UserControl
    {
        public dashboardControl()
        {
            InitializeComponent();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            using (EditName editNameForm = new EditName(barangayName.Text))
            {
                if (editNameForm.ShowDialog() == DialogResult.OK)
                {
                    barangayName.Text = editNameForm.UpdateName;
                }
            }
        }
    }
}
