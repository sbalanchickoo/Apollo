using Apollo.ASPNet.Module1.Food.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Apollo.ASPNet.Module1.Food.Models
{
    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
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
