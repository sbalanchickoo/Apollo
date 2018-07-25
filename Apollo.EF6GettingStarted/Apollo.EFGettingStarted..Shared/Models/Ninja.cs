using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apollo.EFGettingStarted.Shared.Models
{
    public class Ninja
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        [Index("IX_ClanName", IsUnique = true)]
        public string Name { get; set; }

        public bool ServedInWar { get; set; }

        public Clan Clan { get; set; }

        public int ClanId { get; set; }

        public List<Equipment> EquipmentOwned { get; set; }
    }
}
