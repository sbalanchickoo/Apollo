using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.Models
{
    public class HeadChef
    {
        public int HeadChefId { get; set; }
        public string HeadChefName { get; set; }

        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
        
    }
}
