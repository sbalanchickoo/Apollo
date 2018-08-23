using Apollo.ASPNetCore.Module6.RestaurantReviews.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Models
{
    public class Greeting : IGreeting
    {
        public IConfiguration Configuration { get; set; }

        public Greeting(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string GetMessage()
        {
            string message = Configuration["Greeting"];
            return message;
        }
    }
}
