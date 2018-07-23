using Apollo.ASPNetCore.Module5.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module5.RestaurantReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.ViewModels
{
    public class RestaurantDetailViewModel
    {
        public Restaurant Restaurant { get; set; }

        public string Greeting { get; set; }

        public RestaurantDetailViewModel(IGreeting greeting, Restaurant restaurant)
        {
            Greeting = greeting.GetMessage();
            Restaurant = restaurant;
        }
    }
}
