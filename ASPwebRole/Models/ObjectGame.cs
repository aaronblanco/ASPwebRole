using System.ComponentModel.DataAnnotations;

namespace ASPwebRole.Models
{
    public class ObjectGame
    {
        [Key]
        public int IdObjectGame { get; set; }
        [Required]
        public string NameObject { get; set; }
        [Required]
        public string Price { get; set; }

        public ICollection<Weapon>? Weapons { get; set; }
        public ICollection<Armor>? Armors { get; set; }
        public ICollection<Consumable>? Consumables { get; set; }
    }
}