using ZeroRoo.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry.Apps.Settings
{
    public class App : WindowApp
    {
        public event EventHandler Stopping;

        public void OnStart()
        {
            LaundrySettings form = new LaundrySettings();
            this.SetWindow(form);
        }

        public void OnStop(AppStopEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnWakeUp()
        {
            throw new NotImplementedException();
        }
    }
}
