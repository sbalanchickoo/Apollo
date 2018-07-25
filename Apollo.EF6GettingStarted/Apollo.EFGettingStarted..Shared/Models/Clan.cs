using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apollo.EFGettingStarted.Shared.Models
{
    public class Clan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        [Index("IX_ClanName", IsUnique = true)]
        public string ClanName { get; set; }

        public List<Ninja> Ninja { get; set; }
    }
}