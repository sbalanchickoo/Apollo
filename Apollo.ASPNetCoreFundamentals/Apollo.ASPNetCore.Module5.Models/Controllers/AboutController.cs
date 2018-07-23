using Microsoft.AspNetCore.Mvc;

namespace Apollo.ASPNetCore.Module5.RestaurantReviews.Controllers
{
    [Route("about")]
    public class AboutController
    {
        [Route("phone")]
        public string Phone()
        {
            return "100";
        }

        [Route("address")]
        public string Address()
        {
            return "London";
        }
    }
}
