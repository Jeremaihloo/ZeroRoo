using Microsoft.Extensions.Configuration;

namespace ZeroRoo.Apps.Abstractions
{
    public interface IManifestInfo
    {
        bool Exists { get; }
        string Icon { get; }
        string Name { get; }
        string Description { get; }
        string Type { get; }
        IConfigurationRoot ConfigurationRoot { get; }
    }
}