namespace Laundry.Apps.LaundryTicket
{
    partial class LaundryTicketForm
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
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn1 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn2 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn3 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn4 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn5 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn6 = new DSkin.Controls.DSkinGridListColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaundryTicketForm));
            this.tab = new UI.Q.Controls.QTabControl();
            this.dSkinTabPage1 = new DSkin.Controls.DSkinTabPage();
            this.glClothe = new UI.Q.Controls.QGridList();
            this.btnDeleteClothe = new UI.Q.Controls.QBigButton();
            this.btnEditClothe = new UI.Q.Controls.QBigButton();
            this.btnAddClothe = new UI.Q.Controls.QBigButton();
            this.dSkinTabPage2 = new DSkin.Controls.DSkinTabPage();
            this.txtGender = new UI.Q.Controls.QComboBox();
            this.cbTakeOffWay = new UI.Q.Controls.QComboBox();
            this.cbGetClotheWay = new UI.Q.Controls.QComboBox();
            this.dtpPlanTakeOff = new UI.Q.Controls.QDateTimePicker();
            this.txtMark = new UI.Q.Controls.QTextBox();
            this.qLabel11 = new UI.Q.Controls.QLabel();
            this.qLabel10 = new UI.Q.Controls.QLabel();
            this.qLabel9 = new UI.Q.Controls.QLabel();
            this.qLabel8 = new UI.Q.Controls.QLabel();
            this.txtThisMoney = new UI.Q.Controls.QTextBox();
            this.qLabel7 = new UI.Q.Controls.QLabel();
            this.txtBalance = new UI.Q.Controls.QTextBox();
            this.qLabel6 = new UI.Q.Controls.QLabel();
            this.txtAddress = new UI.Q.Controls.QTextBox();
            this.qLabel5 = new UI.Q.Controls.QLabel();
            this.qLabel4 = new UI.Q.Controls.QLabel();
            this.txtName = new UI.Q.Controls.QTextBox();
            this.qLabel3 = new UI.Q.Controls.QLabel();
            this.txtPhone = new UI.Q.Controls.QTextBox();
            this.qLabel2 = new UI.Q.Controls.QLabel();
            this.txtVipID = new UI.Q.Controls.QTextBox();
            this.qLabel1 = new UI.Q.Controls.QLabel();
            this.dSkinTabPage3 = new DSkin.Controls.DSkinTabPage();
            this.ticketViewBox = new Laundry.LibCore.Forms.TicketViewBox();
            this.btnPay = new UI.Q.Controls.QBigButton();
            this.btnPrint = new UI.Q.Controls.QBigButton();
            this.btnSave = new UI.Q.Controls.QBigButton();
            this.tab.SuspendLayout();
            this.dSkinTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glClothe)).BeginInit();
            this.dSkinTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender.InnerListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTakeOffWay.InnerListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGetClotheWay.InnerListBox)).BeginInit();
            this.dSkinTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.BackColor = System.Drawing.Color.White;
            this.tab.BitmapCache = false;
            this.tab.Borders.AllColor = System.Drawing.Color.Gray;
            this.tab.Borders.BottomColor = System.Drawing.Color.Gray;
            this.tab.Borders.LeftColor = System.Drawing.Color.Gray;
            this.tab.Borders.RightColor = System.Drawing.Color.Gray;
            this.tab.Borders.TopColor = System.Drawing.Color.Gray;
            this.tab.Controls.Add(this.dSkinTabPage1);
            this.tab.Controls.Add(this.dSkinTabPage2);
            this.tab.Controls.Add(this.dSkinTabPage3);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.tab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tab.HoverBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.tab.ItemBackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab.ItemBackgroundImage")));
            this.tab.ItemBackgroundImageHover = ((System.Drawing.Image)(resources.GetObject("tab.ItemBackgroundImageHover")));
            this.tab.ItemBackgroundImageSelected = ((System.Drawing.Image)(resources.GetObject("tab.ItemBackgroundImageSelected")));
            this.tab.ItemSize = new System.Drawing.Size(100, 36);
            this.tab.Location = new System.Drawing.Point(4, 29);
            this.tab.Name = "tab";
            this.tab.NormalBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.tab.PageImagePosition = DSkin.Controls.ePageImagePosition.Left;
            this.tab.SelectedBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.tab.SelectedIndex = 2;
            this.tab.Size = new System.Drawing.Size(796, 531);
            this.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab.TabIndex = 7;
            this.tab.UpdownBtnArrowNormalColor = System.Drawing.Color.Black;
            this.tab.UpdownBtnArrowPressColor = System.Drawing.Color.Gray;
            this.tab.UpdownBtnBackColor = System.Drawing.Color.White;
            this.tab.UpdownBtnBorderColor = System.Drawing.Color.Black;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // dSkinTabPage1
            // 
            this.dSkinTabPage1.BackColor = System.Drawing.Color.White;
            this.dSkinTabPage1.Controls.Add(this.glClothe);
            this.dSkinTabPage1.Controls.Add(this.btnDeleteClothe);
            this.dSkinTabPage1.Controls.Add(this.btnEditClothe);
            this.dSkinTabPage1.Controls.Add(this.btnAddClothe);
            this.dSkinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinTabPage1.Location = new System.Drawing.Point(0, 36);
            this.dSkinTabPage1.Name = "dSkinTabPage1";
            this.dSkinTabPage1.Size = new System.Drawing.Size(796, 495);
            this.dSkinTabPage1.TabIndex = 0;
            this.dSkinTabPage1.TabItemImage = null;
            this.dSkinTabPage1.Text = "衣服";
            // 
            // glClothe
            // 
            // 
            // 
            // 
            this.glClothe.BackPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.glClothe.BackPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.glClothe.BackPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glClothe.BackPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.glClothe.BackPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.glClothe.BackPageButton.IsPureColor = true;
            this.glClothe.BackPageButton.Location = new System.Drawing.Point(633, 4);
            this.glClothe.BackPageButton.Name = "BtnBackPage";
            this.glClothe.BackPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.glClothe.BackPageButton.Radius = 0;
            this.glClothe.BackPageButton.Size = new System.Drawing.Size(50, 24);
            this.glClothe.BackPageButton.Text = "上一页";
            this.glClothe.BackPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glClothe.BackPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.glClothe.Borders.AllColor = System.Drawing.Color.Silver;
            this.glClothe.Borders.BottomColor = System.Drawing.Color.Silver;
            this.glClothe.Borders.LeftColor = System.Drawing.Color.Silver;
            this.glClothe.Borders.RightColor = System.Drawing.Color.Silver;
            this.glClothe.Borders.TopColor = System.Drawing.Color.Silver;
            this.glClothe.ColumnHeight = 30;
            // 
            // 
            // 
            dSkinGridListColumn1.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn1.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn1.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn1.Item.Location = new System.Drawing.Point(0, 0);
            dSkinGridListColumn1.Item.Name = "";
            dSkinGridListColumn1.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn1.Item.Tag = dSkinGridListColumn1;
            dSkinGridListColumn1.Item.Text = "名称";
            dSkinGridListColumn1.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn1.Name = "名称";
            dSkinGridListColumn1.Visble = true;
            dSkinGridListColumn1.Width = 80;
            // 
            // 
            // 
            dSkinGridListColumn2.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn2.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn2.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn2.Item.Location = new System.Drawing.Point(80, 0);
            dSkinGridListColumn2.Item.Name = "";
            dSkinGridListColumn2.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn2.Item.Tag = dSkinGridListColumn2;
            dSkinGridListColumn2.Item.Text = "价格";
            dSkinGridListColumn2.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn2.Name = "价格";
            dSkinGridListColumn2.Visble = true;
            dSkinGridListColumn2.Width = 80;
            // 
            // 
            // 
            dSkinGridListColumn3.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn3.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn3.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn3.Item.Location = new System.Drawing.Point(160, 0);
            dSkinGridListColumn3.Item.Name = "";
            dSkinGridListColumn3.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn3.Item.Tag = dSkinGridListColumn3;
            dSkinGridListColumn3.Item.Text = "颜色";
            dSkinGridListColumn3.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn3.Name = "颜色";
            dSkinGridListColumn3.Visble = true;
            dSkinGridListColumn3.Width = 80;
            // 
            // 
            // 
            dSkinGridListColumn4.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn4.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn4.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn4.Item.Location = new System.Drawing.Point(240, 0);
            dSkinGridListColumn4.Item.Name = "";
            dSkinGridListColumn4.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn4.Item.Tag = dSkinGridListColumn4;
            dSkinGridListColumn4.Item.Text = "品牌";
            dSkinGridListColumn4.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn4.Name = "品牌";
            dSkinGridListColumn4.Visble = true;
            dSkinGridListColumn4.Width = 80;
            // 
            // 
            // 
            dSkinGridListColumn5.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn5.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn5.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn5.Item.Location = new System.Drawing.Point(320, 0);
            dSkinGridListColumn5.Item.Name = "";
            dSkinGridListColumn5.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn5.Item.Tag = dSkinGridListColumn5;
            dSkinGridListColumn5.Item.Text = "瑕疵";
            dSkinGridListColumn5.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn5.Name = "瑕疵";
            dSkinGridListColumn5.Visble = true;
            dSkinGridListColumn5.Width = 80;
            // 
            // 
            // 
            dSkinGridListColumn6.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn6.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn6.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn6.Item.Location = new System.Drawing.Point(400, 0);
            dSkinGridListColumn6.Item.Name = "";
            dSkinGridListColumn6.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn6.Item.Tag = dSkinGridListColumn6;
            dSkinGridListColumn6.Item.Text = "备注";
            dSkinGridListColumn6.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn6.Name = "备注";
            dSkinGridListColumn6.Visble = true;
            dSkinGridListColumn6.Width = 80;
            this.glClothe.Columns.AddRange(new DSkin.Controls.DSkinGridListColumn[] {
            dSkinGridListColumn1,
            dSkinGridListColumn2,
            dSkinGridListColumn3,
            dSkinGridListColumn4,
            dSkinGridListColumn5,
            dSkinGridListColumn6});
            this.glClothe.DoubleItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.glClothe.EnabledOrder = false;
            // 
            // 
            // 
            this.glClothe.FirstPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.glClothe.FirstPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.glClothe.FirstPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glClothe.FirstPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.glClothe.FirstPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.glClothe.FirstPageButton.IsPureColor = true;
            this.glClothe.FirstPageButton.Location = new System.Drawing.Point(585, 4);
            this.glClothe.FirstPageButton.Name = "BtnFistPage";
            this.glClothe.FirstPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.glClothe.FirstPageButton.Radius = 0;
            this.glClothe.FirstPageButton.Size = new System.Drawing.Size(44, 24);
            this.glClothe.FirstPageButton.Text = "首页";
            this.glClothe.FirstPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glClothe.FirstPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // 
            // 
            this.glClothe.GoPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.glClothe.GoPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.glClothe.GoPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glClothe.GoPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.glClothe.GoPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.glClothe.GoPageButton.IsPureColor = true;
            this.glClothe.GoPageButton.Location = new System.Drawing.Point(290, 4);
            this.glClothe.GoPageButton.Name = "BtnGoPage";
            this.glClothe.GoPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.glClothe.GoPageButton.Radius = 0;
            this.glClothe.GoPageButton.Size = new System.Drawing.Size(44, 24);
            this.glClothe.GoPageButton.Text = "跳转";
            this.glClothe.GoPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glClothe.GoPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.glClothe.GridLineColor = System.Drawing.Color.Silver;
            this.glClothe.HeaderFont = new System.Drawing.Font("微软雅黑", 9F);
            // 
            // 
            // 
            this.glClothe.HScrollBar.AutoSize = false;
            this.glClothe.HScrollBar.Fillet = true;
            this.glClothe.HScrollBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.glClothe.HScrollBar.Location = new System.Drawing.Point(0, 56);
            this.glClothe.HScrollBar.Maximum = 381;
            this.glClothe.HScrollBar.Name = "";
            this.glClothe.HScrollBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.glClothe.HScrollBar.ScrollBarLenght = 10;
            this.glClothe.HScrollBar.ScrollBarPartitionWidth = new System.Windows.Forms.Padding(5);
            this.glClothe.HScrollBar.Size = new System.Drawing.Size(789, 12);
            this.glClothe.HScrollBar.Visible = false;
            // 
            // 
            // 
            this.glClothe.LastPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.glClothe.LastPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.glClothe.LastPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glClothe.LastPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.glClothe.LastPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.glClothe.LastPageButton.IsPureColor = true;
            this.glClothe.LastPageButton.Location = new System.Drawing.Point(741, 4);
            this.glClothe.LastPageButton.Name = "BtnLastPage";
            this.glClothe.LastPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.glClothe.LastPageButton.Radius = 0;
            this.glClothe.LastPageButton.Size = new System.Drawing.Size(44, 24);
            this.glClothe.LastPageButton.Text = "末页";
            this.glClothe.LastPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glClothe.LastPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.glClothe.Location = new System.Drawing.Point(4, 4);
            this.glClothe.Name = "glClothe";
            // 
            // 
            // 
            this.glClothe.NextPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.glClothe.NextPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.glClothe.NextPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glClothe.NextPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.glClothe.NextPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.glClothe.NextPageButton.IsPureColor = true;
            this.glClothe.NextPageButton.Location = new System.Drawing.Point(687, 4);
            this.glClothe.NextPageButton.Name = "BtnNextPage";
            this.glClothe.NextPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.glClothe.NextPageButton.Radius = 0;
            this.glClothe.NextPageButton.Size = new System.Drawing.Size(50, 24);
            this.glClothe.NextPageButton.Text = "下一页";
            this.glClothe.NextPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glClothe.NextPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.glClothe.SelectedItem = null;
            this.glClothe.Size = new System.Drawing.Size(789, 446);
            this.glClothe.TabIndex = 3;
            this.glClothe.Text = "qGridList1";
            // 
            // 
            // 
            this.glClothe.VScrollBar.AutoSize = false;
            this.glClothe.VScrollBar.BitmapCache = true;
            this.glClothe.VScrollBar.Fillet = true;
            this.glClothe.VScrollBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.glClothe.VScrollBar.LargeChange = 1000;
            this.glClothe.VScrollBar.Location = new System.Drawing.Point(776, 1);
            this.glClothe.VScrollBar.Margin = new System.Windows.Forms.Padding(1);
            this.glClothe.VScrollBar.Maximum = 10000;
            this.glClothe.VScrollBar.Name = "";
            this.glClothe.VScrollBar.ScrollBarPartitionWidth = new System.Windows.Forms.Padding(5);
            this.glClothe.VScrollBar.Size = new System.Drawing.Size(12, 381);
            this.glClothe.VScrollBar.SmallChange = 500;
            this.glClothe.VScrollBar.Visible = false;
            // 
            // btnDeleteClothe
            // 
            this.btnDeleteClothe.AdaptImage = true;
            this.btnDeleteClothe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnDeleteClothe.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnDeleteClothe.ButtonBorderWidth = 1;
            this.btnDeleteClothe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteClothe.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteClothe.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClothe.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnDeleteClothe.HoverImage = null;
            this.btnDeleteClothe.IsPureColor = true;
            this.btnDeleteClothe.Location = new System.Drawing.Point(206, 456);
            this.btnDeleteClothe.Name = "btnDeleteClothe";
            this.btnDeleteClothe.NormalImage = null;
            this.btnDeleteClothe.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnDeleteClothe.PressedImage = null;
            this.btnDeleteClothe.Radius = 4;
            this.btnDeleteClothe.ShowButtonBorder = true;
            this.btnDeleteClothe.Size = new System.Drawing.Size(95, 33);
            this.btnDeleteClothe.TabIndex = 2;
            this.btnDeleteClothe.Text = "删除";
            this.btnDeleteClothe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteClothe.TextPadding = 0;
            this.btnDeleteClothe.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnDeleteClothe.Click += new System.EventHandler(this.btnDeleteClothe_Click);
            // 
            // btnEditClothe
            // 
            this.btnEditClothe.AdaptImage = true;
            this.btnEditClothe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnEditClothe.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnEditClothe.ButtonBorderWidth = 1;
            this.btnEditClothe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditClothe.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditClothe.ForeColor = System.Drawing.Color.White;
            this.btnEditClothe.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnEditClothe.HoverImage = null;
            this.btnEditClothe.IsPureColor = true;
            this.btnEditClothe.Location = new System.Drawing.Point(105, 456);
            this.btnEditClothe.Name = "btnEditClothe";
            this.btnEditClothe.NormalImage = null;
            this.btnEditClothe.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnEditClothe.PressedImage = null;
            this.btnEditClothe.Radius = 4;
            this.btnEditClothe.ShowButtonBorder = true;
            this.btnEditClothe.Size = new System.Drawing.Size(95, 33);
            this.btnEditClothe.TabIndex = 1;
            this.btnEditClothe.Text = "编辑";
            this.btnEditClothe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditClothe.TextPadding = 0;
            this.btnEditClothe.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnEditClothe.Click += new System.EventHandler(this.btnEditClothe_Click);
            // 
            // btnAddClothe
            // 
            this.btnAddClothe.AdaptImage = true;
            this.btnAddClothe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnAddClothe.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnAddClothe.ButtonBorderWidth = 1;
            this.btnAddClothe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddClothe.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddClothe.ForeColor = System.Drawing.Color.White;
            this.btnAddClothe.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnAddClothe.HoverImage = null;
            this.btnAddClothe.IsPureColor = true;
            this.btnAddClothe.Location = new System.Drawing.Point(4, 456);
            this.btnAddClothe.Name = "btnAddClothe";
            this.btnAddClothe.NormalImage = null;
            this.btnAddClothe.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnAddClothe.PressedImage = null;
            this.btnAddClothe.Radius = 4;
            this.btnAddClothe.ShowButtonBorder = true;
            this.btnAddClothe.Size = new System.Drawing.Size(95, 33);
            this.btnAddClothe.TabIndex = 0;
            this.btnAddClothe.Text = "添加";
            this.btnAddClothe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddClothe.TextPadding = 0;
            this.btnAddClothe.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnAddClothe.Click += new System.EventHandler(this.btnAddClothe_Click);
            // 
            // dSkinTabPage2
            // 
            this.dSkinTabPage2.BackColor = System.Drawing.Color.White;
            this.dSkinTabPage2.Controls.Add(this.txtGender);
            this.dSkinTabPage2.Controls.Add(this.cbTakeOffWay);
            this.dSkinTabPage2.Controls.Add(this.cbGetClotheWay);
            this.dSkinTabPage2.Controls.Add(this.dtpPlanTakeOff);
            this.dSkinTabPage2.Controls.Add(this.txtMark);
            this.dSkinTabPage2.Controls.Add(this.qLabel11);
            this.dSkinTabPage2.Controls.Add(this.qLabel10);
            this.dSkinTabPage2.Controls.Add(this.qLabel9);
            this.dSkinTabPage2.Controls.Add(this.qLabel8);
            this.dSkinTabPage2.Controls.Add(this.txtThisMoney);
            this.dSkinTabPage2.Controls.Add(this.qLabel7);
            this.dSkinTabPage2.Controls.Add(this.txtBalance);
            this.dSkinTabPage2.Controls.Add(this.qLabel6);
            this.dSkinTabPage2.Controls.Add(this.txtAddress);
            this.dSkinTabPage2.Controls.Add(this.qLabel5);
            this.dSkinTabPage2.Controls.Add(this.qLabel4);
            this.dSkinTabPage2.Controls.Add(this.txtName);
            this.dSkinTabPage2.Controls.Add(this.qLabel3);
            this.dSkinTabPage2.Controls.Add(this.txtPhone);
            this.dSkinTabPage2.Controls.Add(this.qLabel2);
            this.dSkinTabPage2.Controls.Add(this.txtVipID);
            this.dSkinTabPage2.Controls.Add(this.qLabel1);
            this.dSkinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinTabPage2.Location = new System.Drawing.Point(0, 36);
            this.dSkinTabPage2.Name = "dSkinTabPage2";
            this.dSkinTabPage2.Size = new System.Drawing.Size(796, 495);
            this.dSkinTabPage2.TabIndex = 1;
            this.dSkinTabPage2.TabItemImage = null;
            this.dSkinTabPage2.Text = "信息";
            // 
            // txtGender
            // 
            this.txtGender.AdaptImage = true;
            this.txtGender.AutoDrawSelecedItem = true;
            this.txtGender.BaseColor = System.Drawing.Color.White;
            this.txtGender.ButtonBorderColor = System.Drawing.Color.Gray;
            this.txtGender.ButtonBorderWidth = 1;
            this.txtGender.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtGender.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtGender.HoverColor = System.Drawing.Color.Empty;
            this.txtGender.HoverImage = null;
            // 
            // 
            // 
            this.txtGender.InnerListBox.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.InnerListBox.Location = new System.Drawing.Point(0, 0);
            this.txtGender.InnerListBox.Name = "";
            this.txtGender.InnerListBox.ScrollBarWidth = 12;
            this.txtGender.InnerListBox.TabIndex = 0;
            this.txtGender.InnerListBox.Value = 0D;
            this.txtGender.IsDrawText = false;
            this.txtGender.IsPureColor = false;
            this.txtGender.ItemHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtGender.Location = new System.Drawing.Point(352, 171);
            this.txtGender.Name = "txtGender";
            this.txtGender.NormalImage = null;
            this.txtGender.PaddingLeft = 2;
            this.txtGender.PressColor = System.Drawing.Color.Empty;
            this.txtGender.PressedImage = null;
            this.txtGender.Radius = 0;
            this.txtGender.SelectedIndex = -1;
            this.txtGender.ShowArrow = true;
            this.txtGender.ShowButtonBorder = true;
            this.txtGender.Size = new System.Drawing.Size(186, 25);
            this.txtGender.TabIndex = 24;
            this.txtGender.Text = "qComboBox1";
            this.txtGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtGender.TextPadding = 3;
            this.txtGender.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // 
            // 
            this.txtGender.ToolStripDropDown.BorderColor = System.Drawing.Color.DarkGray;
            this.txtGender.ToolStripDropDown.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.txtGender.ToolStripDropDown.MinimumSize = new System.Drawing.Size(18, 18);
            this.txtGender.ToolStripDropDown.Name = "";
            this.txtGender.ToolStripDropDown.Padding = new System.Windows.Forms.Padding(0);
            this.txtGender.ToolStripDropDown.Resizable = false;
            this.txtGender.ToolStripDropDown.ResizeGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.txtGender.ToolStripDropDown.ResizeGridSize = new System.Drawing.Size(16, 16);
            this.txtGender.ToolStripDropDown.Size = new System.Drawing.Size(18, 18);
            this.txtGender.ToolStripDropDown.WhereIsResizeGrid = DSkin.ResizeGridLocation.BottomRight;
            // 
            // cbTakeOffWay
            // 
            this.cbTakeOffWay.AdaptImage = true;
            this.cbTakeOffWay.AutoDrawSelecedItem = true;
            this.cbTakeOffWay.BaseColor = System.Drawing.Color.White;
            this.cbTakeOffWay.ButtonBorderColor = System.Drawing.Color.Gray;
            this.cbTakeOffWay.ButtonBorderWidth = 1;
            this.cbTakeOffWay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbTakeOffWay.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbTakeOffWay.HoverColor = System.Drawing.Color.Empty;
            this.cbTakeOffWay.HoverImage = null;
            // 
            // 
            // 
            this.cbTakeOffWay.InnerListBox.BackColor = System.Drawing.Color.Transparent;
            this.cbTakeOffWay.InnerListBox.Location = new System.Drawing.Point(0, 0);
            this.cbTakeOffWay.InnerListBox.Name = "";
            this.cbTakeOffWay.InnerListBox.ScrollBarWidth = 12;
            this.cbTakeOffWay.InnerListBox.TabIndex = 0;
            this.cbTakeOffWay.InnerListBox.Value = 0D;
            this.cbTakeOffWay.IsDrawText = false;
            this.cbTakeOffWay.IsPureColor = false;
            this.cbTakeOffWay.ItemHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cbTakeOffWay.Location = new System.Drawing.Point(352, 406);
            this.cbTakeOffWay.Name = "cbTakeOffWay";
            this.cbTakeOffWay.NormalImage = null;
            this.cbTakeOffWay.PaddingLeft = 2;
            this.cbTakeOffWay.PressColor = System.Drawing.Color.Empty;
            this.cbTakeOffWay.PressedImage = null;
            this.cbTakeOffWay.Radius = 0;
            this.cbTakeOffWay.SelectedIndex = -1;
            this.cbTakeOffWay.ShowArrow = true;
            this.cbTakeOffWay.ShowButtonBorder = true;
            this.cbTakeOffWay.Size = new System.Drawing.Size(186, 25);
            this.cbTakeOffWay.TabIndex = 23;
            this.cbTakeOffWay.Text = "qComboBox2";
            this.cbTakeOffWay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTakeOffWay.TextPadding = 3;
            this.cbTakeOffWay.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // 
            // 
            this.cbTakeOffWay.ToolStripDropDown.BorderColor = System.Drawing.Color.DarkGray;
            this.cbTakeOffWay.ToolStripDropDown.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.cbTakeOffWay.ToolStripDropDown.MinimumSize = new System.Drawing.Size(18, 18);
            this.cbTakeOffWay.ToolStripDropDown.Name = "";
            this.cbTakeOffWay.ToolStripDropDown.Padding = new System.Windows.Forms.Padding(0);
            this.cbTakeOffWay.ToolStripDropDown.Resizable = false;
            this.cbTakeOffWay.ToolStripDropDown.ResizeGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.cbTakeOffWay.ToolStripDropDown.ResizeGridSize = new System.Drawing.Size(16, 16);
            this.cbTakeOffWay.ToolStripDropDown.Size = new System.Drawing.Size(18, 18);
            this.cbTakeOffWay.ToolStripDropDown.WhereIsResizeGrid = DSkin.ResizeGridLocation.BottomRight;
            // 
            // cbGetClotheWay
            // 
            this.cbGetClotheWay.AdaptImage = true;
            this.cbGetClotheWay.AutoDrawSelecedItem = true;
            this.cbGetClotheWay.BaseColor = System.Drawing.Color.White;
            this.cbGetClotheWay.ButtonBorderColor = System.Drawing.Color.Gray;
            this.cbGetClotheWay.ButtonBorderWidth = 1;
            this.cbGetClotheWay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbGetClotheWay.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbGetClotheWay.HoverColor = System.Drawing.Color.Empty;
            this.cbGetClotheWay.HoverImage = null;
            // 
            // 
            // 
            this.cbGetClotheWay.InnerListBox.BackColor = System.Drawing.Color.Transparent;
            this.cbGetClotheWay.InnerListBox.Location = new System.Drawing.Point(0, 0);
            this.cbGetClotheWay.InnerListBox.Name = "";
            this.cbGetClotheWay.InnerListBox.ScrollBarWidth = 12;
            this.cbGetClotheWay.InnerListBox.TabIndex = 0;
            this.cbGetClotheWay.InnerListBox.Value = 0D;
            this.cbGetClotheWay.IsDrawText = false;
            this.cbGetClotheWay.IsPureColor = false;
            this.cbGetClotheWay.ItemHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cbGetClotheWay.Location = new System.Drawing.Point(352, 364);
            this.cbGetClotheWay.Name = "cbGetClotheWay";
            this.cbGetClotheWay.NormalImage = null;
            this.cbGetClotheWay.PaddingLeft = 2;
            this.cbGetClotheWay.PressColor = System.Drawing.Color.Empty;
            this.cbGetClotheWay.PressedImage = null;
            this.cbGetClotheWay.Radius = 0;
            this.cbGetClotheWay.SelectedIndex = -1;
            this.cbGetClotheWay.ShowArrow = true;
            this.cbGetClotheWay.ShowButtonBorder = true;
            this.cbGetClotheWay.Size = new System.Drawing.Size(186, 25);
            this.cbGetClotheWay.TabIndex = 22;
            this.cbGetClotheWay.Text = "qComboBox1";
            this.cbGetClotheWay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbGetClotheWay.TextPadding = 3;
            this.cbGetClotheWay.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // 
            // 
            this.cbGetClotheWay.ToolStripDropDown.BorderColor = System.Drawing.Color.DarkGray;
            this.cbGetClotheWay.ToolStripDropDown.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.cbGetClotheWay.ToolStripDropDown.MinimumSize = new System.Drawing.Size(18, 18);
            this.cbGetClotheWay.ToolStripDropDown.Name = "";
            this.cbGetClotheWay.ToolStripDropDown.Padding = new System.Windows.Forms.Padding(0);
            this.cbGetClotheWay.ToolStripDropDown.Resizable = false;
            this.cbGetClotheWay.ToolStripDropDown.ResizeGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.cbGetClotheWay.ToolStripDropDown.ResizeGridSize = new System.Drawing.Size(16, 16);
            this.cbGetClotheWay.ToolStripDropDown.Size = new System.Drawing.Size(18, 18);
            this.cbGetClotheWay.ToolStripDropDown.WhereIsResizeGrid = DSkin.ResizeGridLocation.BottomRight;
            // 
            // dtpPlanTakeOff
            // 
            this.dtpPlanTakeOff.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtpPlanTakeOff.Location = new System.Drawing.Point(352, 321);
            this.dtpPlanTakeOff.Name = "dtpPlanTakeOff";
            this.dtpPlanTakeOff.Size = new System.Drawing.Size(186, 29);
            this.dtpPlanTakeOff.TabIndex = 21;
            this.dtpPlanTakeOff.ValueChanged += new System.EventHandler(this.dtpPlanTakeAt_ValueChanged);
            // 
            // txtMark
            // 
            this.txtMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMark.BitmapCache = false;
            this.txtMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMark.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMark.Location = new System.Drawing.Point(352, 445);
            this.txtMark.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(186, 29);
            this.txtMark.TabIndex = 19;
            this.txtMark.TransparencyKey = System.Drawing.Color.White;
            this.txtMark.WaterFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMark.WaterText = "";
            this.txtMark.WaterTextOffset = new System.Drawing.Point(0, 2);
            // 
            // qLabel11
            // 
            this.qLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.qLabel11.ForeColor = System.Drawing.Color.Black;
            this.qLabel11.Location = new System.Drawing.Point(271, 450);
            this.qLabel11.Name = "qLabel11";
            this.qLabel11.Size = new System.Drawing.Size(39, 24);
            this.qLabel11.TabIndex = 20;
            this.qLabel11.Text = "备注";
            // 
            // qLabel10
            // 
            this.qLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.qLabel10.ForeColor = System.Drawing.Color.Black;
            this.qLabel10.Location = new System.Drawing.Point(271, 407);
            this.qLabel10.Name = "qLabel10";
            this.qLabel10.Size = new System.Drawing.Size(72, 24);
            this.qLabel10.TabIndex = 18;
            this.qLabel10.Text = "取衣方式";
            // 
            // qLabel9
            // 
            this.qLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.qLabel9.ForeColor = System.Drawing.Color.Black;
            this.qLabel9.Location = new System.Drawing.Point(271, 364);
            this.qLabel9.Name = "qLabel9";
            this.qLabel9.Size = new System.Drawing.Size(72, 24);
            this.qLabel9.TabIndex = 16;
            this.qLabel9.Text = "收衣方式";
            // 
            // qLabel8
            // 
            this.qLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.qLabel8.ForeColor = System.Drawing.Color.Black;
            this.qLabel8.Location = new System.Drawing.Point(271, 321);
            this.qLabel8.Name = "qLabel8";
            this.qLabel8.Size = new System.Drawing.Size(72, 24);
            this.qLabel8.TabIndex = 14;
            this.qLabel8.Text = "取衣时间";
            // 
            // txtThisMoney
            // 
            this.txtThisMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtThisMoney.BitmapCache = false;
            this.txtThisMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThisMoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtThisMoney.Location = new System.Drawing.Point(352, 282);
            this.txtThisMoney.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.txtThisMoney.Name = "txtThisMoney";
            this.txtThisMoney.ReadOnly = true;
            this.txtThisMoney.Size = new System.Drawing.Size(186, 29);
            this.txtThisMoney.TabIndex = 11;
            this.txtThisMoney.TransparencyKey = System.Drawing.Color.White;
            this.txtThisMoney.WaterFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtThisMoney.WaterText = "";
            this.txtThisMoney.WaterTextOffset = new System.Drawing.Point(0, 2);
            // 
            // qLabel7
            // 
            this.qLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.qLabel7.ForeColor = System.Drawing.Color.Black;
            this.qLabel7.Location = new System.Drawing.Point(271, 287);
            this.qLabel7.Name = "qLabel7";
            this.qLabel7.Size = new System.Drawing.Size(72, 24);
            this.qLabel7.TabIndex = 12;
            this.qLabel7.Text = "本次消费";
            // 
            // txtBalance
            // 
            this.txtBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBalance.BitmapCache = false;
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBalance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBalance.Location = new System.Drawing.Point(352, 243);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(186, 29);
            this.txtBalance.TabIndex = 9;
            this.txtBalance.TransparencyKey = System.Drawing.Color.White;
            this.txtBalance.WaterFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBalance.WaterText = "";
            this.txtBalance.WaterTextOffset = new System.Drawing.Point(0, 2);
            // 
            // qLabel6
            // 
            this.qLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.qLabel6.ForeColor = System.Drawing.Color.Black;
            this.qLabel6.Location = new System.Drawing.Point(271, 248);
            this.qLabel6.Name = "qLabel6";
            this.qLabel6.Size = new System.Drawing.Size(72, 24);
            this.qLabel6.TabIndex = 10;
            this.qLabel6.Text = "卡上余额";
            // 
            // txtAddress
            // 
            this.txtAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddress.BitmapCache = false;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.Location = new System.Drawing.Point(352, 206);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(186, 29);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TransparencyKey = System.Drawing.Color.White;
            this.txtAddress.WaterFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.WaterText = "";
            this.txtAddress.WaterTextOffset = new System.Drawing.Point(0, 2);
            // 
            // qLabel5
            // 
            this.qLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.qLabel5.ForeColor = System.Drawing.Color.Black;
            this.qLabel5.Location = new System.Drawing.Point(271, 211);
            this.qLabel5.Name = "qLabel5";
            this.qLabel5.Size = new System.Drawing.Size(39, 24);
            this.qLabel5.TabIndex = 8;
            this.qLabel5.Text = "地址";
            // 
            // qLabel4
            // 
            this.qLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.qLabel4.ForeColor = System.Drawing.Color.Black;
            this.qLabel4.Location = new System.Drawing.Point(271, 171);
            this.qLabel4.Name = "qLabel4";
            this.qLabel4.Size = new System.Drawing.Size(39, 24);
            this.qLabel4.TabIndex = 6;
            this.qLabel4.Text = "性别";
            // 
            // txtName
            // 
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtName.BitmapCache = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(352, 123);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 29);
            this.txtName.TabIndex = 3;
            this.txtName.TransparencyKey = System.Drawing.Color.White;
            this.txtName.WaterFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.WaterText = "";
            this.txtName.WaterTextOffset = new System.Drawing.Point(0, 2);
            // 
            // qLabel3
            // 
            this.qLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.qLabel3.ForeColor = System.Drawing.Color.Black;
            this.qLabel3.Location = new System.Drawing.Point(271, 128);
            this.qLabel3.Name = "qLabel3";
            this.qLabel3.Size = new System.Drawing.Size(39, 24);
            this.qLabel3.TabIndex = 4;
            this.qLabel3.Text = "姓名";
            // 
            // txtPhone
            // 
            this.txtPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPhone.BitmapCache = false;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.Location = new System.Drawing.Point(352, 86);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(186, 29);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TransparencyKey = System.Drawing.Color.White;
            this.txtPhone.WaterFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.WaterText = "";
            this.txtPhone.WaterTextOffset = new System.Drawing.Point(0, 2);
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // qLabel2
            // 
            this.qLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.qLabel2.ForeColor = System.Drawing.Color.Black;
            this.qLabel2.Location = new System.Drawing.Point(271, 91);
            this.qLabel2.Name = "qLabel2";
            this.qLabel2.Size = new System.Drawing.Size(72, 24);
            this.qLabel2.TabIndex = 2;
            this.qLabel2.Text = "手机号码";
            // 
            // txtVipID
            // 
            this.txtVipID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtVipID.BitmapCache = false;
            this.txtVipID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVipID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVipID.Location = new System.Drawing.Point(352, 43);
            this.txtVipID.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.txtVipID.Name = "txtVipID";
            this.txtVipID.Size = new System.Drawing.Size(186, 29);
            this.txtVipID.TabIndex = 0;
            this.txtVipID.TransparencyKey = System.Drawing.Color.White;
            this.txtVipID.WaterFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVipID.WaterText = "";
            this.txtVipID.WaterTextOffset = new System.Drawing.Point(0, 2);
            this.txtVipID.TextChanged += new System.EventHandler(this.txtVipID_TextChanged);
            // 
            // qLabel1
            // 
            this.qLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.qLabel1.ForeColor = System.Drawing.Color.Black;
            this.qLabel1.Location = new System.Drawing.Point(271, 48);
            this.qLabel1.Name = "qLabel1";
            this.qLabel1.Size = new System.Drawing.Size(72, 24);
            this.qLabel1.TabIndex = 0;
            this.qLabel1.Text = "会员卡号";
            // 
            // dSkinTabPage3
            // 
            this.dSkinTabPage3.BackColor = System.Drawing.Color.White;
            this.dSkinTabPage3.Controls.Add(this.ticketViewBox);
            this.dSkinTabPage3.Controls.Add(this.btnPay);
            this.dSkinTabPage3.Controls.Add(this.btnPrint);
            this.dSkinTabPage3.Controls.Add(this.btnSave);
            this.dSkinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinTabPage3.Location = new System.Drawing.Point(0, 36);
            this.dSkinTabPage3.Name = "dSkinTabPage3";
            this.dSkinTabPage3.Size = new System.Drawing.Size(796, 495);
            this.dSkinTabPage3.TabIndex = 2;
            this.dSkinTabPage3.TabItemImage = null;
            this.dSkinTabPage3.Text = "操作";
            // 
            // ticketViewBox
            // 
            this.ticketViewBox.AutoScroll = true;
            this.ticketViewBox.BackColor = System.Drawing.Color.Transparent;
            this.ticketViewBox.Borders.AllColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ticketViewBox.Borders.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ticketViewBox.Borders.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ticketViewBox.Borders.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ticketViewBox.Borders.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ticketViewBox.Location = new System.Drawing.Point(6, 6);
            this.ticketViewBox.Margin = new System.Windows.Forms.Padding(6);
            this.ticketViewBox.Name = "ticketViewBox";
            this.ticketViewBox.RightBottom = ((System.Drawing.Image)(resources.GetObject("ticketViewBox.RightBottom")));
            this.ticketViewBox.Size = new System.Drawing.Size(256, 483);
            this.ticketViewBox.TabIndex = 3;
            // 
            // btnPay
            // 
            this.btnPay.AdaptImage = true;
            this.btnPay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnPay.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnPay.ButtonBorderWidth = 1;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPay.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnPay.HoverImage = null;
            this.btnPay.IsPureColor = true;
            this.btnPay.Location = new System.Drawing.Point(596, 302);
            this.btnPay.Name = "btnPay";
            this.btnPay.NormalImage = null;
            this.btnPay.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnPay.PressedImage = null;
            this.btnPay.Radius = 4;
            this.btnPay.ShowButtonBorder = true;
            this.btnPay.Size = new System.Drawing.Size(140, 50);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "收费";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPay.TextPadding = 0;
            this.btnPay.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AdaptImage = true;
            this.btnPrint.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnPrint.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnPrint.ButtonBorderWidth = 1;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnPrint.HoverImage = null;
            this.btnPrint.IsPureColor = true;
            this.btnPrint.Location = new System.Drawing.Point(596, 217);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.NormalImage = null;
            this.btnPrint.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnPrint.PressedImage = null;
            this.btnPrint.Radius = 4;
            this.btnPrint.ShowButtonBorder = true;
            this.btnPrint.Size = new System.Drawing.Size(140, 50);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "打印";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.TextPadding = 0;
            this.btnPrint.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnPrint.Click += new System.EventHandler(this.btnPrintTicketView_Click);
            // 
            // btnSave
            // 
            this.btnSave.AdaptImage = true;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnSave.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnSave.ButtonBorderWidth = 1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnSave.HoverImage = null;
            this.btnSave.IsPureColor = true;
            this.btnSave.Location = new System.Drawing.Point(596, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalImage = null;
            this.btnSave.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btnSave.PressedImage = null;
            this.btnSave.Radius = 4;
            this.btnSave.ShowButtonBorder = true;
            this.btnSave.Size = new System.Drawing.Size(140, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextPadding = 0;
            this.btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnSave.Click += new System.EventHandler(this.btnSaveTicket_Click);
            // 
            // LaundryTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 564);
            this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("LaundryTicketForm.CloseBox.HoverImage")));
            this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("LaundryTicketForm.CloseBox.NormalImage")));
            this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("LaundryTicketForm.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(25, 26);
            this.Controls.Add(this.tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("LaundryTicketForm.MaxBox.HoverImage")));
            this.MaxBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("LaundryTicketForm.MaxBox.NormalImage")));
            this.MaxBox.PressImage = ((System.Drawing.Image)(resources.GetObject("LaundryTicketForm.MaxBox.PressImage")));
            this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("LaundryTicketForm.MinBox.HoverImage")));
            this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("LaundryTicketForm.MinBox.NormalImage")));
            this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("LaundryTicketForm.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(25, 26);
            this.Name = "LaundryTicketForm";
            this.Text = "开单";
            this.Load += new System.EventHandler(this.LaundryTicket_Load);
            this.tab.ResumeLayout(false);
            this.dSkinTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glClothe)).EndInit();
            this.dSkinTabPage2.ResumeLayout(false);
            this.dSkinTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender.InnerListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTakeOffWay.InnerListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGetClotheWay.InnerListBox)).EndInit();
            this.dSkinTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UI.Q.Controls.QTabControl tab;
        private DSkin.Controls.DSkinTabPage dSkinTabPage1;
        private DSkin.Controls.DSkinTabPage dSkinTabPage2;
        private UI.Q.Controls.QLabel qLabel1;
        private DSkin.Controls.DSkinTabPage dSkinTabPage3;
        private UI.Q.Controls.QBigButton btnDeleteClothe;
        private UI.Q.Controls.QBigButton btnEditClothe;
        private UI.Q.Controls.QBigButton btnAddClothe;
        private UI.Q.Controls.QTextBox txtMark;
        private UI.Q.Controls.QLabel qLabel11;
        private UI.Q.Controls.QLabel qLabel10;
        private UI.Q.Controls.QLabel qLabel9;
        private UI.Q.Controls.QLabel qLabel8;
        private UI.Q.Controls.QTextBox txtThisMoney;
        private UI.Q.Controls.QLabel qLabel7;
        private UI.Q.Controls.QTextBox txtBalance;
        private UI.Q.Controls.QLabel qLabel6;
        private UI.Q.Controls.QTextBox txtAddress;
        private UI.Q.Controls.QLabel qLabel5;
        private UI.Q.Controls.QLabel qLabel4;
        private UI.Q.Controls.QTextBox txtName;
        private UI.Q.Controls.QLabel qLabel3;
        private UI.Q.Controls.QTextBox txtPhone;
        private UI.Q.Controls.QLabel qLabel2;
        private UI.Q.Controls.QTextBox txtVipID;
        private UI.Q.Controls.QBigButton btnPay;
        private UI.Q.Controls.QBigButton btnPrint;
        private UI.Q.Controls.QBigButton btnSave;
        private UI.Q.Controls.QGridList glClothe;
        private UI.Q.Controls.QDateTimePicker dtpPlanTakeOff;
        private LibCore.Forms.TicketViewBox ticketViewBox;
        private UI.Q.Controls.QComboBox cbTakeOffWay;
        private UI.Q.Controls.QComboBox cbGetClotheWay;
        private UI.Q.Controls.QComboBox txtGender;
    }
}

