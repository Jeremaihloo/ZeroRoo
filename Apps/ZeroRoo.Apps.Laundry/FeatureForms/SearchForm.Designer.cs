namespace Laundry.Apps.Search
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn1 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn2 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn3 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn4 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn5 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn6 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn7 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn8 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn9 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn10 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn11 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn12 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn13 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn14 = new DSkin.Controls.DSkinGridListColumn();
            this.tlpMain = new UI.Q.Controls.QTableLayoutPanel();
            this.lvUsers = new UI.Q.Controls.QGridList();
            this.lvTickets = new UI.Q.Controls.QGridList();
            this.txtSearch = new UI.Q.Controls.QTextBox();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.White;
            this.tlpMain.BitmapCache = false;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lvUsers, 0, 1);
            this.tlpMain.Controls.Add(this.lvTickets, 0, 2);
            this.tlpMain.Controls.Add(this.txtSearch, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(4, 29);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RightBottom = ((System.Drawing.Image)(resources.GetObject("tlpMain.RightBottom")));
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(905, 564);
            this.tlpMain.TabIndex = 2;
            // 
            // lvUsers
            // 
            // 
            // 
            // 
            this.lvUsers.BackPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lvUsers.BackPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvUsers.BackPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvUsers.BackPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvUsers.BackPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvUsers.BackPageButton.IsPureColor = true;
            this.lvUsers.BackPageButton.Location = new System.Drawing.Point(743, 4);
            this.lvUsers.BackPageButton.Name = "BtnBackPage";
            this.lvUsers.BackPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lvUsers.BackPageButton.Radius = 0;
            this.lvUsers.BackPageButton.Size = new System.Drawing.Size(50, 24);
            this.lvUsers.BackPageButton.Text = "上一页";
            this.lvUsers.BackPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lvUsers.BackPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.lvUsers.Borders.AllColor = System.Drawing.Color.Silver;
            this.lvUsers.Borders.BottomColor = System.Drawing.Color.Silver;
            this.lvUsers.Borders.LeftColor = System.Drawing.Color.Silver;
            this.lvUsers.Borders.RightColor = System.Drawing.Color.Silver;
            this.lvUsers.Borders.TopColor = System.Drawing.Color.Silver;
            this.lvUsers.ColumnHeight = 30;
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
            dSkinGridListColumn1.Item.Text = "会员编号";
            dSkinGridListColumn1.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn1.Name = "会员编号";
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
            dSkinGridListColumn2.Item.Text = "姓名";
            dSkinGridListColumn2.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn2.Name = "姓名";
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
            dSkinGridListColumn3.Item.Text = "电话";
            dSkinGridListColumn3.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn3.Name = "电话";
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
            dSkinGridListColumn4.Item.Text = "地址";
            dSkinGridListColumn4.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn4.Name = "地址";
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
            dSkinGridListColumn5.Item.Text = "性别";
            dSkinGridListColumn5.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn5.Name = "性别";
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
            dSkinGridListColumn6.Item.Text = "余额";
            dSkinGridListColumn6.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn6.Name = "余额";
            dSkinGridListColumn6.Visble = true;
            dSkinGridListColumn6.Width = 80;
            // 
            // 
            // 
            dSkinGridListColumn7.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn7.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn7.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn7.Item.Location = new System.Drawing.Point(480, 0);
            dSkinGridListColumn7.Item.Name = "";
            dSkinGridListColumn7.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn7.Item.Tag = dSkinGridListColumn7;
            dSkinGridListColumn7.Item.Text = "消费总额";
            dSkinGridListColumn7.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn7.Name = "消费总额";
            dSkinGridListColumn7.Visble = true;
            dSkinGridListColumn7.Width = 80;
            // 
            // 
            // 
            dSkinGridListColumn8.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn8.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn8.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn8.Item.Location = new System.Drawing.Point(560, 0);
            dSkinGridListColumn8.Item.Name = "";
            dSkinGridListColumn8.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn8.Item.Tag = dSkinGridListColumn8;
            dSkinGridListColumn8.Item.Text = "衣单总数";
            dSkinGridListColumn8.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn8.Name = "衣单总数";
            dSkinGridListColumn8.Visble = true;
            dSkinGridListColumn8.Width = 80;
            // 
            // 
            // 
            dSkinGridListColumn9.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn9.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn9.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn9.Item.Location = new System.Drawing.Point(640, 0);
            dSkinGridListColumn9.Item.Name = "";
            dSkinGridListColumn9.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn9.Item.Tag = dSkinGridListColumn9;
            dSkinGridListColumn9.Item.Text = "衣服总数";
            dSkinGridListColumn9.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn9.Name = "衣服总数";
            dSkinGridListColumn9.Visble = true;
            dSkinGridListColumn9.Width = 80;
            this.lvUsers.Columns.AddRange(new DSkin.Controls.DSkinGridListColumn[] {
            dSkinGridListColumn1,
            dSkinGridListColumn2,
            dSkinGridListColumn3,
            dSkinGridListColumn4,
            dSkinGridListColumn5,
            dSkinGridListColumn6,
            dSkinGridListColumn7,
            dSkinGridListColumn8,
            dSkinGridListColumn9});
            this.lvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUsers.DoubleItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lvUsers.EnabledOrder = false;
            // 
            // 
            // 
            this.lvUsers.FirstPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lvUsers.FirstPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvUsers.FirstPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvUsers.FirstPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvUsers.FirstPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvUsers.FirstPageButton.IsPureColor = true;
            this.lvUsers.FirstPageButton.Location = new System.Drawing.Point(695, 4);
            this.lvUsers.FirstPageButton.Name = "BtnFistPage";
            this.lvUsers.FirstPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lvUsers.FirstPageButton.Radius = 0;
            this.lvUsers.FirstPageButton.Size = new System.Drawing.Size(44, 24);
            this.lvUsers.FirstPageButton.Text = "首页";
            this.lvUsers.FirstPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lvUsers.FirstPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // 
            // 
            this.lvUsers.GoPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lvUsers.GoPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvUsers.GoPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvUsers.GoPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvUsers.GoPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvUsers.GoPageButton.IsPureColor = true;
            this.lvUsers.GoPageButton.Location = new System.Drawing.Point(290, 4);
            this.lvUsers.GoPageButton.Name = "BtnGoPage";
            this.lvUsers.GoPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lvUsers.GoPageButton.Radius = 0;
            this.lvUsers.GoPageButton.Size = new System.Drawing.Size(44, 24);
            this.lvUsers.GoPageButton.Text = "跳转";
            this.lvUsers.GoPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lvUsers.GoPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.lvUsers.GridLineColor = System.Drawing.Color.Silver;
            this.lvUsers.HeaderFont = new System.Drawing.Font("微软雅黑", 9F);
            // 
            // 
            // 
            this.lvUsers.HScrollBar.AutoSize = false;
            this.lvUsers.HScrollBar.Fillet = true;
            this.lvUsers.HScrollBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvUsers.HScrollBar.Location = new System.Drawing.Point(0, 101);
            this.lvUsers.HScrollBar.Maximum = 368;
            this.lvUsers.HScrollBar.Name = "";
            this.lvUsers.HScrollBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.lvUsers.HScrollBar.ScrollBarLenght = 148;
            this.lvUsers.HScrollBar.ScrollBarPartitionWidth = new System.Windows.Forms.Padding(5);
            this.lvUsers.HScrollBar.Size = new System.Drawing.Size(899, 12);
            this.lvUsers.HScrollBar.Visible = false;
            // 
            // 
            // 
            this.lvUsers.LastPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lvUsers.LastPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvUsers.LastPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvUsers.LastPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvUsers.LastPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvUsers.LastPageButton.IsPureColor = true;
            this.lvUsers.LastPageButton.Location = new System.Drawing.Point(851, 4);
            this.lvUsers.LastPageButton.Name = "BtnLastPage";
            this.lvUsers.LastPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lvUsers.LastPageButton.Radius = 0;
            this.lvUsers.LastPageButton.Size = new System.Drawing.Size(44, 24);
            this.lvUsers.LastPageButton.Text = "末页";
            this.lvUsers.LastPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lvUsers.LastPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.lvUsers.Location = new System.Drawing.Point(3, 43);
            this.lvUsers.Name = "lvUsers";
            // 
            // 
            // 
            this.lvUsers.NextPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lvUsers.NextPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvUsers.NextPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvUsers.NextPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvUsers.NextPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvUsers.NextPageButton.IsPureColor = true;
            this.lvUsers.NextPageButton.Location = new System.Drawing.Point(797, 4);
            this.lvUsers.NextPageButton.Name = "BtnNextPage";
            this.lvUsers.NextPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lvUsers.NextPageButton.Radius = 0;
            this.lvUsers.NextPageButton.Size = new System.Drawing.Size(50, 24);
            this.lvUsers.NextPageButton.Text = "下一页";
            this.lvUsers.NextPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lvUsers.NextPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.lvUsers.SelectedItem = null;
            this.lvUsers.Size = new System.Drawing.Size(899, 256);
            this.lvUsers.TabIndex = 1;
            this.lvUsers.Text = "qGridList1";
            // 
            // 
            // 
            this.lvUsers.VScrollBar.AutoSize = false;
            this.lvUsers.VScrollBar.BitmapCache = true;
            this.lvUsers.VScrollBar.Fillet = true;
            this.lvUsers.VScrollBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvUsers.VScrollBar.LargeChange = 1000;
            this.lvUsers.VScrollBar.Location = new System.Drawing.Point(886, 1);
            this.lvUsers.VScrollBar.Margin = new System.Windows.Forms.Padding(1);
            this.lvUsers.VScrollBar.Maximum = 10000;
            this.lvUsers.VScrollBar.Name = "";
            this.lvUsers.VScrollBar.ScrollBarPartitionWidth = new System.Windows.Forms.Padding(5);
            this.lvUsers.VScrollBar.Size = new System.Drawing.Size(12, 191);
            this.lvUsers.VScrollBar.SmallChange = 500;
            this.lvUsers.VScrollBar.Visible = false;
            // 
            // lvTickets
            // 
            // 
            // 
            // 
            this.lvTickets.BackPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lvTickets.BackPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvTickets.BackPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvTickets.BackPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvTickets.BackPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvTickets.BackPageButton.IsPureColor = true;
            this.lvTickets.BackPageButton.Location = new System.Drawing.Point(743, 4);
            this.lvTickets.BackPageButton.Name = "BtnBackPage";
            this.lvTickets.BackPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lvTickets.BackPageButton.Radius = 0;
            this.lvTickets.BackPageButton.Size = new System.Drawing.Size(50, 24);
            this.lvTickets.BackPageButton.Text = "上一页";
            this.lvTickets.BackPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lvTickets.BackPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.lvTickets.Borders.AllColor = System.Drawing.Color.Silver;
            this.lvTickets.Borders.BottomColor = System.Drawing.Color.Silver;
            this.lvTickets.Borders.LeftColor = System.Drawing.Color.Silver;
            this.lvTickets.Borders.RightColor = System.Drawing.Color.Silver;
            this.lvTickets.Borders.TopColor = System.Drawing.Color.Silver;
            this.lvTickets.ColumnHeight = 30;
            // 
            // 
            // 
            dSkinGridListColumn10.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn10.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn10.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn10.Item.Location = new System.Drawing.Point(0, 0);
            dSkinGridListColumn10.Item.Name = "";
            dSkinGridListColumn10.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn10.Item.Tag = dSkinGridListColumn10;
            dSkinGridListColumn10.Item.Text = "姓名";
            dSkinGridListColumn10.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn10.Name = "姓名";
            dSkinGridListColumn10.Visble = true;
            dSkinGridListColumn10.Width = 80;
            // 
            // 
            // 
            dSkinGridListColumn11.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn11.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn11.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn11.Item.Location = new System.Drawing.Point(80, 0);
            dSkinGridListColumn11.Item.Name = "";
            dSkinGridListColumn11.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn11.Item.Tag = dSkinGridListColumn11;
            dSkinGridListColumn11.Item.Text = "电话";
            dSkinGridListColumn11.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn11.Name = "电话";
            dSkinGridListColumn11.Visble = true;
            dSkinGridListColumn11.Width = 80;
            // 
            // 
            // 
            dSkinGridListColumn12.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn12.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn12.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn12.Item.Location = new System.Drawing.Point(160, 0);
            dSkinGridListColumn12.Item.Name = "";
            dSkinGridListColumn12.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn12.Item.Tag = dSkinGridListColumn12;
            dSkinGridListColumn12.Item.Text = "衣服数量";
            dSkinGridListColumn12.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn12.Name = "衣服数量";
            dSkinGridListColumn12.Visble = true;
            dSkinGridListColumn12.Width = 80;
            // 
            // 
            // 
            dSkinGridListColumn13.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn13.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn13.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn13.Item.Location = new System.Drawing.Point(240, 0);
            dSkinGridListColumn13.Item.Name = "";
            dSkinGridListColumn13.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn13.Item.Tag = dSkinGridListColumn13;
            dSkinGridListColumn13.Item.Text = "已洗";
            dSkinGridListColumn13.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn13.Name = "已洗";
            dSkinGridListColumn13.Visble = true;
            dSkinGridListColumn13.Width = 80;
            // 
            // 
            // 
            dSkinGridListColumn14.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn14.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn14.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn14.Item.Location = new System.Drawing.Point(320, 0);
            dSkinGridListColumn14.Item.Name = "";
            dSkinGridListColumn14.Item.Size = new System.Drawing.Size(80, 30);
            dSkinGridListColumn14.Item.Tag = dSkinGridListColumn14;
            dSkinGridListColumn14.Item.Text = "付款状态";
            dSkinGridListColumn14.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn14.Name = "付款状态";
            dSkinGridListColumn14.Visble = true;
            dSkinGridListColumn14.Width = 80;
            this.lvTickets.Columns.AddRange(new DSkin.Controls.DSkinGridListColumn[] {
            dSkinGridListColumn10,
            dSkinGridListColumn11,
            dSkinGridListColumn12,
            dSkinGridListColumn13,
            dSkinGridListColumn14});
            this.lvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTickets.DoubleItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lvTickets.EnabledOrder = false;
            // 
            // 
            // 
            this.lvTickets.FirstPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lvTickets.FirstPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvTickets.FirstPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvTickets.FirstPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvTickets.FirstPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvTickets.FirstPageButton.IsPureColor = true;
            this.lvTickets.FirstPageButton.Location = new System.Drawing.Point(695, 4);
            this.lvTickets.FirstPageButton.Name = "BtnFistPage";
            this.lvTickets.FirstPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lvTickets.FirstPageButton.Radius = 0;
            this.lvTickets.FirstPageButton.Size = new System.Drawing.Size(44, 24);
            this.lvTickets.FirstPageButton.Text = "首页";
            this.lvTickets.FirstPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lvTickets.FirstPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // 
            // 
            this.lvTickets.GoPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lvTickets.GoPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvTickets.GoPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvTickets.GoPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvTickets.GoPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvTickets.GoPageButton.IsPureColor = true;
            this.lvTickets.GoPageButton.Location = new System.Drawing.Point(290, 4);
            this.lvTickets.GoPageButton.Name = "BtnGoPage";
            this.lvTickets.GoPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lvTickets.GoPageButton.Radius = 0;
            this.lvTickets.GoPageButton.Size = new System.Drawing.Size(44, 24);
            this.lvTickets.GoPageButton.Text = "跳转";
            this.lvTickets.GoPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lvTickets.GoPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.lvTickets.GridLineColor = System.Drawing.Color.Silver;
            this.lvTickets.HeaderFont = new System.Drawing.Font("微软雅黑", 9F);
            // 
            // 
            // 
            this.lvTickets.HScrollBar.AutoSize = false;
            this.lvTickets.HScrollBar.Fillet = true;
            this.lvTickets.HScrollBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvTickets.HScrollBar.Location = new System.Drawing.Point(0, 101);
            this.lvTickets.HScrollBar.Maximum = 203;
            this.lvTickets.HScrollBar.Name = "";
            this.lvTickets.HScrollBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.lvTickets.HScrollBar.ScrollBarLenght = 136;
            this.lvTickets.HScrollBar.ScrollBarPartitionWidth = new System.Windows.Forms.Padding(5);
            this.lvTickets.HScrollBar.Size = new System.Drawing.Size(899, 12);
            this.lvTickets.HScrollBar.Visible = false;
            // 
            // 
            // 
            this.lvTickets.LastPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lvTickets.LastPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvTickets.LastPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvTickets.LastPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvTickets.LastPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvTickets.LastPageButton.IsPureColor = true;
            this.lvTickets.LastPageButton.Location = new System.Drawing.Point(851, 4);
            this.lvTickets.LastPageButton.Name = "BtnLastPage";
            this.lvTickets.LastPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lvTickets.LastPageButton.Radius = 0;
            this.lvTickets.LastPageButton.Size = new System.Drawing.Size(44, 24);
            this.lvTickets.LastPageButton.Text = "末页";
            this.lvTickets.LastPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lvTickets.LastPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.lvTickets.Location = new System.Drawing.Point(3, 305);
            this.lvTickets.Name = "lvTickets";
            // 
            // 
            // 
            this.lvTickets.NextPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lvTickets.NextPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvTickets.NextPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvTickets.NextPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvTickets.NextPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.lvTickets.NextPageButton.IsPureColor = true;
            this.lvTickets.NextPageButton.Location = new System.Drawing.Point(797, 4);
            this.lvTickets.NextPageButton.Name = "BtnNextPage";
            this.lvTickets.NextPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lvTickets.NextPageButton.Radius = 0;
            this.lvTickets.NextPageButton.Size = new System.Drawing.Size(50, 24);
            this.lvTickets.NextPageButton.Text = "下一页";
            this.lvTickets.NextPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lvTickets.NextPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.lvTickets.SelectedItem = null;
            this.lvTickets.Size = new System.Drawing.Size(899, 256);
            this.lvTickets.TabIndex = 2;
            this.lvTickets.Text = "qGridList2";
            // 
            // 
            // 
            this.lvTickets.VScrollBar.AutoSize = false;
            this.lvTickets.VScrollBar.BitmapCache = true;
            this.lvTickets.VScrollBar.Fillet = true;
            this.lvTickets.VScrollBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvTickets.VScrollBar.LargeChange = 1000;
            this.lvTickets.VScrollBar.Location = new System.Drawing.Point(886, 1);
            this.lvTickets.VScrollBar.Margin = new System.Windows.Forms.Padding(1);
            this.lvTickets.VScrollBar.Maximum = 10000;
            this.lvTickets.VScrollBar.Name = "";
            this.lvTickets.VScrollBar.ScrollBarPartitionWidth = new System.Windows.Forms.Padding(5);
            this.lvTickets.VScrollBar.Size = new System.Drawing.Size(12, 191);
            this.lvTickets.VScrollBar.SmallChange = 500;
            this.lvTickets.VScrollBar.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearch.BitmapCache = false;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearch.Location = new System.Drawing.Point(3, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(899, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TransparencyKey = System.Drawing.Color.White;
            this.txtSearch.WaterFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSearch.WaterText = "输入用户姓名、会员编号、手机号码、衣单号码";
            this.txtSearch.WaterTextOffset = new System.Drawing.Point(0, 2);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 597);
            this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("SearchForm.CloseBox.HoverImage")));
            this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("SearchForm.CloseBox.NormalImage")));
            this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("SearchForm.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(25, 26);
            this.Controls.Add(this.tlpMain);
            this.MaxBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("SearchForm.MaxBox.HoverImage")));
            this.MaxBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("SearchForm.MaxBox.NormalImage")));
            this.MaxBox.PressImage = ((System.Drawing.Image)(resources.GetObject("SearchForm.MaxBox.PressImage")));
            this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("SearchForm.MinBox.HoverImage")));
            this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("SearchForm.MinBox.NormalImage")));
            this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("SearchForm.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(25, 26);
            this.Name = "SearchForm";
            this.Text = "搜索";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Q.Controls.QTableLayoutPanel tlpMain;
        private UI.Q.Controls.QTextBox txtSearch;
        private UI.Q.Controls.QGridList lvUsers;
        private UI.Q.Controls.QGridList lvTickets;
    }
}