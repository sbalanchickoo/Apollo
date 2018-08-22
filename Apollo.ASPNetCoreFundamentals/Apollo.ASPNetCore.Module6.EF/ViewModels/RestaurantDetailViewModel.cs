using Apollo.ASPNetCore.Module6.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module6.RestaurantReviews.Models;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.ViewModels
{
    public class RestaurantDetailViewModel
    {
        public Restaurant Restaurant { get; set; }

        public IGreeting Greeting { get; set; }
    }
}
