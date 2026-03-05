using System.Drawing;
using System.Windows.Forms;

namespace Bmis.Forms
{
    partial class AddResidentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddResidentForm));
            topPanel = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            btnBrowse = new Label();
            residentPic = new PictureBox();
            panel4 = new Panel();
            txtFullName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            txtAge = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            txtPurok = new TextBox();
            btnSave = new Button();
            panel2 = new Panel();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)residentPic).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = SystemColors.GradientInactiveCaption;
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(label1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(887, 37);
            topPanel.TabIndex = 0;
            topPanel.MouseDown += topPanel_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(844, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 1;
            label1.Text = "Add new resident";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 223);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnBrowse);
            panel3.Controls.Add(residentPic);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 223);
            panel3.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.None;
            btnBrowse.AutoSize = true;
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnBrowse.ForeColor = Color.FromArgb(0, 0, 192);
            btnBrowse.Location = new Point(90, 189);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(58, 20);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Upload";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // residentPic
            // 
            residentPic.Dock = DockStyle.Top;
            residentPic.Location = new Point(0, 0);
            residentPic.Name = "residentPic";
            residentPic.Size = new Size(234, 186);
            residentPic.TabIndex = 0;
            residentPic.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtFullName);
            panel4.Location = new Point(33, 320);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(272, 49);
            panel4.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Cursor = Cursors.IBeam;
            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(10, 10);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 21);
            txtFullName.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 283);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 3;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 391);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "Age";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtAge);
            panel5.Location = new Point(33, 428);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(272, 49);
            panel5.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Cursor = Cursors.IBeam;
            txtAge.Dock = DockStyle.Fill;
            txtAge.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(10, 10);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(250, 21);
            txtAge.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 503);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 7;
            label5.Text = "Purok";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(txtPurok);
            panel6.Location = new Point(33, 540);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10);
            panel6.Size = new Size(272, 49);
            panel6.TabIndex = 6;
            // 
            // txtPurok
            // 
            txtPurok.BackColor = Color.White;
            txtPurok.BorderStyle = BorderStyle.None;
            txtPurok.Cursor = Cursors.IBeam;
            txtPurok.Dock = DockStyle.Fill;
            txtPurok.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPurok.Location = new Point(10, 10);
            txtPurok.Name = "txtPurok";
            txtPurok.Size = new Size(250, 21);
            txtPurok.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 192, 192);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(807, 632);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(69, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(topPanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 674);
            panel2.TabIndex = 9;
            // 
            // AddResidentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 674);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddResidentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddResidentForm";
            Load += AddResidentForm_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)residentPic).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private PictureBox residentPic;
        private Label btnBrowse;
        private Panel panel4;
        private TextBox txtFullName;
        private Label label3;
        private Label label4;
        private Panel panel5;
        private TextBox txtAge;
        private Label label5;
        private Panel panel6;
        private TextBox txtPurok;
        private Button btnSave;
        private Panel panel2;
    }
}