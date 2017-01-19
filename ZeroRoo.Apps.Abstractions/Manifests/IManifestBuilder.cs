namespace ZeroRoo.Apps.Abstractions.Manifests
{
    public interface IManifestBuilder
    {
        IManifestInfo GetManifest(string subPath);
    }
}
