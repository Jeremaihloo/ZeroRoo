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
        public event EventHandler Stop;

        private Process process;

        public void OnStart(IAppEnviroment env, AppSystem system)
        {
            this.process = Process.Start(env.AppConfig.Target);
        }

        public void OnStop(IAppEnviroment env, AppSystem system, AppStopEventArgs e)
        {
            this.process.CloseMainWindow();
            this.process.Kill();
            this.process.Close();
        }

        public void OnWakeUp(IAppEnviroment env, AppSystem system)
        {
            
        }
    }
}
