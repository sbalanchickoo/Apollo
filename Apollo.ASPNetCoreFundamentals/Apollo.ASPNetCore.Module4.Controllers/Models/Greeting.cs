﻿using Apollo.ASPNetCore.Module4.RestaurantReviews.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Apollo.ASPNetCore.Module4.RestaurantReviews.Models
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
