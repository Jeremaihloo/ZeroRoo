using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var appServer = new AppServiceServer(null, null, new AppViewRouter(null));
            appServer.Start();
            while (true)
            {
                appServer.SendMessage(new AppServiceMessage("ZeroRoo.Docker.Cores.Services.Open", "http://www.baidu.com"));
                Thread.Sleep(1000);
            }
        }
    }
}
