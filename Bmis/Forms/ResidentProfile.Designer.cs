using System.Drawing;
using System.Windows.Forms;

namespace Bmis.Forms
{
    partial class ResidentProfile
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
            topPanel = new Panel();
            closeBtn = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            topPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(255, 128, 0);
            topPanel.Controls.Add(closeBtn);
            topPanel.Controls.Add(label1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1195, 52);
            topPanel.TabIndex = 0;
            topPanel.MouseDown += topPanel_MouseDown_1;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Right;
            closeBtn.BackColor = Color.Red;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(1095, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(100, 52);
            closeBtn.TabIndex = 1;
            closeBtn.Text = " Close (x)";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(145, 22);
            label1.TabIndex = 0;
            label1.Text = "Add Resident";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(1195, 40);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 92);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(1195, 637);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(20, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(1155, 597);
            panel4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(panel6);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1155, 227);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = DockStyle.Left;
            this.panel6.Location = new Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new Size(307, 227);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = AnchorStyles.None;
            this.panel5.BorderStyle = BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new Point(37, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new Size(235, 168);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = DockStyle.Fill;
            this.pictureBox1.Location = new Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(233, 166);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = Cursors.Hand;
            this.label2.Font = new Font("Tahoma", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.Blue;
            this.label2.Location = new Point(126, 191);
            this.label2.Name = "label2";
            this.label2.Size = new Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upload";
            // 
            // ResidentProfile
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1195, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximumSize = new Size(1195, 729);
            this.Name = "ResidentProfile";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ResidentProfile";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button closeBtn;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Panel panel6;
    }
}