using System.Collections.Generic;

namespace Apollo.EFCore.Shared.Models
{
    public class Cuisine
    {
        public int CuisineId { get; set; }

        public string CuisineName { get; set; }

        List<RestaurantCuisine> RestaurantCuisines { get; set; }
    }
}