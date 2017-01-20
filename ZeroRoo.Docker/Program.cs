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
        public static IRuntime Runtime { get; set; }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var env = new ZeroRoo.ZeroRuntimeEnviroment()
            {
                RootFileProvider =
                    new PhysicalFileProvider(Directory.GetCurrentDirectory())
            };

            Runtime = new RuntimeBuilder()
                .UseEnviroment(env)
                .UseStartup(new Startup(env))
                .Build();

            Runtime.RunForm<Dashboard>();
        }
    }
}
