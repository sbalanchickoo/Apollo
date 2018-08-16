using System.Collections.Generic;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public decimal Rating { get; set; }

        public Budget RestaurantBudget { get; set; }

        public List<Cuisine> Cuisine { get; set; } 
    }
}