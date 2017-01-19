using Microsoft.Extensions.FileProviders;
using ZeroRoo.Apps.Abstractions.Features;
using ZeroRoo.Apps.Abstractions.Manifests;
using System.Collections.Generic;
using System.Linq;

namespace ZeroRoo.Apps.Abstractions
{
    public class NotFoundAppInfo : IAppInfo
    {
        private readonly IEnumerable<IFeatureInfo> _featureInfos;
        private readonly string _extensionId;
        private readonly IFileInfo _fileInfo;
        private readonly IManifestInfo _manifestInfo;

        public NotFoundAppInfo(string extensionId)
        {
            _featureInfos = Enumerable.Empty<IFeatureInfo>();
            _extensionId = extensionId;
            _fileInfo = new NotFoundFileInfo(extensionId);
            _manifestInfo = new NotFoundManifestInfo(extensionId);
        }

        public bool Exists => false;

        public IFileInfo AppFileInfo => _fileInfo;

        public IEnumerable<IFeatureInfo> Features => _featureInfos;

        public string Id => _extensionId;

        public IManifestInfo Manifest => _manifestInfo;

        public string SubPath => _extensionId;
    }
}
