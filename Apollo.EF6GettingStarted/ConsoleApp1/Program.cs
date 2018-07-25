using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Clan c1 = new Clan { ClanName = "a" };
            Clan c2 = new Clan { ClanName = "b" };
            Console.WriteLine($"Clan name: [{c1.ClanName}]; Clan Id: [{c1.Id}]");
            Console.WriteLine($"Clan name: [{c2.ClanName}]; Clan Id: [{c2.Id}]");
            Console.ReadLine();
        }
    }

   public  class Clan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string ClanName { get; set; }
    }
}
