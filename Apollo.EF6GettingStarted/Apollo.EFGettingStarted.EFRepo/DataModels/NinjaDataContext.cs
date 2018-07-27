namespace Apollo.EFGettingStarted.EFRepo.DataModels
{
    using Apollo.EFGettingStarted.Shared.Models;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class NinjaDataContext : DbContext
    {
        // Your context has been configured to use a 'NinjaDataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Apollo.EFGettingStarted.EFRepo.DataModel.NinjaDataContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'NinjaDataContext' 
        // connection string in the application configuration file.
        public NinjaDataContext()
             : base("name=NinjaDataContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Ninja> Ninjas { get; set; }
        public virtual DbSet<Clan> Clans { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
    }
}