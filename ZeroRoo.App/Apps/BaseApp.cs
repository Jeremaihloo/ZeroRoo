using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps
{
    public class BaseApp : IApp
    {
        public virtual event EventHandler Stopping;

        public virtual void OnStart()
        {
            
        }

        public virtual void OnStop(AppStopEventArgs e)
        {
            
        }

        public virtual void OnWakeUp()
        {
            
        }

        public virtual void Stop()
        {
            this.Stopping?.Invoke(this, new EventArgs());
        }
    }
}
