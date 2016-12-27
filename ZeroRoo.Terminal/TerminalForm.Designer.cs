namespace ZeroRoo.Terminal
{
    partial class TerminalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminalForm));
            this.qtbMain = new UI.Q.Controls.QTabControl();
            this.dSkinTabPage1 = new DSkin.Controls.DSkinTabPage();
            this.dSkinTabPage2 = new DSkin.Controls.DSkinTabPage();
            this.qtbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // qtbMain
            // 
            this.qtbMain.BitmapCache = false;
            this.qtbMain.Borders.AllColor = System.Drawing.Color.Gray;
            this.qtbMain.Borders.BottomColor = System.Drawing.Color.Gray;
            this.qtbMain.Borders.LeftColor = System.Drawing.Color.Gray;
            this.qtbMain.Borders.RightColor = System.Drawing.Color.Gray;
            this.qtbMain.Borders.TopColor = System.Drawing.Color.Gray;
            this.qtbMain.CloseButton.HoverBackColor = System.Drawing.Color.Transparent;
            this.qtbMain.CloseButton.HoverColor = System.Drawing.Color.LightGray;
            this.qtbMain.CloseButton.LocationOffset = new System.Drawing.Point(0, 7);
            this.qtbMain.CloseButton.NormalColor = System.Drawing.Color.Gray;
            this.qtbMain.CloseButton.PressColor = System.Drawing.Color.LightGray;
            this.qtbMain.Controls.Add(this.dSkinTabPage1);
            this.qtbMain.Controls.Add(this.dSkinTabPage2);
            this.qtbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qtbMain.EnabledCloseButton = true;
            this.qtbMain.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.qtbMain.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.qtbMain.HoverBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.qtbMain.ItemBackgroundImage = ((System.Drawing.Image)(resources.GetObject("qtbMain.ItemBackgroundImage")));
            this.qtbMain.ItemBackgroundImageHover = ((System.Drawing.Image)(resources.GetObject("qtbMain.ItemBackgroundImageHover")));
            this.qtbMain.ItemBackgroundImageSelected = ((System.Drawing.Image)(resources.GetObject("qtbMain.ItemBackgroundImageSelected")));
            this.qtbMain.ItemSize = new System.Drawing.Size(150, 30);
            this.qtbMain.Location = new System.Drawing.Point(4, 29);
            this.qtbMain.Name = "qtbMain";
            this.qtbMain.NormalBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.qtbMain.PageDownTxtColor = System.Drawing.Color.White;
            this.qtbMain.PageHoverTxtColor = System.Drawing.Color.Gainsboro;
            this.qtbMain.PageImagePosition = DSkin.Controls.ePageImagePosition.Left;
            this.qtbMain.PageNormlTxtColor = System.Drawing.Color.Gray;
            this.qtbMain.PageTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qtbMain.SelectedBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.qtbMain.SelectedIndex = 1;
            this.qtbMain.Size = new System.Drawing.Size(508, 308);
            this.qtbMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.qtbMain.TabIndex = 0;
            this.qtbMain.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.qtbMain.UpdownBtnArrowNormalColor = System.Drawing.Color.Black;
            this.qtbMain.UpdownBtnArrowPressColor = System.Drawing.Color.Gray;
            this.qtbMain.UpdownBtnBackColor = System.Drawing.Color.Transparent;
            this.qtbMain.UpdownBtnBorderColor = System.Drawing.Color.Black;
            this.qtbMain.PageRemoved += new System.EventHandler<DSkin.Controls.DSkinPageRemovedEventArgs>(this.qTabControl1_PageRemoved);
            // 
            // dSkinTabPage1
            // 
            this.dSkinTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinTabPage1.Location = new System.Drawing.Point(0, 36);
            this.dSkinTabPage1.Name = "dSkinTabPage1";
            this.dSkinTabPage1.Size = new System.Drawing.Size(508, 272);
            this.dSkinTabPage1.TabIndex = 0;
            this.dSkinTabPage1.TabItemImage = null;
            this.dSkinTabPage1.Text = "dSkinTabPage1";
            // 
            // dSkinTabPage2
            // 
            this.dSkinTabPage2.BackColor = System.Drawing.Color.Transparent;
            this.dSkinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinTabPage2.Location = new System.Drawing.Point(0, 30);
            this.dSkinTabPage2.Name = "dSkinTabPage2";
            this.dSkinTabPage2.Size = new System.Drawing.Size(508, 278);
            this.dSkinTabPage2.TabIndex = 1;
            this.dSkinTabPage2.TabItemImage = null;
            this.dSkinTabPage2.Text = "dSkinTabPage2";
            // 
            // TerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(516, 341);
            this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("TerminalForm.CloseBox.HoverImage")));
            this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("TerminalForm.CloseBox.NormalImage")));
            this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("TerminalForm.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(25, 26);
            this.Controls.Add(this.qtbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("TerminalForm.MaxBox.HoverImage")));
            this.MaxBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("TerminalForm.MaxBox.NormalImage")));
            this.MaxBox.PressImage = ((System.Drawing.Image)(resources.GetObject("TerminalForm.MaxBox.PressImage")));
            this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("TerminalForm.MinBox.HoverImage")));
            this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("TerminalForm.MinBox.NormalImage")));
            this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("TerminalForm.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(25, 26);
            this.Name = "TerminalForm";
            this.Text = "Terminal";
            this.qtbMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Q.Controls.QTabControl qtbMain;
        private DSkin.Controls.DSkinTabPage dSkinTabPage1;
        private DSkin.Controls.DSkinTabPage dSkinTabPage2;
    }
}

