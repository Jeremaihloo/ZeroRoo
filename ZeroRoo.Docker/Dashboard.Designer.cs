namespace ZeroRoo.Docker
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dSkinContextMenuStrip1 = new DSkin.Controls.DSkinContextMenuStrip();
            this.缩放速度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.很慢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.慢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.很快ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最快ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSkinToolTip1 = new DSkin.Controls.DSkinToolTip(this.components);
            this.dSkinButton1 = new DSkin.Controls.DSkinButton();
            this.duiBaseControl1 = new DSkin.DirectUI.DuiBaseControl();
            this.dSkinListBox1 = new DSkin.Controls.DSkinListBox();
            this.dSkinContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSkinListBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dSkinContextMenuStrip1
            // 
            this.dSkinContextMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.dSkinContextMenuStrip1.Back = System.Drawing.Color.White;
            this.dSkinContextMenuStrip1.BackRadius = 4;
            this.dSkinContextMenuStrip1.Base = System.Drawing.Color.Transparent;
            this.dSkinContextMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.dSkinContextMenuStrip1.Fore = System.Drawing.Color.Black;
            this.dSkinContextMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.dSkinContextMenuStrip1.ItemAnamorphosis = true;
            this.dSkinContextMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.dSkinContextMenuStrip1.ItemBorderShow = false;
            this.dSkinContextMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.dSkinContextMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.dSkinContextMenuStrip1.ItemRadius = 4;
            this.dSkinContextMenuStrip1.ItemRadiusStyle = DSkin.Common.RoundStyle.None;
            this.dSkinContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.缩放速度ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.dSkinContextMenuStrip1.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dSkinContextMenuStrip1.Name = "dSkinContextMenuStrip1";
            this.dSkinContextMenuStrip1.RadiusStyle = DSkin.Common.RoundStyle.None;
            this.dSkinContextMenuStrip1.Size = new System.Drawing.Size(125, 54);
            this.dSkinContextMenuStrip1.SkinAllColor = true;
            this.dSkinContextMenuStrip1.TitleAnamorphosis = true;
            this.dSkinContextMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.dSkinContextMenuStrip1.TitleRadius = 1;
            this.dSkinContextMenuStrip1.TitleRadiusStyle = DSkin.Common.RoundStyle.None;
            // 
            // 缩放速度ToolStripMenuItem
            // 
            this.缩放速度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.很慢ToolStripMenuItem,
            this.慢ToolStripMenuItem,
            this.中ToolStripMenuItem,
            this.快ToolStripMenuItem,
            this.很快ToolStripMenuItem,
            this.最快ToolStripMenuItem});
            this.缩放速度ToolStripMenuItem.Name = "缩放速度ToolStripMenuItem";
            this.缩放速度ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.缩放速度ToolStripMenuItem.Text = "缩放速度";
            // 
            // 很慢ToolStripMenuItem
            // 
            this.很慢ToolStripMenuItem.Name = "很慢ToolStripMenuItem";
            this.很慢ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.很慢ToolStripMenuItem.Tag = "1";
            this.很慢ToolStripMenuItem.Text = "很慢";
            this.很慢ToolStripMenuItem.Click += new System.EventHandler(this.SpeedChange);
            // 
            // 慢ToolStripMenuItem
            // 
            this.慢ToolStripMenuItem.Name = "慢ToolStripMenuItem";
            this.慢ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.慢ToolStripMenuItem.Tag = "2";
            this.慢ToolStripMenuItem.Text = "较慢";
            this.慢ToolStripMenuItem.Click += new System.EventHandler(this.SpeedChange);
            // 
            // 中ToolStripMenuItem
            // 
            this.中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            this.中ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.中ToolStripMenuItem.Tag = "3";
            this.中ToolStripMenuItem.Text = "中等速度";
            this.中ToolStripMenuItem.Click += new System.EventHandler(this.SpeedChange);
            // 
            // 快ToolStripMenuItem
            // 
            this.快ToolStripMenuItem.Name = "快ToolStripMenuItem";
            this.快ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.快ToolStripMenuItem.Tag = "4";
            this.快ToolStripMenuItem.Text = "稍快";
            this.快ToolStripMenuItem.Click += new System.EventHandler(this.SpeedChange);
            // 
            // 很快ToolStripMenuItem
            // 
            this.很快ToolStripMenuItem.Name = "很快ToolStripMenuItem";
            this.很快ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.很快ToolStripMenuItem.Tag = "6";
            this.很快ToolStripMenuItem.Text = "很快";
            this.很快ToolStripMenuItem.Click += new System.EventHandler(this.SpeedChange);
            // 
            // 最快ToolStripMenuItem
            // 
            this.最快ToolStripMenuItem.Name = "最快ToolStripMenuItem";
            this.最快ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.最快ToolStripMenuItem.Tag = "0";
            this.最快ToolStripMenuItem.Text = "最快";
            this.最快ToolStripMenuItem.Click += new System.EventHandler(this.SpeedChange);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // dSkinToolTip1
            // 
            this.dSkinToolTip1.AutoPopDelay = 5000;
            this.dSkinToolTip1.InitialDelay = 500;
            this.dSkinToolTip1.IsBalloon = true;
            this.dSkinToolTip1.OwnerDraw = true;
            this.dSkinToolTip1.ReshowDelay = 800;
            this.dSkinToolTip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // dSkinButton1
            // 
            this.dSkinButton1.AdaptImage = true;
            this.dSkinButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dSkinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(186)))), ((int)(((byte)(233)))));
            this.dSkinButton1.ButtonBorderColor = System.Drawing.Color.Gray;
            this.dSkinButton1.ButtonBorderWidth = 1;
            this.dSkinButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton1.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton1.HoverImage = ((System.Drawing.Image)(resources.GetObject("dSkinButton1.HoverImage")));
            this.dSkinButton1.IsPureColor = false;
            this.dSkinButton1.Location = new System.Drawing.Point(744, 212);
            this.dSkinButton1.Name = "dSkinButton1";
            this.dSkinButton1.NormalImage = ((System.Drawing.Image)(resources.GetObject("dSkinButton1.NormalImage")));
            this.dSkinButton1.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton1.PressedImage = ((System.Drawing.Image)(resources.GetObject("dSkinButton1.PressedImage")));
            this.dSkinButton1.Radius = 10;
            this.dSkinButton1.ShowButtonBorder = true;
            this.dSkinButton1.Size = new System.Drawing.Size(16, 16);
            this.dSkinButton1.TabIndex = 0;
            this.dSkinButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton1.TextPadding = 0;
            this.dSkinButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.dSkinButton1.Click += new System.EventHandler(this.dSkinButton1_Click);
            // 
            // duiBaseControl1
            // 
            this.duiBaseControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.duiBaseControl1.AutoSize = false;
            this.duiBaseControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("duiBaseControl1.BackgroundImage")));
            this.duiBaseControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.duiBaseControl1.CanFocus = true;
            this.duiBaseControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.duiBaseControl1.Location = new System.Drawing.Point(14, 59);
            this.duiBaseControl1.Name = "duiBaseControl1";
            this.duiBaseControl1.Size = new System.Drawing.Size(627, 100);
            this.duiBaseControl1.SudokuDrawBackImage = true;
            this.duiBaseControl1.SudokuPartitionWidth = new System.Windows.Forms.Padding(10, 0, 10, 65);
            this.duiBaseControl1.MouseDown += new System.EventHandler<DSkin.DirectUI.DuiMouseEventArgs>(this.duiBaseControl1_MouseDown);
            // 
            // dSkinListBox1
            // 
            this.dSkinListBox1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinListBox1.Location = new System.Drawing.Point(23, 38);
            this.dSkinListBox1.Name = "dSkinListBox1";
            this.dSkinListBox1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.dSkinListBox1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.dSkinListBox1.ScrollBarWidth = 12;
            this.dSkinListBox1.Size = new System.Drawing.Size(608, 120);
            this.dSkinListBox1.TabIndex = 1;
            this.dSkinListBox1.Text = "dSkinListBox1";
            this.dSkinListBox1.Value = 0D;
            this.dSkinListBox1.Click += new System.EventHandler(this.dSkinListBox1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(789, 160);
            this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("Dashboard.CloseBox.HoverImage")));
            this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("Dashboard.CloseBox.NormalImage")));
            this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("Dashboard.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(16, 16);
            this.Controls.Add(this.dSkinListBox1);
            this.Controls.Add(this.dSkinButton1);
            this.DUIControls.Add(this.duiBaseControl1);
            this.MaxBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("Dashboard.MaxBox.HoverImage")));
            this.MaxBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("Dashboard.MaxBox.NormalImage")));
            this.MaxBox.PressImage = ((System.Drawing.Image)(resources.GetObject("Dashboard.MaxBox.PressImage")));
            this.MaxBox.Size = new System.Drawing.Size(16, 16);
            this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("Dashboard.MinBox.HoverImage")));
            this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("Dashboard.MinBox.NormalImage")));
            this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("Dashboard.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(16, 16);
            this.Name = "Dashboard";
            this.NormalBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("Dashboard.NormalBox.HoverImage")));
            this.NormalBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("Dashboard.NormalBox.NormalImage")));
            this.NormalBox.PressImage = ((System.Drawing.Image)(resources.GetObject("Dashboard.NormalBox.PressImage")));
            this.NormalBox.Size = new System.Drawing.Size(16, 16);
            this.ShowInTaskbar = false;
            this.ShowSystemButtons = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.SudokuPartitionWidth = new System.Windows.Forms.Padding(10, 0, 20, 75);
            this.Text = "";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAppleButton_Load);
            this.dSkinContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSkinListBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DSkin.Controls.DSkinButton dSkinButton1;
        private DSkin.DirectUI.DuiBaseControl duiBaseControl1;
        private DSkin.Controls.DSkinContextMenuStrip dSkinContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private DSkin.Controls.DSkinToolTip dSkinToolTip1;
        private System.Windows.Forms.ToolStripMenuItem 缩放速度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 慢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 很慢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 很快ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最快ToolStripMenuItem;
        private DSkin.Controls.DSkinListBox dSkinListBox1;
    }
}