using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPwebRole.Models
{
    public class Enemy
    {
        [Key]
        public int EnemyId { get; set; }
        [Required]
        public string EnemyName { get; set; }
        [Required]
        public string EnemyDescription { get; set; }
        [Required]
        public int EnemyHealth { get; set;}

        [ForeignKey("IdAtribute")]
        public Attribute HeroAttributes { get; set; }

    }
}
