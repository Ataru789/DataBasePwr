using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
