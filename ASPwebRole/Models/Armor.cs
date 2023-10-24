using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPwebRole.Models
{
    public class Armor
    {
        [Key]
        public int ArmorId { get; set; }
        [Required]
        public string ArmorName { get; set; }
        [Required]
        public string ArmorDescription { get; set; }
        [Required]
        public string ArmorType { get; set; }
        [Required]
        public double ArmorDurability { get; set; }
        [ForeignKey("IdObjectGame")]
        public ObjectGame ObjectGame { get; set; }
    }
}
