using Apollo.ASPNetCore.Module6.RestaurantReviews.Models;
using Apollo.EFCore.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Apollo.EFCore.Shared.EF
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Cuisine> Cuisine { get; set; }
        public DbSet<Greeting> Greeting { get; set; }
        public DbSet<HeadChef> HeadChef { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RestaurantCuisine>().HasKey(rc => new { rc.RestaurantId, rc.CuisineId });

            modelBuilder.Entity<Restaurant>()
                .HasOne(h => h.HeadChef)
                .WithOne(r => r.Restaurant)
                .HasForeignKey<HeadChef>(h => h.RestaurantId)
                .IsRequired();

            modelBuilder.Entity<Restaurant>()
                .HasIndex(r => r.HeadChefId)
                .IsUnique();

            modelBuilder.Entity<HeadChef>()
                .HasOne(r => r.Restaurant)
                .WithOne(h => h.HeadChef)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(
                "Server = (localdb)\\MSSQLLocalDB; Database = RestaurantReviews; Trusted_Connection = True; ");
        }
    }
}
