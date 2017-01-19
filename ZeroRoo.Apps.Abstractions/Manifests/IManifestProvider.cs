using Microsoft.Extensions.Configuration;

namespace ZeroRoo.Apps.Abstractions.Manifests
{
    public interface IManifestProvider
    {
        int Priority { get; }
        IConfigurationBuilder GetManifestConfiguration(IConfigurationBuilder configurationBuilder, string subPath);
    }
}
