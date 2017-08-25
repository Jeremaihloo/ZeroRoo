using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;

namespace UnitTestProject
{
    [TestClass]
    public class AppServiceServerTest
    {
        [TestMethod]
        public void TestMain()
        {
            var appServer = new AppServiceServer(null, null, new AppViewRouter(null));
            appServer.Start();
            appServer.SendMessage(new AppServiceMessage("ZeroRoo.Docker.Cores.Services.Open", "http://www.baidu.com"));
            Thread.CurrentThread.Join();
        }
    }
}
