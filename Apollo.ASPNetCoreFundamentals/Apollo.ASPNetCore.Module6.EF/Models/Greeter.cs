using Apollo.ASPNetCore.Module6.RestaurantReviews.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Models
{
    public class Greeter : IGreeter
    {
        public IConfiguration Configuration { get; set; }

        public Greeter(IConfiguration configuration)
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
