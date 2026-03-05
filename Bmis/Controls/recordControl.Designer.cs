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
            recordPanel = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            searchInput = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            addProfileBtn = new Button();
            recordPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // recordPanel
            // 
            recordPanel.BackColor = SystemColors.ControlLightLight;
            recordPanel.Controls.Add(panel6);
            recordPanel.Controls.Add(panel2);
            recordPanel.Controls.Add(panel1);
            recordPanel.Dock = DockStyle.Fill;
            recordPanel.Location = new Point(0, 0);
            recordPanel.Name = "recordPanel";
            recordPanel.Size = new Size(1245, 742);
            recordPanel.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveBorder;
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 194);
            panel6.Name = "panel6";
            panel6.Size = new Size(1245, 548);
            panel6.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(1245, 57);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Malgun Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1245, 137);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(451, 67);
            label2.Name = "label2";
            label2.Size = new Size(365, 23);
            label2.TabIndex = 6;
            label2.Text = "This panel contains residents' profile and data\r\n";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(502, 17);
            label1.Name = "label1";
            label1.Size = new Size(258, 28);
            label1.TabIndex = 5;
            label1.Text = "Residents' Records";
            // 
            // panel5
            // 
            panel5.Controls.Add(flowLayoutPanel1);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(399, 137);
            panel5.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(searchInput);
            flowLayoutPanel1.Location = new Point(74, 65);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(264, 40);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // searchInput
            // 
            searchInput.BorderStyle = BorderStyle.None;
            searchInput.Dock = DockStyle.Fill;
            searchInput.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchInput.Location = new Point(13, 13);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(238, 22);
            searchInput.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(addProfileBtn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(857, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 137);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(220, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 137);
            panel4.TabIndex = 0;
            // 
            // addProfileBtn
            // 
            addProfileBtn.Anchor = AnchorStyles.Bottom;
            addProfileBtn.Location = new Point(16, 67);
            addProfileBtn.Name = "addProfileBtn";
            addProfileBtn.Size = new Size(188, 45);
            addProfileBtn.TabIndex = 1;
            addProfileBtn.Text = "Add Resident Profile";
            addProfileBtn.UseVisualStyleBackColor = true;
            addProfileBtn.Click += addProfileBtn_Click;
            // 
            // recordControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(recordPanel);
            Name = "recordControl";
            Size = new Size(1245, 742);
            recordPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
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
