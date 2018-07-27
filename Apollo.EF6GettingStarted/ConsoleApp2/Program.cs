using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Product
    {
        [Required]
        [MaxLength(128)]
        [Index("IX_ClanName", IsUnique = true)]
        public string ProductName { get; set; }
    }
}
