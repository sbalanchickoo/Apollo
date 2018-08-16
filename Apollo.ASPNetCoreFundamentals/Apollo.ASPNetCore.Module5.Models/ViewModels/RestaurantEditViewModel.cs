using Apollo.ASPNetCore.Module5.RestaurantReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.ViewModels
{
    public class RestaurantEditViewModel
    {
        public string Name { get; set; }

        public Budget RestaurantBudget { get; set; }
    }
}
