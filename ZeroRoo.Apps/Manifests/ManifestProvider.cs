using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using ZeroRoo.Parser;
using System;
using System.IO;
using ZeroRoo.Apps.Abstractions.Manifests;

namespace ZeroRoo.Apps.Manifests
{
    public class ManifestProvider : IManifestProvider
    {
        private readonly IFileProvider _fileProvider;

        public ManifestProvider(IRuntimeEnviroment hostingEnvironment)
        {
            _fileProvider = hostingEnvironment.RootFileProvider;
        }

        public int Priority { get { return 0; } }

        public IConfigurationBuilder GetManifestConfiguration(
            IConfigurationBuilder configurationBuilder, 
            string subPath)
        {
            // TODO.. (ngm) are there any better checks for IsYaml
            var extension = Path.GetExtension(subPath);

            if (!extension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
            {
                return configurationBuilder;
            }

            var manifestFileInfo = _fileProvider.GetFileInfo(subPath);

            if (!manifestFileInfo.Exists)
            {
                return configurationBuilder;
            }

            return
                configurationBuilder
                    .AddYamlFile(_fileProvider, subPath, true, false);
        }
    }
}
