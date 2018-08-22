using Apollo.ASPNetCore.Module6.RestaurantReviews.Interfaces;
using Apollo.ASPNetCore.Module6.RestaurantReviews.Models;
using System;
using System.Collections.Generic;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Repositories
{
    public class CuisineStaticRepo : ICuisine
    {
        private List<Cuisine> _cuisines = new List<Cuisine>
        {
            new Cuisine { Id = 1, Name = "Chinese"},
            new Cuisine { Id = 2, Name = "French"},
            new Cuisine { Id = 3, Name = "Indian"}
        };

        public void AddCuisine(string cuisineName)
        {
            throw new NotImplementedException();
        }

        public void EditCuisine(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cuisine> GetAllCuisines()
        {
            return _cuisines;
        }

        public void RemoveCuisine(int id)
        {
            throw new NotImplementedException();
        }
    }
}
