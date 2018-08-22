using Apollo.ASPNetCore.Module6.RestaurantReviews.Models;
using System.Collections.Generic;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Interfaces
{
    public interface IRestaurant
    {
        IEnumerable<Restaurant> GetAll();

        Restaurant Add(Restaurant restaurant);

        void Remove(string restaurantName);

        IEnumerable<Restaurant> GetRestaurantByName(string restaurantName);

        IEnumerable<Restaurant> GetRestaurantByLocation(string location);

        void GetRestaurantByCuisine(string cuisine);

        Restaurant GetRestaurantById(int id);
    }
}
