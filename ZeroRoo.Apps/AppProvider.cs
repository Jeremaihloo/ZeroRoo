using Microsoft.Extensions.FileProviders;
using ZeroRoo.Apps.Features;
using ZeroRoo.Apps.Manifests;
using System.Collections.Generic;
using System.Linq;
using ZeroRoo.Apps.Abstractions.Features;
using ZeroRoo.Apps.Abstractions.Manifests;
using ZeroRoo.Apps.Abstractions;

namespace ZeroRoo.Apps
{
    public class AppProvider : IAppProvider
    {
        private readonly IFileProvider _fileProvider;
        private readonly IManifestBuilder _manifestBuilder;
        private readonly IFeaturesProvider _featuresProvider;

        /// <summary>
        /// Initializes a new instance of a ExtensionProvider at the given root directory.
        /// </summary>
        /// <param name="hostingEnvironment">hostingEnvironment containing the fileproviders.</param>
        /// <param name="manifestBuilder">The manifest provider.</param>
        /// <param name="featureManager">The feature manager.</param>
        public AppProvider(
            IRuntimeEnviroment hostingEnvironment,
            IManifestBuilder manifestBuilder,
            IEnumerable<IFeaturesProvider> featureProviders)
        {
            _fileProvider = hostingEnvironment.RootFileProvider;
            _manifestBuilder = manifestBuilder;
            _featuresProvider = new CompositeFeaturesProvider(featureProviders);
        }

        /// <summary>
        /// Locate an extension at the given path by directly mapping path segments to physical directories.
        /// </summary>
        /// <param name="subpath">A path under the root directory</param>
        /// <returns>The extension information. null returned if extension does not exist</returns>
        public IAppInfo GetAppInfo(string subPath)
        {
            var manifest = _manifestBuilder.GetManifest(subPath);

            if (!manifest.Exists)
            {
                return null;
            }

            var path = System.IO.Path.GetDirectoryName(subPath);
            var name = System.IO.Path.GetFileName(subPath);

            var extension = _fileProvider
                .GetDirectoryContents(path)
                .First(content => content.Name == name);

            return new AppInfo(extension, subPath, manifest, (ei) => {
                return _featuresProvider.GetFeatures(ei, manifest);
            });
        }
    }
}
