using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bmis.Classes;

namespace Bmis.Forms
{
    public partial class EditName : Form
    {
        public string UpdateName { get; private set; }
        public EditName(string currentName)
        {
            InitializeComponent();
            barangayInput.Text = currentName;
            barangayInput.SetPlaceholder("Enter Barangay Name");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editNameBtn_Click(object sender, EventArgs e)
        {
            UpdateName = barangayInput.Text;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
