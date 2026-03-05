using System.Drawing;
using System.Windows.Forms;

namespace Bmis.Forms
{
    partial class EditName
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
            panel1 = new Panel();
            label1 = new Label();
            editNameBtn = new Button();
            barangayInput = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 0;
            label1.Text = "EDIT BARANGAY NAME";
            // 
            // editNameBtn
            // 
            editNameBtn.Anchor = AnchorStyles.None;
            editNameBtn.Cursor = Cursors.Hand;
            editNameBtn.Location = new Point(174, 133);
            editNameBtn.Name = "editNameBtn";
            editNameBtn.Size = new Size(72, 34);
            editNameBtn.TabIndex = 2;
            editNameBtn.Text = "SAVE";
            editNameBtn.UseVisualStyleBackColor = true;
            editNameBtn.Click += editNameBtn_Click;
            // 
            // barangayInput
            // 
            barangayInput.Anchor = AnchorStyles.None;
            barangayInput.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barangayInput.Location = new Point(68, 79);
            barangayInput.Name = "barangayInput";
            barangayInput.Size = new Size(286, 31);
            barangayInput.TabIndex = 1;
            // 
            // EditName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(406, 191);
            Controls.Add(barangayInput);
            Controls.Add(editNameBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(424, 238);
            Name = "EditName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Barangay Name";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button editNameBtn;
        private TextBox barangayInput;
    }
}