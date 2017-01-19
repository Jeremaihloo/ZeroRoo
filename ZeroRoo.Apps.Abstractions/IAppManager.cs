using ZeroRoo.Apps.Abstractions.Features;
using ZeroRoo.Apps.Abstractions.Loaders;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ZeroRoo.Apps.Abstractions
{
    public interface IAppManager
    {
        IAppInfo GetApp(string appId);
        IEnumerable<IAppInfo> GetApps();
        Task<AppEntry> LoadAppAsync(IAppInfo appInfo);

        IEnumerable<IFeatureInfo> GetFeatures();
        IEnumerable<IFeatureInfo> GetFeatures(string[] featureIdsToLoad);
        IEnumerable<IFeatureInfo> GetFeatureDependencies(string featureId);
        IEnumerable<IFeatureInfo> GetDependentFeatures(string featureId);
        Task<IEnumerable<FeatureEntry>> LoadFeaturesAsync();
        Task<IEnumerable<FeatureEntry>> LoadFeaturesAsync(string[] featureIdsToLoad);
    }
}
