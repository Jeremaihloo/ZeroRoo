using System;
using ZeroRoo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.IO;
using ZeroRoo.Apps;
using ZeroRoo.Apps.Abstractions;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class ZeroRooTests
    {
        //[Test()]
        //public void RuntimeTests()
        //{
        //    var env = new ZeroRoo.ZeroRuntimeEnviroment()
        //    {
        //        RootFileProvider =
        //            new PhysicalFileProvider(Directory.GetCurrentDirectory())
        //    };

        //    var runtime = new ServiceCollection()
        //        .AddEnviroment(env)
        //        .UseStartup(new Startup(env));

        //    var provider = runtime.BuildServiceProvider();
        //    var appManager = runtime.BuildServiceProvider().GetRequiredService<IAppManager>();

        //    Assert.AreEqual("ZeroRoo", provider.GetService<IRuntimeEnviroment>().ApplicationName);
        //    var apps = appManager.GetApps();
        //    Assert.AreEqual(1, apps.Count());
        //    var appFirst = apps.ToList()[0];
        //    var entryTask = appManager.LoadAppAsync(appFirst);
        //    entryTask.Wait();
        //    var entry = entryTask.Result;
        //    Assert.IsNotNull(entry.Assembly);
        //}

        [Test()]
        public void RefTests()
        {
            var list = AppDomain.CurrentDomain.GetAssemblies().Select(item => item.FullName).ToArray();
            Assert.AreNotEqual(0, list);
        }

        [Test()]
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

        [Test()]
        public void IAssiTest()
        {
            Assert.IsTrue(typeof(IStartup).IsAssignableFrom(typeof(TAClass)));
        }

        public class TAClass : StartupBase
        {

        }
    }
}
