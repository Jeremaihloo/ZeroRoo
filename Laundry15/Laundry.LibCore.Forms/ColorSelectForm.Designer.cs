namespace Laundry.LibCore.Forms
{
    partial class ColorSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorSelectForm));
            this.SuspendLayout();
            // 
            // ColorSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 523);
            //this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("ColorSelectForm.CloseBox.HoverImage")));
            //this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("ColorSelectForm.CloseBox.NormalImage")));
            //this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("ColorSelectForm.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(25, 26);
            //this.MaxBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("ColorSelectForm.MaxBox.HoverImage")));
            //this.MaxBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("ColorSelectForm.MaxBox.NormalImage")));
            //this.MaxBox.PressImage = ((System.Drawing.Image)(resources.GetObject("ColorSelectForm.MaxBox.PressImage")));
            //this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("ColorSelectForm.MinBox.HoverImage")));
            //this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("ColorSelectForm.MinBox.NormalImage")));
            //this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("ColorSelectForm.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(25, 26);
            this.Name = "ColorSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择颜色";
            this.Load += new System.EventHandler(this.ColorSelectForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}