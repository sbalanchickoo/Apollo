using Apollo.ASPNetCore.Module5.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module5.RestaurantReviews.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing;
using Apollo.ASPNetCore.Module5.RestaurantReviews.Repositories;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeting, Greeting>();
            services.AddSingleton<IRestaurant, RestaurantStaticRepo>();
            services.AddScoped<ICuisine, CuisineStaticRepo>();
            services.AddMvc();
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

            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(ConfigureRoutes);
            app.Run(async (context) =>
            {
                var greeting = greeter.GetMessage();
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync(greeting);
            });
        }

        private void ConfigureRoutes(IRouteBuilder obj)
        {
            //obj.MapRoute("Default", "{controller}/{action}");
        }
    }
}
