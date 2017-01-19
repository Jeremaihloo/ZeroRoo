using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Abstractions.Manifests
{
    public class NotFoundManifestInfo: IManifestInfo
    {
        private readonly IFileInfo _fileInfo;

        public NotFoundManifestInfo(string subPath)
        {
            _fileInfo = new NotFoundFileInfo(subPath);
        }

        public IFileInfo Manifest { get { return _fileInfo; } }
        public bool Exists => false;
        public string Name => null;
        public string Description => null;
        public string Type => null;
        public IConfigurationRoot ConfigurationRoot => null;
    }
}
