using System.Drawing;
using System.Windows.Forms;

namespace Bmis.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editPic = new System.Windows.Forms.Label();
            this.barangayPicture = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.recordsBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.barangayBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.blotterBtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.officialBtn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.organizeBtn = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.reportBtn = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.settingBtn = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.userBtn = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.purokBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.officialMembersBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangayPicture)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(181)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.panel16);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 40);
            this.panel2.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label1);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(915, 40);
            this.panel16.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barangay Management Information System\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(915, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(193, 40);
            this.panel15.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1108, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 40);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.editPic);
            this.panel3.Controls.Add(this.barangayPicture);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 139);
            this.panel3.TabIndex = 0;
            // 
            // editPic
            // 
            this.editPic.AutoSize = true;
            this.editPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPic.ForeColor = System.Drawing.SystemColors.Highlight;
            this.editPic.Location = new System.Drawing.Point(211, 113);
            this.editPic.Name = "editPic";
            this.editPic.Size = new System.Drawing.Size(35, 20);
            this.editPic.TabIndex = 0;
            this.editPic.Text = "Edit";
            this.editPic.Click += new System.EventHandler(this.editPic_Click);
            // 
            // barangayPicture
            // 
            this.barangayPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barangayPicture.Image = ((System.Drawing.Image)(resources.GetObject("barangayPicture.Image")));
            this.barangayPicture.Location = new System.Drawing.Point(0, 0);
            this.barangayPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barangayPicture.Name = "barangayPicture";
            this.barangayPicture.Size = new System.Drawing.Size(267, 139);
            this.barangayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.barangayPicture.TabIndex = 0;
            this.barangayPicture.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.Controls.Add(this.panel11);
            this.flowLayoutPanel1.Controls.Add(this.panel12);
            this.flowLayoutPanel1.Controls.Add(this.panel13);
            this.flowLayoutPanel1.Controls.Add(this.officialMembersBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 804);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dashboardBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 145);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 52);
            this.panel4.TabIndex = 1;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Arial", 9F);
            this.dashboardBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(289, 52);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "     Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.recordsBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 201);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(289, 52);
            this.panel5.TabIndex = 2;
            // 
            // recordsBtn
            // 
            this.recordsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordsBtn.FlatAppearance.BorderSize = 0;
            this.recordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordsBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recordsBtn.Image = ((System.Drawing.Image)(resources.GetObject("recordsBtn.Image")));
            this.recordsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordsBtn.Location = new System.Drawing.Point(0, 0);
            this.recordsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordsBtn.Name = "recordsBtn";
            this.recordsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.recordsBtn.Size = new System.Drawing.Size(289, 52);
            this.recordsBtn.TabIndex = 0;
            this.recordsBtn.Text = "     Resident Records";
            this.recordsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recordsBtn.UseVisualStyleBackColor = true;
            this.recordsBtn.Click += new System.EventHandler(this.recordsBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.barangayBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 257);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(289, 52);
            this.panel6.TabIndex = 3;
            // 
            // barangayBtn
            // 
            this.barangayBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barangayBtn.FlatAppearance.BorderSize = 0;
            this.barangayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barangayBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barangayBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.barangayBtn.Image = ((System.Drawing.Image)(resources.GetObject("barangayBtn.Image")));
            this.barangayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.barangayBtn.Location = new System.Drawing.Point(0, 0);
            this.barangayBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barangayBtn.Name = "barangayBtn";
            this.barangayBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.barangayBtn.Size = new System.Drawing.Size(289, 52);
            this.barangayBtn.TabIndex = 0;
            this.barangayBtn.Text = "     Barangay Clearance";
            this.barangayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.barangayBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.barangayBtn.UseVisualStyleBackColor = true;
            this.barangayBtn.Click += new System.EventHandler(this.barangayBtn_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.blotterBtn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 313);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(289, 52);
            this.panel7.TabIndex = 4;
            // 
            // blotterBtn
            // 
            this.blotterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blotterBtn.FlatAppearance.BorderSize = 0;
            this.blotterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blotterBtn.Font = new System.Drawing.Font("Arial", 9F);
            this.blotterBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.blotterBtn.Image = ((System.Drawing.Image)(resources.GetObject("blotterBtn.Image")));
            this.blotterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blotterBtn.Location = new System.Drawing.Point(0, 0);
            this.blotterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blotterBtn.Name = "blotterBtn";
            this.blotterBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.blotterBtn.Size = new System.Drawing.Size(289, 52);
            this.blotterBtn.TabIndex = 0;
            this.blotterBtn.Text = "     Blotter Records";
            this.blotterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blotterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.blotterBtn.UseVisualStyleBackColor = true;
            this.blotterBtn.Click += new System.EventHandler(this.blotterBtn_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.officialBtn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 369);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(289, 52);
            this.panel8.TabIndex = 5;
            // 
            // officialBtn
            // 
            this.officialBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.officialBtn.FlatAppearance.BorderSize = 0;
            this.officialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.officialBtn.Font = new System.Drawing.Font("Arial", 9F);
            this.officialBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.officialBtn.Image = ((System.Drawing.Image)(resources.GetObject("officialBtn.Image")));
            this.officialBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.officialBtn.Location = new System.Drawing.Point(0, 0);
            this.officialBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.officialBtn.Name = "officialBtn";
            this.officialBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.officialBtn.Size = new System.Drawing.Size(289, 52);
            this.officialBtn.TabIndex = 0;
            this.officialBtn.Text = "     Official List";
            this.officialBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.officialBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.officialBtn.UseVisualStyleBackColor = true;
            this.officialBtn.Click += new System.EventHandler(this.officialBtn_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.organizeBtn);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 425);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(289, 52);
            this.panel9.TabIndex = 6;
            // 
            // organizeBtn
            // 
            this.organizeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.organizeBtn.FlatAppearance.BorderSize = 0;
            this.organizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.organizeBtn.Font = new System.Drawing.Font("Arial", 9F);
            this.organizeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.organizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("organizeBtn.Image")));
            this.organizeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.organizeBtn.Location = new System.Drawing.Point(0, 0);
            this.organizeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.organizeBtn.Name = "organizeBtn";
            this.organizeBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.organizeBtn.Size = new System.Drawing.Size(289, 52);
            this.organizeBtn.TabIndex = 0;
            this.organizeBtn.Text = "     Organizational";
            this.organizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.organizeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.organizeBtn.UseVisualStyleBackColor = true;
            this.organizeBtn.Click += new System.EventHandler(this.organizeBtn_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.reportBtn);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 481);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(289, 52);
            this.panel10.TabIndex = 7;
            // 
            // reportBtn
            // 
            this.reportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("Arial", 9F);
            this.reportBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportBtn.Image = ((System.Drawing.Image)(resources.GetObject("reportBtn.Image")));
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.Location = new System.Drawing.Point(0, 0);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.reportBtn.Size = new System.Drawing.Size(289, 52);
            this.reportBtn.TabIndex = 0;
            this.reportBtn.Text = "     Reports";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.settingBtn);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(3, 537);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(289, 52);
            this.panel11.TabIndex = 8;
            // 
            // settingBtn
            // 
            this.settingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Arial", 9F);
            this.settingBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingBtn.Image")));
            this.settingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingBtn.Location = new System.Drawing.Point(0, 0);
            this.settingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.settingBtn.Size = new System.Drawing.Size(289, 52);
            this.settingBtn.TabIndex = 0;
            this.settingBtn.Text = "     Settings";
            this.settingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.userBtn);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(3, 593);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(289, 52);
            this.panel12.TabIndex = 9;
            // 
            // userBtn
            // 
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBtn.FlatAppearance.BorderSize = 0;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Arial", 9F);
            this.userBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userBtn.Image = ((System.Drawing.Image)(resources.GetObject("userBtn.Image")));
            this.userBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.Location = new System.Drawing.Point(0, 0);
            this.userBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userBtn.Name = "userBtn";
            this.userBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.userBtn.Size = new System.Drawing.Size(289, 52);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "     User Trails";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.purokBtn);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(3, 649);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(289, 52);
            this.panel13.TabIndex = 10;
            // 
            // purokBtn
            // 
            this.purokBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purokBtn.FlatAppearance.BorderSize = 0;
            this.purokBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purokBtn.Font = new System.Drawing.Font("Arial", 9F);
            this.purokBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.purokBtn.Image = ((System.Drawing.Image)(resources.GetObject("purokBtn.Image")));
            this.purokBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purokBtn.Location = new System.Drawing.Point(0, 0);
            this.purokBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purokBtn.Name = "purokBtn";
            this.purokBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.purokBtn.Size = new System.Drawing.Size(289, 52);
            this.purokBtn.TabIndex = 0;
            this.purokBtn.Text = "     Purok";
            this.purokBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purokBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.purokBtn.UseVisualStyleBackColor = true;
            this.purokBtn.Click += new System.EventHandler(this.purokBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(270, 40);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(884, 804);
            this.mainPanel.TabIndex = 3;
            // 
            // officialMembersBtn
            // 
            this.officialMembersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.officialMembersBtn.FlatAppearance.BorderSize = 0;
            this.officialMembersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.officialMembersBtn.Font = new System.Drawing.Font("Arial", 9F);
            this.officialMembersBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.officialMembersBtn.Image = ((System.Drawing.Image)(resources.GetObject("officialMembersBtn.Image")));
            this.officialMembersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.officialMembersBtn.Location = new System.Drawing.Point(3, 706);
            this.officialMembersBtn.Name = "officialMembersBtn";
            this.officialMembersBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.officialMembersBtn.Size = new System.Drawing.Size(289, 52);
            this.officialMembersBtn.TabIndex = 11;
            this.officialMembersBtn.Text = "     Officials";
            this.officialMembersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.officialMembersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.officialMembersBtn.UseVisualStyleBackColor = true;
            this.officialMembersBtn.Click += new System.EventHandler(this.officialMembersBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 844);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel2.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangayPicture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox barangayPicture;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Button dashboardBtn;
        private Panel panel5;
        private Button recordsBtn;
        private Panel panel6;
        private Button barangayBtn;
        private Panel panel7;
        private Button blotterBtn;
        private Panel panel8;
        private Button officialBtn;
        private Panel panel9;
        private Button organizeBtn;
        private Panel panel10;
        private Button reportBtn;
        private Panel panel11;
        private Button settingBtn;
        private Panel panel12;
        private Button userBtn;
        private Panel panel13;
        private Button purokBtn;
        private Panel panel16;
        private Label label1;
        private Panel panel15;
        private Panel mainPanel;
        private Label editPic;
        private Button officialMembersBtn;
    }
}