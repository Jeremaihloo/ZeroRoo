using Microsoft.Extensions.Options;

namespace ZeroRoo.Apps
{
    /// <summary>
    /// Sets up default options for <see cref="AppProbingOptions"/>.
    /// </summary>
    public class AppProbingOptionsSetup : ConfigureOptions<AppProbingOptions>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="AppProbingOptions"/>.
        /// </summary>
        public AppProbingOptionsSetup()
            : base(options => { })
        {
        }
    }
}