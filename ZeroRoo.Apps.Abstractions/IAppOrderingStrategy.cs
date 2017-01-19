using ZeroRoo.Apps.Abstractions.Features;

namespace ZeroRoo.Apps.Abstractions
{
    public interface IAppOrderingStrategy
    {
        double Priority { get; }
        int Compare(IFeatureInfo observer, IFeatureInfo subject);
    }
}
