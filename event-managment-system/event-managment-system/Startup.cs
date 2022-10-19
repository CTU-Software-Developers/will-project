using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(event_managment_system.Startup))]
namespace event_managment_system
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
