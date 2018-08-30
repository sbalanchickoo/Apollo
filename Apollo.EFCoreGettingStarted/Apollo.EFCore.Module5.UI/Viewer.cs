﻿using Apollo.EFCore.Shared.Interfaces;
using System;

namespace Apollo.EFCore.Module5.UI
{
    public class Viewer
    {
        public IRestaurantReviews RestaurantReviews { get; set; }

        public void DisplayRestaurants()
        {
            var restaurants = RestaurantReviews.GetRestaurants();
            foreach (var restaurant in restaurants)
            {
                Console.WriteLine(restaurant.RestaurantName);
            }
        }
    }
}
}
