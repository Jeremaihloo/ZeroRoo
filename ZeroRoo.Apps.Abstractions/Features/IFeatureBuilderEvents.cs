using System;
using System.Collections.Generic;

namespace ZeroRoo.Apps.Abstractions.Features
{
    public interface IFeatureBuilderEvents
    {
        void Building(FeatureBuildingContext context);

        void Built(IFeatureInfo featureInfo);
    }

    public class FeatureBuildingContext
    {
        public IManifestInfo ManifestInfo { get; set; }
        public IAppInfo ExtensionInfo { get; set; }

        public string FeatureId { get; set; }
        public string FeatureName { get; set; }
        public IDictionary<string, string> ManifestDetails { get; set; }
        public IDictionary<string, string> FeatureDetails { get; set; }
        public double Priority { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string[] FeatureDependencyIds { get; set; }
    }

    public abstract class FeatureBuilderEvents : IFeatureBuilderEvents
    {
        public virtual void Building(FeatureBuildingContext context) { }

        public virtual void Built(IFeatureInfo featureInfo) { }
    }
}
