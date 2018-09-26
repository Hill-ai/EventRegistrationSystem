using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventRegistrationSystem.Startup))]
namespace EventRegistrationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
