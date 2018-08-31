using Apollo.EFCore.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Apollo.EFCore.EF.Models
{
    public class RestaurantContext : DbContext
    {
        private string _connectionString;
        public string ConnectionString
        {
            get
            {
                if (_connectionString == null)
                {
                    _connectionString = @"Server = (localdb)\MSSQLLocalDB; Database = RestaurantReviews; Trusted_Connection = True; ";
                }
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<HeadChef> HeadChefs { get; set; }

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
                ConnectionString);
        }
    }
}
