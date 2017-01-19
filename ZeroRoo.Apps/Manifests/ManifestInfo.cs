using Microsoft.Extensions.Configuration;
using ZeroRoo.Apps.Abstractions;

namespace ZeroRoo.Apps.Manifests
{
    public class ManifestInfo : IManifestInfo
    {
        private readonly IConfigurationRoot _configurationRoot;
        private string _type;

        public ManifestInfo(
            IConfigurationRoot configurationRoot,
            string type)
        {
            _configurationRoot = configurationRoot;
            _type = type;
        }

        public bool Exists => true;
        public string Name => _configurationRoot["name"];
        public string Description => _configurationRoot["description"];
        public string Type { get { return _type; } }
        public string Icon => _configurationRoot["icon"];
        public IConfigurationRoot ConfigurationRoot => _configurationRoot;
    }
}
