using Apollo.ASPNetCore.Module6.RestaurantReviews.Models;
using Microsoft.EntityFrameworkCore;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.EFModels
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Cuisine> Cuisine { get; set; }
        //public DbSet<Greeting> Greeting { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(
                "Server = (localdb)\\MSSQLLocalDB; Database = RestaurantReviews; Trusted_Connection = True; ");
        }
    }
}
