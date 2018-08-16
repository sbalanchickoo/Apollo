using Apollo.ASPNetCore.Module5.RestaurantReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.Interfaces
{
    public interface ICuisine
    {
        IEnumerable<Cuisine> GetAllCuisines();

        void AddCuisine(string cuisineName);

        void RemoveCuisine(int id);

        void EditCuisine(int id);
    }
}
