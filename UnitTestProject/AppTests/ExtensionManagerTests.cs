using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;
using ZeroRoo;
using System;
using ZeroRoo.Apps.Manifests;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps;
using ZeroRoo.Apps.Features;
using ZeroRoo.Apps.Abstractions.Manifests;
using ZeroRoo.Apps.Abstractions.Loaders;
using ZeroRoo.Apps.Abstractions.Features;

namespace UnitTestProject
{
    [TestClass]
    public class AppManagerTests
    {
        private static IFileProvider RunningTestFileProvider
            = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "AppTests"));

        public class TestRuntimeEnviroment : IRuntimeEnviroment
        {
            public string EnviromentName => "Development";
            public string ApplicationName => "TestRuntimeEnviroment";
            public string RootPath => Directory.GetCurrentDirectory();
            public IFileProvider RootFileProvider => RunningTestFileProvider;
        }

        private static IRuntimeEnviroment TestRuntimeEnvrionment
            = new TestRuntimeEnviroment();

        private static IAppProvider ModuleProvider =
                    new AppProvider(
                        TestRuntimeEnvrionment,
                        new ManifestBuilder(
                            new IManifestProvider[] { new ManifestProvider(TestRuntimeEnvrionment) },
                            TestRuntimeEnvrionment,
                            new StubManifestOptions(new ManifestOption { ManifestFileName = "App.txt", Type = "app" })),
                        new[] { new FeaturesProvider(Enumerable.Empty<IFeatureBuilderEvents>(), new NullLogger<FeaturesProvider>()) });

        private IAppManager ModuleScopedAppManager;

        public AppManagerTests()
        {
            ModuleScopedAppManager = new AppManager(
                new StubAppOptions("TestDependencyApps"),
                new[] { ModuleProvider },
                Enumerable.Empty<IAppLoader>(),
                Enumerable.Empty<IAppOrderingStrategy>(),
                TestRuntimeEnvrionment,
                null,
                new NullLogger<AppManager>());
        }

        [TestMethod]
        public void ShouldReturnApp()
        {
            var Apps = ModuleScopedAppManager.GetApps();

            Assert.AreEqual(2, Apps.Count());
        }

        [TestMethod]
        public void ShouldReturnAllDependenciesIncludingFeatureForAGivenFeatureOrdered()
        {
            var features = ModuleScopedAppManager.GetFeatureDependencies("Sample3");

            Assert.AreEqual(3, features.Count());
            Assert.AreEqual("Sample1", features.ElementAt(0).Id);
            Assert.AreEqual("Sample2", features.ElementAt(1).Id);
            Assert.AreEqual("Sample3", features.ElementAt(2).Id);
        }

        [TestMethod]
        public void ShouldNotReturnFeaturesNotDependentOn()
        {
            var features = ModuleScopedAppManager.GetFeatureDependencies("Sample2");

            Assert.AreEqual(2, features.Count());
            Assert.AreEqual("Sample1", features.ElementAt(0).Id);
            Assert.AreEqual("Sample2", features.ElementAt(1).Id);
        }

        [TestMethod]
        public void GetDependentFeaturesShouldReturnAllFeaturesThatHaveADependencyOnAFeature()
        {
            var features = ModuleScopedAppManager.GetDependentFeatures("Sample1");

            Assert.AreEqual(2, features.Count());
            Assert.AreEqual("Sample1", features.ElementAt(0).Id);
            Assert.AreEqual("Sample2", features.ElementAt(1).Id);
        }

        [TestMethod]
        public void GetFeaturesShouldReturnAllFeaturesOrderedByDependency()
        {
            var features = ModuleScopedAppManager.GetFeatures();

            Assert.AreEqual(2, features.Count());
            Assert.AreEqual("Sample1", features.ElementAt(0).Id);
            Assert.AreEqual("Sample2", features.ElementAt(1).Id);
        }

        [TestMethod]
        public void GetFeaturesWithAIdShouldReturnThatFeatureWithDependenciesOrdered()
        {
            var features = ModuleScopedAppManager.GetFeatures(new[] { "Sample2" });

            Assert.AreEqual(2, features.Count());
            Assert.AreEqual("Sample1", features.ElementAt(0).Id);
            Assert.AreEqual("Sample2", features.ElementAt(1).Id);
        }


        [TestMethod]
        public void GetFeaturesWithAIdShouldReturnThatFeatureWithDependenciesOrderedWithNoDuplicates()
        {
            var features = ModuleScopedAppManager.GetFeatures(new[] { "Sample2", "Sample3" });

            Assert.AreEqual(2, features.Count());
            Assert.AreEqual("Sample1", features.ElementAt(0).Id);
            Assert.AreEqual("Sample2", features.ElementAt(1).Id);
        }

        [TestMethod]
        public void GetFeaturesWithAIdShouldNotReturnFeaturesTheHaveADependencyOutsideOfGraph()
        {
            var features = ModuleScopedAppManager.GetFeatures(new[] { "Sample4" });

            Assert.AreEqual(3, features.Count());
            Assert.AreEqual("Sample1", features.ElementAt(0).Id);
            Assert.AreEqual("Sample2", features.ElementAt(1).Id);
            Assert.AreEqual("Sample4", features.ElementAt(2).Id);
        }


    }

    public class StubAppOptions : IOptions<AppOptions>
    {
        private string _path;
        public StubAppOptions(string path)
        {
            _path = path;
        }

        public AppOptions Value
        {
            get
            {
                var options = new AppOptions();
                options.SearchPaths.Add(_path);
                return options;
            }
        }
    }
}
