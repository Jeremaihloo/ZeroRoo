namespace ZeroRoo.DevClient
{
    partial class DevClientMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevClientMain));
            this.qPanel1 = new UI.Q.Controls.QPanel();
            this.btnRemoteMessage = new UI.Q.Controls.QButton();
            this.qPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qPanel1
            // 
            this.qPanel1.BackColor = System.Drawing.Color.White;
            this.qPanel1.Controls.Add(this.btnRemoteMessage);
            this.qPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qPanel1.Location = new System.Drawing.Point(4, 29);
            this.qPanel1.Name = "qPanel1";
            this.qPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("qPanel1.RightBottom")));
            this.qPanel1.Size = new System.Drawing.Size(418, 291);
            this.qPanel1.TabIndex = 0;
            this.qPanel1.Text = "qPanel1";
            // 
            // btnRemoteMessage
            // 
            this.btnRemoteMessage.AdaptImage = true;
            this.btnRemoteMessage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnRemoteMessage.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnRemoteMessage.ButtonBorderWidth = 1;
            this.btnRemoteMessage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemoteMessage.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnRemoteMessage.ForeColor = System.Drawing.Color.White;
            this.btnRemoteMessage.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnRemoteMessage.HoverImage = null;
            this.btnRemoteMessage.IsPureColor = true;
            this.btnRemoteMessage.Location = new System.Drawing.Point(155, 126);
            this.btnRemoteMessage.Name = "btnRemoteMessage";
            this.btnRemoteMessage.NormalImage = null;
            this.btnRemoteMessage.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnRemoteMessage.PressedImage = null;
            this.btnRemoteMessage.Radius = 4;
            this.btnRemoteMessage.ShowButtonBorder = true;
            this.btnRemoteMessage.Size = new System.Drawing.Size(100, 40);
            this.btnRemoteMessage.TabIndex = 0;
            this.btnRemoteMessage.Text = "远程消息";
            this.btnRemoteMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoteMessage.TextPadding = 0;
            this.btnRemoteMessage.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnRemoteMessage.Click += new System.EventHandler(this.btnRemoteMessage_Click);
            // 
            // DevClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 324);
            this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("DevClientMain.CloseBox.HoverImage")));
            this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("DevClientMain.CloseBox.NormalImage")));
            this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("DevClientMain.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(25, 26);
            this.Controls.Add(this.qPanel1);
            this.MaxBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("DevClientMain.MaxBox.HoverImage")));
            this.MaxBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("DevClientMain.MaxBox.NormalImage")));
            this.MaxBox.PressImage = ((System.Drawing.Image)(resources.GetObject("DevClientMain.MaxBox.PressImage")));
            this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("DevClientMain.MinBox.HoverImage")));
            this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("DevClientMain.MinBox.NormalImage")));
            this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("DevClientMain.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(25, 26);
            this.Name = "DevClientMain";
            this.Text = "DevClient";
            this.qPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Q.Controls.QPanel qPanel1;
        private UI.Q.Controls.QButton btnRemoteMessage;
    }
}

