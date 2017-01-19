using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroRoo;
using Microsoft.Extensions.DependencyInjection;
using ZeroRoo.Docker.Core;
using Microsoft.Extensions.FileProviders;
using System.IO;
using ZeroRoo.Apps;
using ZeroRoo.Apps.Abstractions;
using System.Linq;
using System.Collections.Generic;
using ZeroRoo.Docker;
using System.Reflection;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    public class ZeroRooTests
    {
        [TestMethod]
        public void RuntimeTests()
        {
            var env = new ZeroRoo.ZeroRuntimeEnviroment()
            {
                RootFileProvider = 
                    new PhysicalFileProvider(Directory.GetCurrentDirectory())
            };

            var runtime = new RuntimeBuilder()
                .UseEnviroment(env)
                .UseStartup(new Startup(env))
                .Build();

            runtime.Run();

            var provider = runtime.Services.BuildServiceProvider();
            var appManager = runtime.Services.BuildServiceProvider().GetRequiredService<IAppManager>();

            Assert.AreEqual("ZeroRoo", provider.GetService<IRuntimeEnviroment>().ApplicationName);
            var apps = appManager.GetApps();
            Assert.AreEqual(1, apps.Count());
            var appFirst = apps.ToList()[0];
            var entryTask = appManager.LoadAppAsync(appFirst);
            entryTask.Wait();
            var entry = entryTask.Result;
            Assert.IsNotNull(entry.Assembly);
        }

        [TestMethod]
        public void RefTests()
        {
            var list = AppDomain.CurrentDomain.GetAssemblies().Select(item => item.FullName).ToArray();
            Assert.AreNotEqual(0, list);
        }

        [TestMethod]
        public void AssemblyLoad()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            var refs = AppDomain.CurrentDomain.GetAssemblies();
            var assembly = Assembly.ReflectionOnlyLoadFrom("Apps/Sample1/Sample1.dll");
            Assert.AreNotEqual(0, assembly.ExportedTypes);
        }

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            Trace.WriteLine(args.Name);
            return args.RequestingAssembly;
        }

        [TestMethod]
        public void IAssiTest()
        {
            Assert.IsTrue(typeof(IStartup).IsAssignableFrom(typeof(TAClass)));
        }

        public class TAClass: StartupBase
        {

        }
    }
}
