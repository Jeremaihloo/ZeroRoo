namespace UI.Q.Forms
{
    partial class QSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QSelectorForm));
            this.qTableLayoutPanel1 = new UI.Q.Controls.QTableLayoutPanel();
            this.txtSearch = new UI.Q.Controls.QTextBox();
            this.keySelectBar = new UI.Q.Controls.QKeySelectorBar();
            this.lvSelectData = new UI.Q.Controls.QListBox();
            this.qTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvSelectData)).BeginInit();
            this.SuspendLayout();
            // 
            // qTableLayoutPanel1
            // 
            this.qTableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.qTableLayoutPanel1.BitmapCache = false;
            this.qTableLayoutPanel1.ColumnCount = 1;
            this.qTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.qTableLayoutPanel1.Controls.Add(this.txtSearch, 0, 0);
            this.qTableLayoutPanel1.Controls.Add(this.keySelectBar, 0, 1);
            this.qTableLayoutPanel1.Controls.Add(this.lvSelectData, 0, 2);
            this.qTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qTableLayoutPanel1.Location = new System.Drawing.Point(4, 29);
            this.qTableLayoutPanel1.Name = "qTableLayoutPanel1";
            this.qTableLayoutPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("qTableLayoutPanel1.RightBottom")));
            this.qTableLayoutPanel1.RowCount = 3;
            this.qTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.qTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.qTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.qTableLayoutPanel1.Size = new System.Drawing.Size(321, 584);
            this.qTableLayoutPanel1.TabIndex = 1;
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
            this.txtSearch.Size = new System.Drawing.Size(315, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TransparencyKey = System.Drawing.Color.White;
            this.txtSearch.WaterFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearch.WaterText = "";
            this.txtSearch.WaterTextOffset = new System.Drawing.Point(0, 2);
            // 
            // keySelectBar
            // 
            this.keySelectBar.BackColor = System.Drawing.Color.Transparent;
            this.keySelectBar.BitmapCache = false;
            this.keySelectBar.KeyButtonSize = new System.Drawing.Size(18, 18);
            this.keySelectBar.Keys = new string[] {
        "A",
        "B",
        "C",
        "D",
        "E",
        "F",
        "G",
        "H",
        "I",
        "J",
        "K",
        "L",
        "M",
        "N",
        "O",
        "P",
        "Q",
        "R",
        "S",
        "T",
        "U",
        "V",
        "W",
        "X",
        "Y",
        "Z"};
            this.keySelectBar.Location = new System.Drawing.Point(3, 43);
            this.keySelectBar.Name = "keySelectBar";
            this.keySelectBar.RightBottom = ((System.Drawing.Image)(resources.GetObject("keySelectBar.RightBottom")));
            this.keySelectBar.Size = new System.Drawing.Size(315, 54);
            this.keySelectBar.TabIndex = 1;
            // 
            // lvSelectData
            // 
            this.lvSelectData.BackColor = System.Drawing.Color.Transparent;
            this.lvSelectData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSelectData.Location = new System.Drawing.Point(3, 103);
            this.lvSelectData.Name = "lvSelectData";
            this.lvSelectData.ScrollBarWidth = 12;
            this.lvSelectData.Size = new System.Drawing.Size(315, 478);
            this.lvSelectData.TabIndex = 2;
            this.lvSelectData.Text = "qListBox1";
            this.lvSelectData.Value = 0D;
            // 
            // QSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 617);
            this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("QSelectorForm.CloseBox.HoverImage")));
            this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("QSelectorForm.CloseBox.NormalImage")));
            this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("QSelectorForm.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(25, 26);
            this.Controls.Add(this.qTableLayoutPanel1);
            this.MaxBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("QSelectorForm.MaxBox.HoverImage")));
            this.MaxBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("QSelectorForm.MaxBox.NormalImage")));
            this.MaxBox.PressImage = ((System.Drawing.Image)(resources.GetObject("QSelectorForm.MaxBox.PressImage")));
            this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("QSelectorForm.MinBox.HoverImage")));
            this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("QSelectorForm.MinBox.NormalImage")));
            this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("QSelectorForm.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(25, 26);
            this.Name = "QSelectorForm";
            this.Text = "选择";
            this.qTableLayoutPanel1.ResumeLayout(false);
            this.qTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvSelectData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.QTableLayoutPanel qTableLayoutPanel1;
        private Controls.QTextBox txtSearch;
        private Controls.QKeySelectorBar keySelectBar;
        private Controls.QListBox lvSelectData;
    }
}