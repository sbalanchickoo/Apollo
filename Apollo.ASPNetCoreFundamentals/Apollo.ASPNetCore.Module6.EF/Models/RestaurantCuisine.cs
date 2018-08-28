using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Models
{
    public class RestaurantCuisine
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int CuisineId { get; set; }
        public Cuisine Cuisine { get; set; }
    }
}
