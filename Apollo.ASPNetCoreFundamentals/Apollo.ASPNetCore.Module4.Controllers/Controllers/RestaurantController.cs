using Microsoft.AspNetCore.Mvc;
using Apollo.ASPNetCore.Module4.RestaurantReviews.Interfaces;

namespace Apollo.ASPNetCore.Module4.RestaurantReviews.Controllers
{
    [Route("[controller]/[action]")]
    public class RestaurantController : Controller
    {
        private IRestaurant _restaurant { get; set; }

        public RestaurantController(IRestaurant restaurant)
        {
            _restaurant = restaurant;
        }

        public IActionResult GetRestaurantDetail()
        {
            var restaurants = _restaurant.GetAll();
            return View(restaurants);
        }
    }
}
