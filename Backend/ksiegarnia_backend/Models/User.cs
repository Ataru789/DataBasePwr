using System.ComponentModel.DataAnnotations;

namespace ksiegarnia_backend.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        public string Username { get; set; }

        //utworzenie relacji 1:1 z Admin
        public Admin Admin { get; set; }

        //utworzenie relacji 1:1 z Customer
        public Customer Customer { get; set; }
    }
}
