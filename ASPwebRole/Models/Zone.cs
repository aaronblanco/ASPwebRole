using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPwebRole.Models
{
    public class Zone
    {
        [Key]
        public string ZoneId { get; set; }
        [Required]
        public string ZoneName { get; set; }
        [Required]
        public Map ZoneMap { get; set; }

        [Required]
        public int ZoneLevel { get; set; }
        [Required]
        public  string ZoneDescription { get; set; }
        [Required]
        public ICollection<Enemy> Enemys { get; set; }

        [ForeignKey("IdMap")]
        public Map MapAssigned { get; set; }

    }
}
