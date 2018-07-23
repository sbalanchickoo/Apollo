using Apollo.ASPNetCore.Module5.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module5.RestaurantReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.ViewModels
{
    public class RestaurantViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public string Greeting { get; set; }

        public RestaurantViewModel(IGreeting greeting, IRestaurant restaurant)
        {
            Greeting = greeting.GetMessage();
            Restaurants = restaurant.GetAll();
        }
    }
}
