using Apollo.ASPNetCore.Module6.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module6.RestaurantReviews.Models;
using System.Collections.Generic;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.ViewModels
{
    public class RestaurantViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public IGreeter Greeting { get; set; }
    }
}
