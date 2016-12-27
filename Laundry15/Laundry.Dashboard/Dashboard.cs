using Laundry.LibCore.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeroRoo.App;

namespace Laundry.Dashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void fpApps_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.GetBounds(this.fpApps).Width - this.Width) / 2, 0);

            this.LoadApp();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Location = new Point((Screen.GetBounds(this.fpApps).Width - this.Width) / 2, 0);
        }

        AppManager appManager = new AppManager();

        void LoadApp()
        {
            this.appManager.Init();

            this.appManager.AutoStartApps();

            this.fpApps.Controls.Clear();

            for (var i = 0; i < this.appManager.AppManageItems.Count; i++)
            {
                Button btn = new Button();
                btn.Text = this.appManager.AppManageItems[i].Config.Title;
                btn.Width = 100;
                btn.Height = 100;
                btn.Tag = i;
                btn.Click += Btn_Click;
                btn.Font = new Font("宋体", 12);
                btn.Visible = this.appManager.AppManageItems[i].Config.Visible;
                btn.Enabled = this.appManager.AppManageItems[i].Config.Enable;
                this.fpApps.Controls.Add(btn);
            }
            Button btnClose = new Button();
            btnClose.Text = "退出";
            btnClose.Width = 100;
            btnClose.Height = 100;
            btnClose.Click += BtnClose_Click;
            btnClose.Font = new Font("宋体", 12);
            this.fpApps.Controls.Add(btnClose);
            this.Width = (this.appManager.AppManageItems.Count + 1) * 100 + this.appManager.AppManageItems.Count * 6 + 40 + 10;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var index = (int)btn.Tag;
            this.appManager.StartApp(index);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if(MessageBox.Show("关闭系统前请确定你所有的工作都已经保存！\n点击【确定】退出系统，点击【取消】继续您的工作", "警告", MessageBoxButtons.OKCancel)==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            
        }
    }
}
