using Apollo.EFCore.Shared.Models;
using System.Collections.Generic;

namespace Apollo.EFCore.Shared.Interfaces
{
    public interface IRestaurantReviews
    {
        IEnumerable<Restaurant> GetRestaurants();

        void DeleteAllRestaurants();

        void Initialize();

        void AddRestaurantWithHeadChef();
    }
}
