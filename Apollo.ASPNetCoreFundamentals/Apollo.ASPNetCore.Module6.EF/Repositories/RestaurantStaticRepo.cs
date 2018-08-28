using System.Collections.Generic;
using System.Linq;
using Apollo.ASPNetCore.Module6.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module6.RestaurantReviews.Models;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Repositories
{
    public class RestaurantStaticRepo : IRestaurant
    {
        private List<Restaurant> _restaurants = new List<Restaurant>()
        {
            new Restaurant{RestaurantId = 1, RestaurantLocation = "London", RestaurantRating = 0, RestaurantName = "McDonald's"},
            new Restaurant{RestaurantId = 2, RestaurantLocation = "London", RestaurantRating = 0, RestaurantName = "Dominos"}
        };

        public Restaurant Add(Restaurant restaurant)
        {
            int id = _restaurants.Max(r => r.RestaurantId) + 1;
            Restaurant newRestaurant = restaurant;
            newRestaurant.RestaurantId = id;
            _restaurants.Add(newRestaurant);
            return newRestaurant;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public void GetRestaurantByCuisine(string cuisine)
        {
            throw new System.NotImplementedException();
        }

        public Restaurant GetRestaurantById(int id)
        {
            Restaurant restaurant = _restaurants.FirstOrDefault(r => r.RestaurantId == id);
            return restaurant;
        }

        public IEnumerable<Restaurant> GetRestaurantByLocation(string location)
        {
            List<Restaurant> restaurants = _restaurants.FindAll(r => r.RestaurantLocation == location);
            return restaurants;
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string restaurantName)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(string restaurantName)
        {
            throw new System.NotImplementedException();
        }
    }
}
