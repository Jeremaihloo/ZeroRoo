using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.App
{
    public class TraditionalApp : IApp
    {
        public event EventHandler Stopping;

        public void OnStart()
        {
            throw new NotImplementedException();
        }

        public void OnStop(AppStopEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnWakeUp()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
