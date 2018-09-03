using Apollo.EFCore.Shared.Interfaces;
using Apollo.EFCore.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Apollo.EFCore.EF.Models
{
    public class RestaurantReviewsRepository : IRestaurantReviews
    {
        public void AddRestaurantWithHeadChef()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAllRestaurants()
        {
            using (var context = new RestaurantContext())
            {
                var restaurants = context.Restaurants.ToList();
                context.RemoveRange(restaurants);
                context.SaveChanges();
            }
        }

        public IEnumerable<Restaurant> GetRestaurants()
        {
            using (var context = new RestaurantContext())
            {
                var restaurants = context.Restaurants.ToList();
                return restaurants;
            }
        }

        public void Initialize()
        {
            using (var context = new RestaurantContext())
            {
                context.Database.Migrate();
                var restaurants = context.Restaurants.ToList();
                int id;
                if (restaurants.Count == 0)
                {
                    id = 0;
                }
                else
                {
                    id = restaurants.Max(r => r.HeadChefId);
                }
                id++;
                
                Restaurant restaurant = new Restaurant
                {
                    HeadChefId = id,
                    RestaurantName = "Papa Johns",
                    RestaurantRating = 0,
                    RestaurantLocation = "London"
                };
                context.Add(restaurant);
                context.SaveChanges();
            }
        }
    }
}
