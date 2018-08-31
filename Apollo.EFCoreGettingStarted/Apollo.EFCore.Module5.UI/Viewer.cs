using Apollo.EFCore.Shared.Interfaces;
using System;

namespace Apollo.EFCore.Module5.UI
{
    public class Viewer
    {
        public IRestaurantReviews RestaurantReviews { get; set; }

        public void StartApp()
        {
            int choice = -1;
            Console.WriteLine("[1] Delete all restaurants");
            Console.WriteLine("[2] Initialize data");
            Console.WriteLine("[3] Display all restaurants");
            Console.WriteLine("Enter choice: ");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                choice = -1;
            }

            switch( choice )
            {
                case 1:
                    Console.Clear();
                    RestaurantReviews.DeleteAllRestaurants();
                    StartApp();
                    break;
                case 2:
                    Console.Clear();
                    RestaurantReviews.Initialize();
                    StartApp();
                    break;
                case 3:
                    Console.Clear();
                    DisplayAllRestaurants();
                    StartApp();
                    break;
                default:
                    Console.Clear();
                    StartApp();
                    break;
            }
        }

        void DisplayAllRestaurants()
        {
            var restaurants = RestaurantReviews.GetRestaurants();
            foreach (var restaurant in restaurants)
            {
                Console.WriteLine(restaurant.RestaurantName);
            }
        }
    }
}
