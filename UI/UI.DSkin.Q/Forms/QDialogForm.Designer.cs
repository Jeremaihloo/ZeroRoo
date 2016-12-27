namespace UI.Q.Forms
{
    partial class QDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QDialogForm));
            this.qPanel1 = new UI.Q.Controls.QPanel();
            this.txtBox = new UI.Q.Controls.QTextBox();
            this.picBox = new UI.Q.Controls.QPictureBox();
            this.qFlowLayoutPanel1 = new UI.Q.Controls.QFlowLayoutPanel();
            this.btnOk = new UI.Q.Controls.QButton();
            this.btnYes = new UI.Q.Controls.QButton();
            this.btnNo = new UI.Q.Controls.QButton();
            this.btnCancel = new UI.Q.Controls.QButton();
            this.btnAbort = new UI.Q.Controls.QButton();
            this.btnRetry = new UI.Q.Controls.QButton();
            this.btnIgnore = new UI.Q.Controls.QButton();
            this.qPanel1.SuspendLayout();
            this.qFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qPanel1
            // 
            this.qPanel1.BackColor = System.Drawing.Color.White;
            this.qPanel1.Controls.Add(this.txtBox);
            this.qPanel1.Controls.Add(this.picBox);
            this.qPanel1.Controls.Add(this.qFlowLayoutPanel1);
            this.qPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qPanel1.Location = new System.Drawing.Point(4, 34);
            this.qPanel1.Name = "qPanel1";
            this.qPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("qPanel1.RightBottom")));
            this.qPanel1.Size = new System.Drawing.Size(401, 183);
            this.qPanel1.TabIndex = 0;
            this.qPanel1.Text = "qPanel1";
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.Color.White;
            this.txtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBox.BitmapCache = false;
            this.txtBox.BorderColor = System.Drawing.Color.Transparent;
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBox.Location = new System.Drawing.Point(147, 57);
            this.txtBox.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(242, 56);
            this.txtBox.TabIndex = 99999;
            this.txtBox.TransparencyKey = System.Drawing.Color.White;
            this.txtBox.WaterColor = System.Drawing.Color.Transparent;
            this.txtBox.WaterFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBox.WaterText = "";
            this.txtBox.WaterTextOffset = new System.Drawing.Point(0, 2);
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(((System.Drawing.Image)(resources.GetObject("picBox.Images")))))};
            this.picBox.Interval = 40;
            this.picBox.Location = new System.Drawing.Point(47, 33);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(80, 80);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 1;
            this.picBox.Text = "picBox";
            // 
            // qFlowLayoutPanel1
            // 
            this.qFlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.qFlowLayoutPanel1.BitmapCache = false;
            this.qFlowLayoutPanel1.Controls.Add(this.btnOk);
            this.qFlowLayoutPanel1.Controls.Add(this.btnYes);
            this.qFlowLayoutPanel1.Controls.Add(this.btnNo);
            this.qFlowLayoutPanel1.Controls.Add(this.btnCancel);
            this.qFlowLayoutPanel1.Controls.Add(this.btnAbort);
            this.qFlowLayoutPanel1.Controls.Add(this.btnRetry);
            this.qFlowLayoutPanel1.Controls.Add(this.btnIgnore);
            this.qFlowLayoutPanel1.Location = new System.Drawing.Point(13, 140);
            this.qFlowLayoutPanel1.Name = "qFlowLayoutPanel1";
            this.qFlowLayoutPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("qFlowLayoutPanel1.RightBottom")));
            this.qFlowLayoutPanel1.Size = new System.Drawing.Size(644, 38);
            this.qFlowLayoutPanel1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.AdaptImage = true;
            this.btnOk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnOk.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnOk.ButtonBorderWidth = 1;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnOk.HoverImage = null;
            this.btnOk.IsPureColor = true;
            this.btnOk.Location = new System.Drawing.Point(3, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.NormalImage = null;
            this.btnOk.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnOk.PressedImage = null;
            this.btnOk.Radius = 4;
            this.btnOk.ShowButtonBorder = true;
            this.btnOk.Size = new System.Drawing.Size(85, 28);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "确定";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.TextPadding = 0;
            this.btnOk.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnYes
            // 
            this.btnYes.AdaptImage = true;
            this.btnYes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnYes.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnYes.ButtonBorderWidth = 1;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnYes.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnYes.HoverImage = null;
            this.btnYes.IsPureColor = true;
            this.btnYes.Location = new System.Drawing.Point(94, 3);
            this.btnYes.Name = "btnYes";
            this.btnYes.NormalImage = null;
            this.btnYes.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnYes.PressedImage = null;
            this.btnYes.Radius = 4;
            this.btnYes.ShowButtonBorder = true;
            this.btnYes.Size = new System.Drawing.Size(85, 28);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "是";
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.TextPadding = 0;
            this.btnYes.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.AdaptImage = true;
            this.btnNo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnNo.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnNo.ButtonBorderWidth = 1;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnNo.HoverImage = null;
            this.btnNo.IsPureColor = true;
            this.btnNo.Location = new System.Drawing.Point(185, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.NormalImage = null;
            this.btnNo.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnNo.PressedImage = null;
            this.btnNo.Radius = 4;
            this.btnNo.ShowButtonBorder = true;
            this.btnNo.Size = new System.Drawing.Size(85, 28);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "否";
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.TextPadding = 0;
            this.btnNo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AdaptImage = true;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnCancel.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnCancel.ButtonBorderWidth = 1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnCancel.HoverImage = null;
            this.btnCancel.IsPureColor = true;
            this.btnCancel.Location = new System.Drawing.Point(276, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalImage = null;
            this.btnCancel.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnCancel.PressedImage = null;
            this.btnCancel.Radius = 4;
            this.btnCancel.ShowButtonBorder = true;
            this.btnCancel.Size = new System.Drawing.Size(85, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextPadding = 0;
            this.btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.AdaptImage = true;
            this.btnAbort.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnAbort.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnAbort.ButtonBorderWidth = 1;
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAbort.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnAbort.ForeColor = System.Drawing.Color.White;
            this.btnAbort.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnAbort.HoverImage = null;
            this.btnAbort.IsPureColor = true;
            this.btnAbort.Location = new System.Drawing.Point(367, 3);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.NormalImage = null;
            this.btnAbort.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnAbort.PressedImage = null;
            this.btnAbort.Radius = 4;
            this.btnAbort.ShowButtonBorder = true;
            this.btnAbort.Size = new System.Drawing.Size(85, 28);
            this.btnAbort.TabIndex = 4;
            this.btnAbort.Text = "终止";
            this.btnAbort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAbort.TextPadding = 0;
            this.btnAbort.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.AdaptImage = true;
            this.btnRetry.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnRetry.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnRetry.ButtonBorderWidth = 1;
            this.btnRetry.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRetry.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnRetry.HoverImage = null;
            this.btnRetry.IsPureColor = true;
            this.btnRetry.Location = new System.Drawing.Point(458, 3);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.NormalImage = null;
            this.btnRetry.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnRetry.PressedImage = null;
            this.btnRetry.Radius = 4;
            this.btnRetry.ShowButtonBorder = true;
            this.btnRetry.Size = new System.Drawing.Size(85, 28);
            this.btnRetry.TabIndex = 5;
            this.btnRetry.Text = "重试";
            this.btnRetry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRetry.TextPadding = 0;
            this.btnRetry.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnIgnore
            // 
            this.btnIgnore.AdaptImage = true;
            this.btnIgnore.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnIgnore.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnIgnore.ButtonBorderWidth = 1;
            this.btnIgnore.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIgnore.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnIgnore.ForeColor = System.Drawing.Color.White;
            this.btnIgnore.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnIgnore.HoverImage = null;
            this.btnIgnore.IsPureColor = true;
            this.btnIgnore.Location = new System.Drawing.Point(549, 3);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.NormalImage = null;
            this.btnIgnore.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnIgnore.PressedImage = null;
            this.btnIgnore.Radius = 4;
            this.btnIgnore.ShowButtonBorder = true;
            this.btnIgnore.Size = new System.Drawing.Size(85, 28);
            this.btnIgnore.TabIndex = 6;
            this.btnIgnore.Text = "忽略";
            this.btnIgnore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIgnore.TextPadding = 0;
            this.btnIgnore.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // QDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 221);
            this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("QDialogForm.CloseBox.HoverImage")));
            this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("QDialogForm.CloseBox.NormalImage")));
            this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("QDialogForm.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(25, 26);
            this.Controls.Add(this.qPanel1);
            this.MaxBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("QDialogForm.MaxBox.HoverImage")));
            this.MaxBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("QDialogForm.MaxBox.NormalImage")));
            this.MaxBox.PressImage = ((System.Drawing.Image)(resources.GetObject("QDialogForm.MaxBox.PressImage")));
            this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("QDialogForm.MinBox.HoverImage")));
            this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("QDialogForm.MinBox.NormalImage")));
            this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("QDialogForm.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(25, 26);
            this.MinimizeBox = false;
            this.Name = "QDialogForm";
            this.Text = "QDialogForm";
            this.qPanel1.ResumeLayout(false);
            this.qPanel1.PerformLayout();
            this.qFlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.QPanel qPanel1;
        private Controls.QFlowLayoutPanel qFlowLayoutPanel1;
        private Controls.QButton btnOk;
        private Controls.QButton btnYes;
        private Controls.QButton btnNo;
        private Controls.QButton btnCancel;
        private Controls.QButton btnAbort;
        private Controls.QButton btnRetry;
        private Controls.QButton btnIgnore;
        private Controls.QTextBox txtBox;
        private Controls.QPictureBox picBox;
    }
}