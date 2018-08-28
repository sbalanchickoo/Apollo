using Microsoft.AspNetCore.Mvc;
using Apollo.ASPNetCore.Module6.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module6.RestaurantReviews.ViewModels;
using Apollo.ASPNetCore.Module6.RestaurantReviews.Models;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Controllers
{
    [Route("[controller]/[action]")]
    [Route("")]
    public class RestaurantController : Controller
    {
        private IRestaurant _restaurant { get; set; }
        private IGreeter _greeting { get; set; }
        private ICuisine _cuisine { get; set; }

        public RestaurantController(IRestaurant restaurant, IGreeter greeting, ICuisine cuisine)
        {
            _restaurant = restaurant;
            _greeting = greeting;
            _cuisine = cuisine;
        }

        [Route("[controller]")]
        public IActionResult GetRestaurants(RestaurantViewModel restaurantViewModel)
        {
            RestaurantViewModel viewModel = new RestaurantViewModel();
            viewModel.Restaurants = _restaurant.GetAll();
            viewModel.Greeting = _greeting;
            return View(viewModel);
        }

        [Route("{id?}")]
        public IActionResult GetRestaurantDetail(int id)
        {
            RestaurantDetailViewModel viewModel = new RestaurantDetailViewModel();
            Restaurant restaurant = _restaurant.GetRestaurantById(id);
            if (!(restaurant == null))
            {
                viewModel.Restaurant = restaurant;
                viewModel.Greeting = _greeting;
                return View(viewModel);
            }
            else
            {
                return RedirectToAction(nameof(GetRestaurants));
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Restaurant newRestaurant = new Restaurant
                {
                    RestaurantName = model.Name,
                    //RestaurantBudget = model.RestaurantBudget
                };
                newRestaurant = _restaurant.Add(newRestaurant);
                return RedirectToAction(nameof(GetRestaurantDetail),new { id = newRestaurant.RestaurantId });
            }
            else
            {
                return View();
            }
        }
    }
}
