using System.Drawing;
using System.Windows.Forms;
using Bmis.Forms;

namespace Bmis.Controls
{
    partial class recordControl
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
            this.recordPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addProfileBtn = new System.Windows.Forms.Button();
            this.recordPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // recordPanel
            // 
            this.recordPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.recordPanel.Controls.Add(this.panel6);
            this.recordPanel.Controls.Add(this.panel2);
            this.recordPanel.Controls.Add(this.panel1);
            this.recordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordPanel.Location = new System.Drawing.Point(0, 0);
            this.recordPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordPanel.Name = "recordPanel";
            this.recordPanel.Size = new System.Drawing.Size(1245, 594);
            this.recordPanel.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 156);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1245, 438);
            this.panel6.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1245, 46);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 110);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "This panel contains residents\' profile and data\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Residents\' Records";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(399, 110);
            this.panel5.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.searchInput);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(74, 52);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 32);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // searchInput
            // 
            this.searchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchInput.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Location = new System.Drawing.Point(13, 10);
            this.searchInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(238, 22);
            this.searchInput.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.addProfileBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(857, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 110);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(220, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 110);
            this.panel4.TabIndex = 0;
            // 
            // addProfileBtn
            // 
            this.addProfileBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addProfileBtn.Location = new System.Drawing.Point(16, 54);
            this.addProfileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProfileBtn.Name = "addProfileBtn";
            this.addProfileBtn.Size = new System.Drawing.Size(188, 36);
            this.addProfileBtn.TabIndex = 1;
            this.addProfileBtn.Text = "Add Resident Profile";
            this.addProfileBtn.UseVisualStyleBackColor = true;
            // 
            // recordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.recordPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "recordControl";
            this.Size = new System.Drawing.Size(1245, 594);
            this.recordPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel recordPanel;
        private Panel panel2;
        private Panel panel1;
        private TextBox searchInput;
        private Button addProfileBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Label label1;
    }
}
