using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Q;

namespace Laundry.Apps.DbMigrationOnce
{
    public partial class DbMigrationForm : QForm
    {
        public DbMigrationForm()
        {
            InitializeComponent();
        }

        private DbMigration.Migrator op = new DbMigration.Migrator();

        void Do()
        {
            try
            {
                this.op.DoMigration();
            }
            catch(Exception ex)
            {
                this.BeginInvoke(new Action(() =>
                {
                    this.btnMain.Text = "查看日志";
                    QMessageBox.Show("操作失败，请查看日志");
                }));
            }
        }

        private void Op_LogHandler(object sender, string e)
        {
            this.BeginInvoke(new Action(()=>
            {
                this.pbStatus.Value += 100 / op.StepCount;

                this.lblStatus.Text = e;

                if (this.op.HasFinish)
                {
                    File.WriteAllText("migration.lock", DateTime.Now.ToString(), Encoding.Default);
                    this.btnMain.Text = "查看日志";
                    this.pbStatus.Value = 100;
                }
            }));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (this.op.HasStarted  && !this.op.HasFinish)
            {
                if(QMessageBox.Show("数据迁移工作正在进行中，确定关闭窗口吗！", "警告", MessageBoxButtons.YesNo)== DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            if(!(this.btnMain.Text=="查看日志"))
            {
                this.pbStatus.Maximum = 100;

                this.op.NewStep += Op_LogHandler;

                new Thread(Do).Start();
            }
            else
            {
                this.ShowLog();
            }
        }

        private void ShowLog()
        {

        }

        private void DbMigrationForm_Load(object sender, EventArgs e)
        {
            this.pbStatus.Text = "";
            this.lblStatus.Text = "";
            this.btnMain.Text = "开始";
        }
    }
}
