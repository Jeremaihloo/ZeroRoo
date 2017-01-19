using Microsoft.Extensions.Options;

namespace ZeroRoo.Apps
{
    /// <summary>
    /// Sets up default options for <see cref="AppOptions"/>.
    /// </summary>
    public class AppOptionsSetup : ConfigureOptions<AppOptions>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="AppOptions"/>.
        /// </summary>
        public AppOptionsSetup()
            : base(options => { })
        {
        }
    }
}