using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps.Abstractions.Manifests;

namespace ZeroRoo.Apps.Manifests
{
    public class ManifestBuilder : IManifestBuilder
    {
        private readonly IManifestProvider _manifestProvider;
        private readonly IFileProvider _fileProvider;
        private readonly ManifestOptions _manifestOptions;

        public ManifestBuilder(IEnumerable<IManifestProvider> manifestProviders,
            IRuntimeEnviroment hostingEnvironment,
            IOptions<ManifestOptions> optionsAccessor)
        {
            _manifestProvider = new CompositeManifestProvider(manifestProviders);
            _fileProvider = hostingEnvironment.RootFileProvider;
            _manifestOptions = optionsAccessor.Value;
        }

        public IManifestInfo GetManifest(string subPath)
        {
            IConfigurationBuilder configurationBuilder 
                = new ConfigurationBuilder();

            string type = null;

            foreach (var manifestConfiguration in _manifestOptions.ManifestConfigurations)
            {
                var filePath = Path.Combine(subPath, manifestConfiguration.ManifestFileName);

                if (_fileProvider.GetFileInfo(filePath).Exists)
                {
                    configurationBuilder =
                        _manifestProvider.GetManifestConfiguration(
                            configurationBuilder,
                            filePath
                            );

                    type = manifestConfiguration.Type;
                }
            }

            if (type == null || !configurationBuilder.Sources.Any())
            {
                return new NotFoundManifestInfo(subPath);
            }

            var config = configurationBuilder.Build();

            return new ManifestInfo(config, type);
        }
    }
}
