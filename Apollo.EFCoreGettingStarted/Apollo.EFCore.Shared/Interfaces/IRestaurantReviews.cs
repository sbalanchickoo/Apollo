using Apollo.EFCore.Shared.Models;
using System.Collections.Generic;

namespace Apollo.EFCore.Shared.Interfaces
{
    public interface IRestaurantReviews
    {
        IEnumerable<Restaurant> GetRestaurants();
    }
}
