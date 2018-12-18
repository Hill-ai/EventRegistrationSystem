using Microsoft.Owin;
using Owin;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Logging;
//using System.Web.Mvc;


[assembly: OwinStartupAttribute(typeof(EventRegistrationSystem.Startup))]
namespace EventRegistrationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

      /*  public void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<IEventsRepository, 
            FakeEventsRepository>();
            //services.AddMvc();
            //unable to add Microsoft.AspNetCore.Mvc package through Nuget 
            //package manager because package is immediately removed after being installed
            //need to find out why
        }

    */

    }
}
