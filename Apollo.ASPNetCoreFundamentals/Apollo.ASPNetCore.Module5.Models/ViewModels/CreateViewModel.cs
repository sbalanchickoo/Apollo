using Apollo.ASPNetCore.Module5.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module5.RestaurantReviews.Models;
using System.Collections.Generic;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.ViewModels
{
    public class CreateViewModel
    {
        public Restaurant Restaurant { get; set; }

        public IEnumerable<Cuisine> Cuisines { get; set; }
    }
}
