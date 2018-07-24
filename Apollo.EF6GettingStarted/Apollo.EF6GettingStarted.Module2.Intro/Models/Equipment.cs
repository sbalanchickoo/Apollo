using System.ComponentModel.DataAnnotations;

namespace Apollo.EF6GettingStarted.Module2.Intro.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EquipmentType Type { get; set; }
        [Required]
        public Ninja Ninja { get; set; }
    }
}