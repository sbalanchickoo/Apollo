using System.Collections.Generic;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Models
{
    public class Cuisine
    {
        public int CuisineId { get; set; }

        public string CuisineName { get; set; }

        List<RestaurantCuisine> RestaurantCuisines { get; set; }
    }
}