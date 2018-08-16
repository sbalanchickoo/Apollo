using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name="Restaurant Name")]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public decimal Rating { get; set; }

        [Display(Name = "Restaurant Budget")]
        public Budget RestaurantBudget { get; set; }

        public List<Cuisine> Cuisine { get; set; } 
    }
}