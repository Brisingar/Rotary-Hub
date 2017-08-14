using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RotaryHubService.Startup))]

namespace RotaryHubService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}