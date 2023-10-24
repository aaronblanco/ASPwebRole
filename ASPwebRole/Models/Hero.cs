
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPwebRole.Models
{
    public class Hero
    {
        [Key]
        public int IdHero { get; set; }

        [ForeignKey("Team")]
        public int idTeam { get; set; }

        [ForeignKey("IdInventory")]
        public Inventory HeroInventory { get; set; }

        [Required]
        public int limiteObjetos { get; set; }

        [ForeignKey("IdAtribute")]
        public Attribute HeroAttributes { get; set; }

    }
}