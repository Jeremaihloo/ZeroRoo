using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using System.IO;
using System.Linq;
using ZeroRoo;
using ZeroRoo.Apps;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps.Abstractions.Features;
using ZeroRoo.Apps.Abstractions.Manifests;
using ZeroRoo.Apps.Features;
using ZeroRoo.Apps.Manifests;

namespace UnitTestProject
{
    [TestFixture]
    public class AppProviderTests
    {
        private static IFileProvider RunningTestFileProvider
            = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "AppTests", "TestApps"));

        private static IRuntimeEnviroment RuntimeEnvrionment
            = new ZeroRoo.ZeroRuntimeEnviroment() { RootFileProvider = RunningTestFileProvider };

        private IAppProvider Provider =
                    new AppProvider(
                        RuntimeEnvrionment,
                        new ManifestBuilder(
                            new IManifestProvider[] { new ManifestProvider(RuntimeEnvrionment) },
                            RuntimeEnvrionment,
                            new StubManifestOptions(new ManifestOption { ManifestFileName = "App.txt", Type = "app" })),
                        new[] { new FeaturesProvider(Enumerable.Empty<IFeatureBuilderEvents>(), new NullLogger<FeaturesProvider>()) });

        [Test()]
        public void ThatGetAppInfoShouldReturnAppWhenManifestIsPresent()
        {
            var App = Provider.GetAppInfo("Sample1");

            Assert.AreEqual("Sample1", App.Id);
            Assert.IsTrue(App.AppFileInfo.Exists);
        }

        [Test()]
        public void ThatGetAppInfoShouldReturnNullWhenManifestDoesNotExist()
        {
            var App = Provider.GetAppInfo("Sample2");

            Assert.IsNull(App);
        }
    }

    public class StubManifestOptions : IOptions<ManifestOptions>
    {
        private ManifestOption _option;
        public StubManifestOptions(ManifestOption option)
        {
            _option = option;
        }

        public ManifestOptions Value
        {
            get
            {
                var options = new ManifestOptions();
                options.ManifestConfigurations.Add(_option);
                return options;
            }
        }
    }
}