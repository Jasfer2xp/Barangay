using System.Drawing;
using System.Windows.Forms;


namespace Bmis.Controls
{
    partial class barangayControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.searchProfile = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.generateClearanceBtn = new System.Windows.Forms.Button();
            this.editProfileBtn = new System.Windows.Forms.Button();
            this.addResidentBtn = new System.Windows.Forms.Button();
            this.dgvResidents = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 1086);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1207, 27);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 146);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 90);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(877, 56);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(877, 92);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barangay Clearance";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.searchProfile);
            this.panel6.Location = new System.Drawing.Point(29, 38);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panel6.Size = new System.Drawing.Size(304, 32);
            this.panel6.TabIndex = 0;
            // 
            // searchProfile
            // 
            this.searchProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchProfile.Location = new System.Drawing.Point(10, 8);
            this.searchProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchProfile.Name = "searchProfile";
            this.searchProfile.Size = new System.Drawing.Size(282, 15);
            this.searchProfile.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.generateClearanceBtn);
            this.panel2.Controls.Add(this.editProfileBtn);
            this.panel2.Controls.Add(this.addResidentBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(877, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 146);
            this.panel2.TabIndex = 0;
            // 
            // generateClearanceBtn
            // 
            this.generateClearanceBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateClearanceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.generateClearanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateClearanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateClearanceBtn.Location = new System.Drawing.Point(107, 98);
            this.generateClearanceBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateClearanceBtn.Name = "generateClearanceBtn";
            this.generateClearanceBtn.Size = new System.Drawing.Size(172, 29);
            this.generateClearanceBtn.TabIndex = 2;
            this.generateClearanceBtn.Text = "Generate Clearance";
            this.generateClearanceBtn.UseVisualStyleBackColor = false;
            this.generateClearanceBtn.Click += new System.EventHandler(this.generateClearanceBtn_Click);
            // 
            // editProfileBtn
            // 
            this.editProfileBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editProfileBtn.BackColor = System.Drawing.Color.Yellow;
            this.editProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProfileBtn.Location = new System.Drawing.Point(107, 54);
            this.editProfileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editProfileBtn.Name = "editProfileBtn";
            this.editProfileBtn.Size = new System.Drawing.Size(172, 29);
            this.editProfileBtn.TabIndex = 1;
            this.editProfileBtn.Text = "Edit Profile";
            this.editProfileBtn.UseVisualStyleBackColor = false;
            // 
            // addResidentBtn
            // 
            this.addResidentBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addResidentBtn.BackColor = System.Drawing.Color.Blue;
            this.addResidentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addResidentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addResidentBtn.Location = new System.Drawing.Point(107, 10);
            this.addResidentBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addResidentBtn.Name = "addResidentBtn";
            this.addResidentBtn.Size = new System.Drawing.Size(172, 29);
            this.addResidentBtn.TabIndex = 0;
            this.addResidentBtn.Text = "Add New Resident";
            this.addResidentBtn.UseVisualStyleBackColor = false;
            this.addResidentBtn.Click += new System.EventHandler(this.addResidentBtn_Click);
            // 
            // dgvResidents
            // 
            this.dgvResidents.AllowUserToResizeColumns = false;
            this.dgvResidents.AllowUserToResizeRows = false;
            this.dgvResidents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResidents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResidents.Location = new System.Drawing.Point(0, 146);
            this.dgvResidents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResidents.Name = "dgvResidents";
            this.dgvResidents.RowHeadersWidth = 51;
            this.dgvResidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResidents.Size = new System.Drawing.Size(1207, 940);
            this.dgvResidents.TabIndex = 5;
            // 
            // barangayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvResidents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "barangayControl";
            this.Size = new System.Drawing.Size(1207, 1113);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel3;
        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private TextBox searchProfile;
        private Panel panel2;
        private Button editProfileBtn;
        private Button addResidentBtn;
        private Button generateClearanceBtn;
        private DataGridView dgvResidents;
        private Label label1;
    }
}
