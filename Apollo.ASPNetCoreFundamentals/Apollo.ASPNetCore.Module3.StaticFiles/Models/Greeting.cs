using Apollo.ASPNetCore.Module3.StaticFiles.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Apollo.ASPNetCore.Module3.StaticFiles.Models
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
