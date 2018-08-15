using Apollo.ASPNetCore.Module5.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module5.RestaurantReviews.Models;
using System.Collections.Generic;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.ViewModels
{
    public class RestaurantViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public IGreeting Greeting { get; set; }
    }
}
