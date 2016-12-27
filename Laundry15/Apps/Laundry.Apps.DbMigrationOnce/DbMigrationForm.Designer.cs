namespace Laundry.Apps.DbMigrationOnce
{
    partial class DbMigrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbMigrationForm));
            this.qPanel1 = new UI.Q.Controls.QPanel();
            this.pbStatus = new UI.Q.Controls.QProgressBar();
            this.btnMain = new UI.Q.Controls.QBigButton();
            this.lblStatus = new UI.Q.Controls.QLabel();
            this.qPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qPanel1
            // 
            this.qPanel1.BackColor = System.Drawing.Color.White;
            this.qPanel1.Controls.Add(this.lblStatus);
            this.qPanel1.Controls.Add(this.pbStatus);
            this.qPanel1.Controls.Add(this.btnMain);
            this.qPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qPanel1.Location = new System.Drawing.Point(4, 29);
            this.qPanel1.Name = "qPanel1";
            this.qPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("qPanel1.RightBottom")));
            this.qPanel1.Size = new System.Drawing.Size(329, 254);
            this.qPanel1.TabIndex = 0;
            this.qPanel1.Text = "qPanel1";
            // 
            // pbStatus
            // 
            this.pbStatus.AutoSize = false;
            this.pbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbStatus.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.pbStatus.ForeColor = System.Drawing.Color.White;
            this.pbStatus.ForeColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))))};
            this.pbStatus.ForeColorsAngle = 90F;
            this.pbStatus.IsDrawText = true;
            this.pbStatus.Location = new System.Drawing.Point(16, 78);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(300, 20);
            this.pbStatus.TabIndex = 1;
            this.pbStatus.Text = "qProgressBar1";
            // 
            // btnMain
            // 
            this.btnMain.AdaptImage = true;
            this.btnMain.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnMain.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnMain.ButtonBorderWidth = 1;
            this.btnMain.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMain.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnMain.HoverImage = null;
            this.btnMain.IsPureColor = true;
            this.btnMain.Location = new System.Drawing.Point(95, 180);
            this.btnMain.Name = "btnMain";
            this.btnMain.NormalImage = null;
            this.btnMain.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnMain.PressedImage = null;
            this.btnMain.Radius = 4;
            this.btnMain.ShowButtonBorder = true;
            this.btnMain.Size = new System.Drawing.Size(140, 50);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "立即更新";
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMain.TextPadding = 0;
            this.btnMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblStatus.Location = new System.Drawing.Point(16, 105);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 18);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "...........";
            // 
            // DbMigrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 287);
            this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("DbMigrationForm.CloseBox.HoverImage")));
            this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("DbMigrationForm.CloseBox.NormalImage")));
            this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("DbMigrationForm.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(25, 26);
            this.Controls.Add(this.qPanel1);
            this.MaxBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("DbMigrationForm.MaxBox.HoverImage")));
            this.MaxBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("DbMigrationForm.MaxBox.NormalImage")));
            this.MaxBox.PressImage = ((System.Drawing.Image)(resources.GetObject("DbMigrationForm.MaxBox.PressImage")));
            this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("DbMigrationForm.MinBox.HoverImage")));
            this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("DbMigrationForm.MinBox.NormalImage")));
            this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("DbMigrationForm.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(25, 26);
            this.Name = "DbMigrationForm";
            this.Text = "数据迁移";
            this.qPanel1.ResumeLayout(false);
            this.qPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Q.Controls.QPanel qPanel1;
        private UI.Q.Controls.QBigButton btnMain;
        private UI.Q.Controls.QProgressBar pbStatus;
        private UI.Q.Controls.QLabel lblStatus;
    }
}