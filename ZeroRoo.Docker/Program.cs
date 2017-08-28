using CefSharp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeroRoo.Docker.Core;
using ZeroRoo.Docker.Shapes;

namespace ZeroRoo.Docker
{
    static class Program
    {
        public static IServiceCollection Services;
        public static IServiceProvider ServiceProvider;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //For Windows 7 and above, best to include relevant app.manifest entries as well
            Cef.EnableHighDPISupport();

            var settings = new CefSettings()
            {
                //By default CefSharp will use an in-memory cache, you need to specify a Cache Folder to persist data
                CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache"),
                RemoteDebuggingPort = 8088
            };

            //Perform dependency check to make sure all relevant resources are in our output directory.
            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);


            var env = new ZeroRoo.ZeroRuntimeEnviroment()
            {
                RootFileProvider =
                    new PhysicalFileProvider(Directory.GetCurrentDirectory())
            };

            Services = new ServiceCollection()
                .AddEnviroment(env);

            ServiceProvider = Services.UseStartup(new Startup(env));
            
            ServiceProvider.RunForm<Dashboard>();

            Application.ApplicationExit += Application_ApplicationExit;
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
