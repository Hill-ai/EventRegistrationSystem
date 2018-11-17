using Microsoft.Owin;
using Owin;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Logging;
using EventRegistrationSystem.Models;
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

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IEventsRepository,
            FakeEventsRepository>();
            //services.AddMvc();
            //unable to add Microsoft.AspNetCore.Mvc package through Nuget 
            //package manager because package is immediately removed after being installed
            //need to find out why
        }

        /*
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Events}/{action=List}/{id?}");
            });

        }
        */
    }
    
}
