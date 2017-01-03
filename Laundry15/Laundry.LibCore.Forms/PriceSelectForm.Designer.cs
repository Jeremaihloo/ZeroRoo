namespace Laundry.LibCore.Forms
{
    partial class PriceSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceSelectForm));
            this.SuspendLayout();
            // 
            // PriceSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 541);
            //this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("PriceSelectForm.CloseBox.HoverImage")));
            //this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("PriceSelectForm.CloseBox.NormalImage")));
            //this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("PriceSelectForm.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(25, 26);
            //this.MaxBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("PriceSelectForm.MaxBox.HoverImage")));
            //this.MaxBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("PriceSelectForm.MaxBox.NormalImage")));
            //this.MaxBox.PressImage = ((System.Drawing.Image)(resources.GetObject("PriceSelectForm.MaxBox.PressImage")));
            //this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("PriceSelectForm.MinBox.HoverImage")));
            //this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("PriceSelectForm.MinBox.NormalImage")));
            //this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("PriceSelectForm.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(25, 26);
            this.Name = "PriceSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "衣服和价格";
            this.Load += new System.EventHandler(this.PriceSelectForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}