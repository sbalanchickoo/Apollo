using Apollo.ASPNetCore.Module5.RestaurantReviews.Models;
using System.Collections.Generic;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.Interfaces
{
    public interface IRestaurant
    {
        IEnumerable<Restaurant> GetAll();

        void Add(Restaurant restaurant);

        void Remove(string restaurantName);

        void GetRestaurantByName(string restaurantName);

        void GetRestaurantByLocation(string location);

        void GetRestaurantByCuisine(string cuisine);
    }
}
