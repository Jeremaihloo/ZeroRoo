using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using SQLitePCL;

namespace ZeroRoo.Running
{
    class MainClass
    {
        public static IServiceCollection Services;
        public static IServiceProvider ServiceProvider;

        public static void Main(string[] args)
        {
            SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());

            var env = new ZeroRoo.ZeroRuntimeEnviroment()
            {
                RootFileProvider =
                    new PhysicalFileProvider(Directory.GetCurrentDirectory())
            };

            Services = new ServiceCollection()
                .AddEnviroment(env);

            ServiceProvider = Services.UseStartup(new Startup(env));

            Console.ReadKey();
        }
    }
}
