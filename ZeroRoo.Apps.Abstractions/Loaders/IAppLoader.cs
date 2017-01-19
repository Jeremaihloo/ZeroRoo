namespace ZeroRoo.Apps.Abstractions.Loaders
{
    public interface IAppLoader
    {
        int Order { get; }
        string Name { get; }
        AppEntry Load(IAppInfo extensionInfo);
    }
}
