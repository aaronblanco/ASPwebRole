using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPwebRole.Models
{
    public class Map
    {
        [Key]
        public int IdMap { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int MinimumLevel{get; set; }

        public ICollection<Zone> Zones { get; set; }

    }
}
