using Microsoft.AspNetCore.Mvc;
using Apollo.ASPNetCore.Module5.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module5.RestaurantReviews.ViewModels;
using Apollo.ASPNetCore.Module5.RestaurantReviews.Models;

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

        public IActionResult GetRestaurants(RestaurantViewModel restaurantViewModel)
        {
            RestaurantViewModel viewModel = new RestaurantViewModel();
            viewModel.Restaurants = _restaurant.GetAll();
            viewModel.Greeting = _greeting;
            return View(viewModel);
            //return new ObjectResult(_restaurant);

        }

        [Route("{id?}")]
        public IActionResult GetRestaurantDetail(int id)
        {
            RestaurantDetailViewModel viewModel = new RestaurantDetailViewModel();
            Restaurant restaurant = _restaurant.GetRestaurantById(id);
            viewModel.Restaurant = restaurant;
            viewModel.Greeting = _greeting;
            return View(viewModel);
            //return 
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
