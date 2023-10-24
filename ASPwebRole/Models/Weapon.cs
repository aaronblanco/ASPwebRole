using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPwebRole.Models
{
    public class Weapon
    {
        [Key]
        public int IdWeapon { get; set; }
        [Required]
        public double WeaponDamage { get; set; }
        [Required]
        public string WeaponName { get; set;}
        [Required]
        public string WeaponType { get; set;}
        [Required]
        public string WeaponDescription { get; set;}
        [ForeignKey("IdObjectGame")]
        public ObjectGame ObjectGame { get; set; }

    }
}
