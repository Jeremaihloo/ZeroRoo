using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.App
{
    public interface IApp
    {
        void OnStart();

        void OnWakeUp();

        void OnStop(AppStopEventArgs e);

        event EventHandler Stopping;

        void Stop();
    }
}
