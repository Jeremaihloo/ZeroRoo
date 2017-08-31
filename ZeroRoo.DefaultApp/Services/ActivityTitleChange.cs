﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;

namespace ZeroRoo.DefaultApp.Services
{
    public class ActivityTitleChange : IAppService
    {
        public void OnService(AppServiceRoute route, AppServiceMessage msg)
        {
            route.SendMessage(msg);
        }
    }
}
