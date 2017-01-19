using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using AssemblyLoader;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ass = Assembly.LoadFrom("AppDemo1.dll");
            var t = ass.ExportedTypes.FirstOrDefault(item => item.Name == "Startup");
            var startup = Activator.CreateInstance(t);
            Assert.IsNotNull(startup);
            Assert.IsTrue(typeof(IStartup).IsAssignableFrom(startup.GetType()));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var ass = Assembly.LoadFrom("Tests/AppDemo1.dll");
            var t = ass.ExportedTypes.FirstOrDefault(item => item.Name == "Startup");
            var startup = Activator.CreateInstance(t);
            Assert.IsNotNull(startup);
            Assert.IsTrue(typeof(IStartup).IsAssignableFrom(startup.GetType()));
        }
    }
}
