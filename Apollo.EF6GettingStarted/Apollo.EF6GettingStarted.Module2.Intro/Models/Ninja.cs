using System.Collections.Generic;

namespace Apollo.EF6GettingStarted.Module2.Intro.Models
{
    public class Ninja
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ServedInWar { get; set; }
        public Clan Clan { get; set; }
        public int ClanId { get; set; }
        public List<Equipment> EquipmentOwned { get; set; }
    }
}
