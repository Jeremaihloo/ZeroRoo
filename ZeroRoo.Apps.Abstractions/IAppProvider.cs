namespace ZeroRoo.Apps.Abstractions
{
    public interface IAppProvider
    {
        IAppInfo GetAppInfo(string subPath);
    }
}
