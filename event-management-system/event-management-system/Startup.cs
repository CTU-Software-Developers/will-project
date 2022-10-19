using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(event_management_system.Startup))]
namespace event_management_system
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
