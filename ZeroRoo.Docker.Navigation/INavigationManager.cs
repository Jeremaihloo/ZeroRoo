using System.Collections.Generic;


namespace ZeroRoo.Docker.Navigation
{
    public interface INavigationManager
    {
        IEnumerable<MenuItem> BuildMenu();
    }
}
