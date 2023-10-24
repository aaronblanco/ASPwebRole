using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPwebRole.Models
{
    public class Attribute
    {
        [Key]
        public int IdAtribute;
        [Required]
        public double Strenght { get; set; }
        [Required]
        public double Endurance { get; set; }
        [Required]
        public double Intellect { get; set; }


    }
}
