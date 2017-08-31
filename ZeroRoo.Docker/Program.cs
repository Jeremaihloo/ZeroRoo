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
                RemoteDebuggingPort = 8088,
                //浏览器引擎的语言
                AcceptLanguageList = "zh-CN,zh;q=0.8",
                //日志文件
                LogFile = "/LogData",
                PersistSessionCookies = true,
                UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36",
                UserDataPath = "/userData"
            };
            //if(!File.Exists("PepperFlash/26.0.0.151/pepflashplayer.dll"))
            //{
            //    throw new Exception("sffs");
            //}
            //settings.CefCommandLineArgs.Add("ppapi-flash-path", "PepperFlash/26.0.0.151/pepflashplayer.dll");
            //settings.CefCommandLineArgs.Add("ppapi-flash-version", "26.0.0.151");

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
