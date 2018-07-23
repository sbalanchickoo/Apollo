using System.Collections.Generic;
using Apollo.ASPNetCore.Module4.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module4.RestaurantReviews.Models;

namespace Apollo.ASPNetCore.Module4.RestaurantReviews.Repositories
{
    public class RestaurantStaticRepo : IRestaurant
    {
        public void Add(Restaurant restaurant)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Restaurant> GetAll()
        {
            List<Restaurant> restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Location = "London", Rating = 0, Name = "McDonald's"},
                new Restaurant{Id = 2, Location = "London", Rating = 0, Name = "Dominos"}
            };
            return restaurants;
        }

        public void GetRestaurantByCuisine(string cuisine)
        {
            throw new System.NotImplementedException();
        }

        public void GetRestaurantByLocation(string location)
        {
            throw new System.NotImplementedException();
        }

        public void GetRestaurantByName(string restaurantName)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(string restaurantName)
        {
            throw new System.NotImplementedException();
        }
    }
}
