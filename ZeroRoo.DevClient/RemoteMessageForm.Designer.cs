namespace ZeroRoo.DevClient
{
    partial class RemoteMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteMessageForm));
            this.qPanel1 = new UI.Q.Controls.QPanel();
            this.rtxtMessage = new UI.Q.Controls.QRichTextBox();
            this.qPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qPanel1
            // 
            this.qPanel1.BackColor = System.Drawing.Color.White;
            this.qPanel1.Controls.Add(this.rtxtMessage);
            this.qPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qPanel1.Location = new System.Drawing.Point(4, 29);
            this.qPanel1.Name = "qPanel1";
            this.qPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("qPanel1.RightBottom")));
            this.qPanel1.Size = new System.Drawing.Size(338, 467);
            this.qPanel1.TabIndex = 0;
            this.qPanel1.Text = "qPanel1";
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtMessage.ContextMenuMode = DSkin.Controls.ChatBoxContextMenuMode.None;
            this.rtxtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtMessage.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rtxtMessage.Location = new System.Drawing.Point(0, 0);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.PopoutImageWhenDoubleClick = false;
            this.rtxtMessage.SelectControl = null;
            this.rtxtMessage.SelectControlIndex = 0;
            this.rtxtMessage.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtxtMessage.Size = new System.Drawing.Size(338, 467);
            this.rtxtMessage.TabIndex = 0;
            this.rtxtMessage.Text = "";
            // 
            // RemoteMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 500);
            this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("RemoteMessageForm.CloseBox.HoverImage")));
            this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("RemoteMessageForm.CloseBox.NormalImage")));
            this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("RemoteMessageForm.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(25, 26);
            this.Controls.Add(this.qPanel1);
            this.MaxBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("RemoteMessageForm.MaxBox.HoverImage")));
            this.MaxBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("RemoteMessageForm.MaxBox.NormalImage")));
            this.MaxBox.PressImage = ((System.Drawing.Image)(resources.GetObject("RemoteMessageForm.MaxBox.PressImage")));
            this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("RemoteMessageForm.MinBox.HoverImage")));
            this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("RemoteMessageForm.MinBox.NormalImage")));
            this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("RemoteMessageForm.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(25, 26);
            this.Name = "RemoteMessageForm";
            this.Text = "RemoteMessageForm";
            this.qPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Q.Controls.QPanel qPanel1;
        private UI.Q.Controls.QRichTextBox rtxtMessage;
    }
}