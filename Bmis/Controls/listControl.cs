using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bmis.Classes;



namespace Bmis.Controls
{
    public partial class listControl : UserControl
    {
        public listControl()
        {
            InitializeComponent();
            searchInput.SetPlaceholder("Search Name, Purok....");
            dataListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataListGrid.Columns.Add("id", "ID Number");
            dataListGrid.Columns.Add("lastName", "Last Name");
            dataListGrid.Columns.Add("firstName", "First Name");
            dataListGrid.Columns.Add("age", "Age");
            dataListGrid.Columns.Add("contact", "Contact");
            dataListGrid.Columns.Add("purok", "Purok");
            dataListGrid.Columns.Add("district", "District");

        }
    }
}
