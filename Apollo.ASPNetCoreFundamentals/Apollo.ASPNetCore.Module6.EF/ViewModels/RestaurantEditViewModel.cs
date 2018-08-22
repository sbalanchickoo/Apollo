using Apollo.ASPNetCore.Module6.RestaurantReviews.Models;
using System.ComponentModel.DataAnnotations;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required]
        public string Name { get; set; }

        public Budget RestaurantBudget { get; set; }
    }
}
