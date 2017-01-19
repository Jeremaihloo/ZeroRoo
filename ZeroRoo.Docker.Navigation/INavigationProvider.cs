namespace ZeroRoo.Docker.Navigation
{
    public interface INavigationProvider
    {
        void BuildNavigation(NavigationBuilder builder);
    }
}
