using Apollo.EFCore.Shared.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apollo.EFCore.Module5.UI
{
    public class Viewer
    {
        public RestaurantContext Context { get; set; }

        public void DisplayRestaurants()
        {
            using (Context)
            {
                var restaurants = Context.Restaurants.ToList();
                foreach(var restaurant in restaurants)
                {
                    Console.WriteLine(restaurant.RestaurantName);
                }
            }
        }
    }
}
