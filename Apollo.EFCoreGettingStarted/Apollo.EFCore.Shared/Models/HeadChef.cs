namespace Apollo.EFCore.Shared.Models
{
    public class HeadChef
    {
        public int HeadChefId { get; set; }
        public string HeadChefName { get; set; }

        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }

    }
}
