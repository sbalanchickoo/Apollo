using System.Collections.Generic;

namespace Apollo.EF6GettingStarted.Module2.Intro.Models
{
    public class Clan
    {
        public int Id { get; set; }
        public string ClanName { get; set; }
        public List<Ninja> Ninja { get; set; }
    }
}