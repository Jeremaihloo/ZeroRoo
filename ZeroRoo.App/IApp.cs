using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.App
{
    public interface IApp
    {
        void OnStart(IAppEnviroment env, AppSystem system);

        void OnWakeUp(IAppEnviroment env, AppSystem system);

        void OnStop(IAppEnviroment env, AppSystem system, AppStopEventArgs e);

        event EventHandler Stop;
    }
}
