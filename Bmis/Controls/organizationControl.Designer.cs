using System.Drawing;
using System.Windows.Forms;

namespace Bmis.Controls
{
    partial class organizationControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "organizationControl";
            this.Size = new System.Drawing.Size(1026, 679);

            this.ResumeLayout(false);
        }
    }
}