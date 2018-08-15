using Microsoft.AspNetCore.Mvc;
using Apollo.ASPNetCore.Module5.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module5.RestaurantReviews.ViewModels;
using Apollo.ASPNetCore.Module5.RestaurantReviews.Models;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.Controllers
{
    [Route("[controller]/[action]/[id?]")]
    public class RestaurantController : Controller
    {
        private IRestaurant _restaurant { get; set; }
        private IGreeting _greeting { get; set; }

        public RestaurantController(IRestaurant restaurant, IGreeting greeting)
        {
            _restaurant = restaurant;
            _greeting = greeting;
        }

        public IActionResult GetRestaurants(RestaurantViewModel restaurantViewModel)
        {
            return View(restaurantViewModel);
        }

        public IActionResult GetRestaurantDetail(int id)
        {
            Restaurant restaurant = _restaurant.GetRestaurantById(id);
            var model = new RestaurantDetailViewModel(_greeting, restaurant);
            return View(model);
        }
    }
}
