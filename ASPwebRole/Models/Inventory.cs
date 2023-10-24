using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPwebRole.Models
{
    public class Inventory
    {
        [Key]
        public int IdInventory {get; set;}
        
        [Required]
        public int ObjectLimit;

        public ICollection<ObjectGame> ElementList { get; set;}
    } 
}

