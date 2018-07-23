using Apollo.ASPNetCore.Module4.RestaurantReviews.Models;
using System.Collections.Generic;

namespace Apollo.ASPNetCore.Module4.RestaurantReviews.Interfaces
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
