
using ZeroRoo;

namespace ZeroRoo.DeferredTasks
{
    public static class ApplicationBuilderExtensions
    {
        public static IRuntime AddDeferredTasks(this IRuntime runtime)
        {
            app.UseMiddleware<DeferredTaskMiddleware>();

            return app;
        }
    }
}
