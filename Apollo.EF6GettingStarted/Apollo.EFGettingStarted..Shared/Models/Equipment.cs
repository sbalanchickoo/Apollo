using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apollo.EFGettingStarted.Shared.Models
{
    public class Equipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        [Index("IX_EquipmentName", IsUnique = true)]
        public string Name { get; set; }

        public EquipmentType Type { get; set; }

        [Required]
        public Ninja Ninja { get; set; }
    }
}