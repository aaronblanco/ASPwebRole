using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPwebRole.Models
{
    public class Consumable
    {
        [Key]
        public int IdConsumable { get; set; }

        [ForeignKey("IdObjectGame")]
        public ObjectGame ObjectGame { get; set; }
        [Required]
        public string ConsumableName { get; set; }

        [Required]
        public string ConsumableType { get; set; }

        [Required]
        public string ConsumableDescription { get; set; }
    }
}
