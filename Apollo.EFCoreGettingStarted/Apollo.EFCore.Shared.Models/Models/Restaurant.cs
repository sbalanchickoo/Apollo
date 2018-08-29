using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apollo.EFCore.Shared.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }

        [Display(Name = "Restaurant Name")]
        [Required]
        public string RestaurantName { get; set; }

        [Required]
        public string RestaurantLocation { get; set; }

        public decimal RestaurantRating { get; set; }

        [Display(Name = "Restaurant Budget")]
        public Budget RestaurantBudget { get; set; }

        public List<RestaurantCuisine> RestaurantCuisines { get; set; }

        public int HeadChefId { get; set; }
        public HeadChef HeadChef { get; set; }
    }
}