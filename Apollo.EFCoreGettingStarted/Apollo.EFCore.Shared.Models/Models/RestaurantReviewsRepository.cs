using Apollo.EFCore.Shared.Interfaces;
using Apollo.EFCore.Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace Apollo.EFCore.EF.Models
{
    public class RestaurantReviewsRepository : IRestaurantReviews
    {
        public RestaurantContext Context { get; set; }

        public IEnumerable<Restaurant> GetRestaurants()
        {
            using (Context)
            {
                List<Restaurant> restaurants = Context.Restaurants.ToList();
                Context.remo
                return restaurants;
            }
        }
    }
}
