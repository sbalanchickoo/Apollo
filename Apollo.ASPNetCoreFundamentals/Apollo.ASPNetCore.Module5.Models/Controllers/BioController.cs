﻿using Microsoft.AspNetCore.Mvc;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.Controllers
{
    [Route("info/[controller]/[action]")]
    public class BioController
    {
        public string DescriptionGrade()
        {
            return "Restaurant reviews is a website for ranking restaurants";
        }
    }
}
