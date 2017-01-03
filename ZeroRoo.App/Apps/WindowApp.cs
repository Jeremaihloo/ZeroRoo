using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Q;

namespace ZeroRoo.App
{
    public class WindowApp: BaseApp
    {
        public virtual QForm Window { get; set; }

        public override event EventHandler Stopping;

        public override void OnStart()
        {
            base.OnStart();
            var form = new QForm();
            this.SetWindow(form);
        }

        public virtual void SetWindow(QForm form)
        {
            this.Window = form;
            this.Window.FormClosing += this.WindowFormClosing;
            this.Window.Show();
        }

        public void WindowFormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Stopping(this, new EventArgs());
        }

        public override void OnStop(AppStopEventArgs e)
        {
            base.OnStop(e);
        }

        public override void OnWakeUp()
        {
            base.OnWakeUp();
            this.Window.Activate();
        }
    }
}
