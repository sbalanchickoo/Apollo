﻿namespace Apollo.EFCore.Shared.Models
{
    public class RestaurantCuisine
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int CuisineId { get; set; }
        public Cuisine Cuisine { get; set; }
    }
}
