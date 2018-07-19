using Apollo.ASPNetCore.Module3.StaticFiles.Interfaces;
using Apollo.ASPNetCore.Module3.StaticFiles.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Apollo.ASPNetCore.Module3.StaticFiles
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeting, Greeting>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app
            , IHostingEnvironment env
            , IGreeting greeter
            , ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseStaticFiles();
            
            app.Run(async (context) =>
            {
                var greeting = greeter.GetMessage();
                await context.Response.WriteAsync(greeting);
            });
        }
    }
}
