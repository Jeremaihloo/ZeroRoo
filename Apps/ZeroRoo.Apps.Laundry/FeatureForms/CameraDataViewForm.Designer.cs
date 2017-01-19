namespace Laundry.Apps.CameraData
{
    partial class CameraDataViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraDataViewForm));
            this.qPanel1 = new UI.Q.Controls.QPanel();
            this.qListBox1 = new UI.Q.Controls.QListBox();
            this.qPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qListBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // qPanel1
            // 
            this.qPanel1.BackColor = System.Drawing.Color.White;
            this.qPanel1.Controls.Add(this.qListBox1);
            this.qPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qPanel1.Location = new System.Drawing.Point(4, 29);
            this.qPanel1.Name = "qPanel1";
            this.qPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("qPanel1.RightBottom")));
            this.qPanel1.Size = new System.Drawing.Size(275, 442);
            this.qPanel1.TabIndex = 0;
            this.qPanel1.Text = "qPanel1";
            // 
            // qListBox1
            // 
            this.qListBox1.BackColor = System.Drawing.Color.Transparent;
            this.qListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qListBox1.Location = new System.Drawing.Point(0, 0);
            this.qListBox1.Name = "qListBox1";
            this.qListBox1.ScrollBarWidth = 12;
            this.qListBox1.Size = new System.Drawing.Size(275, 442);
            this.qListBox1.TabIndex = 0;
            this.qListBox1.Text = "qListBox1";
            this.qListBox1.Value = 0D;
            // 
            // CameraDataViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 475);
            this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("CameraDataViewForm.CloseBox.HoverImage")));
            this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("CameraDataViewForm.CloseBox.NormalImage")));
            this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("CameraDataViewForm.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(25, 26);
            this.Controls.Add(this.qPanel1);
            this.MaxBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("CameraDataViewForm.MaxBox.HoverImage")));
            this.MaxBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("CameraDataViewForm.MaxBox.NormalImage")));
            this.MaxBox.PressImage = ((System.Drawing.Image)(resources.GetObject("CameraDataViewForm.MaxBox.PressImage")));
            this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("CameraDataViewForm.MinBox.HoverImage")));
            this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("CameraDataViewForm.MinBox.NormalImage")));
            this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("CameraDataViewForm.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(25, 26);
            this.Name = "CameraDataViewForm";
            this.Text = "监控数据查看";
            this.qPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qListBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Q.Controls.QPanel qPanel1;
        private UI.Q.Controls.QListBox qListBox1;
    }
}