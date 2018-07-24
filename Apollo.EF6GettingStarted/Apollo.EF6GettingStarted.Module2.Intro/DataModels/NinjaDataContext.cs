using Apollo.EF6GettingStarted.Module2.Intro.Models;
using System.Data.Entity;

namespace Apollo.EF6GettingStarted.Module2.Intro.DataModels
{
    public class NinjaDataContext : DbContext
    {
        public NinjaDataContext()
            : base("name=NinjaDataContext")
        {
        }

        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
    }
}
