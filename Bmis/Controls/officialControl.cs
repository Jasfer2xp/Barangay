using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bmis.Controls
{
    public partial class officialControl : UserControl
    {
        public officialControl()
        {
            InitializeComponent();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Forms.EditMembers editMembersForm = new Forms.EditMembers();
            editMembersForm.Show();
        }
    }
}
