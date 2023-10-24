using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPwebRole.Models
{
    public class Team
    {
        [Key]
        int IdTeam { get; set; }

        [Required]
        public ICollection<Hero> Heroes { get; set; }

        [ForeignKey("IdInventory")]
        public Inventory InventoryTeam { get; set; }

        [Required]
        string TeamName { get; set; }

        [ForeignKey("IdUser")]
        public User UserAssoc { get; set; }

    }
}