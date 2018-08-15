using Apollo.ASPNetCore.Module5.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module5.RestaurantReviews.Models;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.ViewModels
{
    public class RestaurantDetailViewModel
    {
        public Restaurant Restaurant { get; set; }

        public IGreeting Greeting { get; set; }
    }
}
