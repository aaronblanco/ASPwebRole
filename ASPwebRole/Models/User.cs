using System.ComponentModel.DataAnnotations;

namespace ASPwebRole.Models
{
    public class User
    {
        [Key]
        int IdUser { get; set; }
        [Required] 
        string Name { get; set; }
        [Required]
        string Password;
        [Required]
        public ICollection<Team> Teams { get; set; }

        public ICollection<User>? Friends { get; set; }

    }
}
