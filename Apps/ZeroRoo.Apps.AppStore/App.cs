﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.App;

namespace ZeroRoo.Apps.AppStore
{
    public class App : IApp
    {
        public event EventHandler Stop;

        public void OnStart(IAppEnviroment env, AppSystem system)
        {
            Form1 form = new Form1();
            form.Show();
        }

        public void OnStop(IAppEnviroment env, AppSystem system, AppStopEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnWakeUp(IAppEnviroment env, AppSystem system)
        {
            throw new NotImplementedException();
        }
    }
}
