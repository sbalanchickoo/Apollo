using Apollo.ASPNetCore.Module5.RestaurantReviews.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.Models
{
    public class Greeting : IGreeting
    {
        private IConfiguration _configuration;

        public Greeting(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMessage()
        {
            string message = _configuration["Greeting"];
            return message;
        }
    }
}
