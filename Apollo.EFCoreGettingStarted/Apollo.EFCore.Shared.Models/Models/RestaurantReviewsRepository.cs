using Apollo.EFCore.Shared.Interfaces;
using Apollo.EFCore.Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace Apollo.EFCore.EF.Models
{
    public class RestaurantReviewsRepository : IRestaurantReviews
    {
        private RestaurantContext _restaurantContext;

        public RestaurantContext Context
        {
            get
            {
                if (_restaurantContext == null)
                {
                    _restaurantContext = new RestaurantContext();
                }
                return _restaurantContext;
            }
            set { _restaurantContext = value; }
        }


        public void CleanRepo()
        {
            using (Context)
            {
                var restaurants = Context.Restaurants.ToList();
                Context.RemoveRange(restaurants);
                Context.SaveChanges();
            }
        }

        public IEnumerable<Restaurant> GetRestaurants()
        {
            using (Context)
            {
                var restaurants = Context.Restaurants.ToList();
                return restaurants;
            }
        }

        public void Initialize()
        {
            using (var context = RestaurantContext)
            {
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
