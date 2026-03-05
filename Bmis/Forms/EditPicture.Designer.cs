using System.Drawing;
using System.Windows.Forms;

namespace Bmis.Forms
{
    partial class EditPicture
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
            uploadPicture = new PictureBox();
            uploadImage = new Label();
            saveBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uploadPicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(uploadPicture);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 181);
            panel1.TabIndex = 0;
            // 
            // uploadPicture
            // 
            uploadPicture.Dock = DockStyle.Fill;
            uploadPicture.Location = new Point(0, 0);
            uploadPicture.Name = "uploadPicture";
            uploadPicture.Size = new Size(324, 179);
            uploadPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            uploadPicture.TabIndex = 0;
            uploadPicture.TabStop = false;
            // 
            // uploadImage
            // 
            uploadImage.Anchor = AnchorStyles.None;
            uploadImage.AutoSize = true;
            uploadImage.Cursor = Cursors.Hand;
            uploadImage.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            uploadImage.ForeColor = SystemColors.Highlight;
            uploadImage.Location = new Point(114, 184);
            uploadImage.Name = "uploadImage";
            uploadImage.Size = new Size(104, 20);
            uploadImage.TabIndex = 1;
            uploadImage.Text = "Upload Image";
            uploadImage.Click += uploadImage_Click;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.None;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.Location = new Point(114, 227);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(104, 30);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // EditPicture
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 279);
            Controls.Add(saveBtn);
            Controls.Add(uploadImage);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditPicture";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditPicture";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uploadPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label uploadImage;
        private Button saveBtn;
        private PictureBox uploadPicture;
    }
}