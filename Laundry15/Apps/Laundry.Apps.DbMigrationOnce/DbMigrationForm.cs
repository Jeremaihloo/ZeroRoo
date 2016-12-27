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
        private bool hasStarted = false;

        public bool HasFinish { get; set; }

        bool debug = false;
        public void SetDebug(bool value)
        {
            this.debug = value;
        }

        private DbMigration.Migration op = new DbMigration.Migration();

        private bool canMigration()
        {
            if (debug)
                return true;

            if(!File.Exists("migration.lock"))
            {
                return true;
            }

            return false;
        }

        void Do()
        {
            this.hasStarted = true;
            this.op.DoMigration();
        }

        private void Op_LogHandler(object sender, string e)
        {
            this.BeginInvoke(new Action(()=>
            {
                this.pbStatus.Value += 100 / op.StepCount();

                this.lblStatus.Text = e;

                if (this.pbStatus.Value >= 100)
                {
                    File.WriteAllText("migration.lock", DateTime.Now.ToString(), Encoding.Default);
                    this.HasFinish = true;
                    this.btnMain.Text = "查看日志";
                }
            }));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (this.hasStarted  && !this.HasFinish)
            {
                e.Cancel = true;
                QMessageBox.Show("数据迁移工作正在进行中，不能关闭窗口！");
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            if (this.canMigration())
            {
                this.pbStatus.Maximum = 100;

                this.op.LogHandler += Op_LogHandler;

                new Thread(Do).Start();
            }
            else
            {
                QMessageBox.Show("你可能已经执行过数据迁移，不能重复进行这个操作！");
            }
        }
    }
}
