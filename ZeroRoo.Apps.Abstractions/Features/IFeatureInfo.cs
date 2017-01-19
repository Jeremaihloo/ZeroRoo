namespace ZeroRoo.Apps.Abstractions.Features
{
    public interface IFeatureInfo
    {
        string Id { get; }
        string Name { get; }
        double Priority { get; }
        string Category { get; }
        string Description { get; }
        IAppInfo Extension { get; }
        string[] Dependencies { get; }
    }
}
