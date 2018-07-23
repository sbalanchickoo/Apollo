using Microsoft.AspNetCore.Mvc;
using Apollo.ASPNetCore.Module5.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module5.RestaurantReviews.ViewModels;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.Controllers
{
    [Route("[controller]/[action]")]
    public class RestaurantController : Controller
    {
        private IRestaurant _restaurant { get; set; }
        private IGreeting _greeting { get; set; }

        public RestaurantController(IRestaurant restaurant, IGreeting greeting)
        {
            _restaurant = restaurant;
            _greeting = greeting;
        }

        public IActionResult GetRestaurantDetail()
        {
            var model = new RestaurantViewModel(_greeting, _restaurant);
            return View(model);
        }
    }
}
