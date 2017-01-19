using System.Collections.Generic;

namespace ZeroRoo.Apps.Abstractions.Features
{
    public interface IFeaturesProvider
    {
        IEnumerable<IFeatureInfo> GetFeatures(
            IAppInfo extensionInfo,
            IManifestInfo manifestInfo);
    }
}
