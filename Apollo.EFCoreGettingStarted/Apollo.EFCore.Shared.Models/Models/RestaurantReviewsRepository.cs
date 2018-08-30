using Apollo.EFCore.Shared.Interfaces;
using Apollo.EFCore.Shared.Models;
using System;
using System.Collections.Generic;

namespace Apollo.EFCore.EF.Models
{
    public class RestaurantReviewsRepository : IRestaurantReviews
    {
        public IEnumerable<Restaurant> GetRestaurants()
        {
            throw new NotImplementedException();
        }
    }
}
