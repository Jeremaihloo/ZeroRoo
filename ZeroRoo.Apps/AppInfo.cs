using Microsoft.Extensions.FileProviders;
using ZeroRoo.Apps.Features;
using System;
using System.Collections.Generic;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps.Abstractions.Features;

namespace ZeroRoo.Apps
{
    public class AppInfo : IAppInfo
    {
        private readonly IFileInfo _fileInfo;
        private readonly string _subPath;
        private readonly IManifestInfo _manifestInfo;
        private readonly IEnumerable<IFeatureInfo> _features;

        public AppInfo(
            IFileInfo fileInfo,
            string subPath,
            IManifestInfo manifestInfo,
            Func<IAppInfo, IEnumerable<IFeatureInfo>> features) {

            _fileInfo = fileInfo;
            _subPath = subPath;
            _manifestInfo = manifestInfo;
            _features = features(this);
        }

        public string Id => _fileInfo.Name;
        public IFileInfo AppFileInfo => _fileInfo;
        public string SubPath => _subPath;
        public IManifestInfo Manifest => _manifestInfo;
        public IEnumerable<IFeatureInfo> Features => _features;
        public bool Exists => _fileInfo.Exists && _manifestInfo.Exists;
    }
}
