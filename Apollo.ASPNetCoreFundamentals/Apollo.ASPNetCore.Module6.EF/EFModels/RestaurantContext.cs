using Apollo.ASPNetCore.Module6.RestaurantReviews.Models;
using Microsoft.EntityFrameworkCore;

namespace Apollo.ASPNetCore.Module6.RestaurantReviews.EFModels
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Cuisine> Cuisine { get; set; }
        public DbSet<Greeting> Greeting { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(
                "Server = (localdb)\\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
    }
}
