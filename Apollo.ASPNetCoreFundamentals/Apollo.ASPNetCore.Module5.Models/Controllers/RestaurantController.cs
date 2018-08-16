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
        private ICuisine _cuisine { get; set; }

        public RestaurantController(IRestaurant restaurant, IGreeting greeting, ICuisine cuisine)
        {
            _restaurant = restaurant;
            _greeting = greeting;
            _cuisine = cuisine;
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

        [HttpGet]
        public IActionResult Create()
        {
            CreateViewModel viewModel = new CreateViewModel();
            viewModel.Restaurant = new Restaurant();
            viewModel.Cuisines = _cuisine.GetAllCuisines();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if(ModelState.IsValid)
            {
                Restaurant newRestaurant = new Restaurant
                {
                    Id = model.Id,
                    Name = model.Name,
                    RestaurantBudget = model.RestaurantBudget
                };
                
            }
            return View(viewModel);
        }
    }
}
