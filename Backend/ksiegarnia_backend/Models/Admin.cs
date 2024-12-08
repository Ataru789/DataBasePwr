using System.ComponentModel.DataAnnotations;

namespace ksiegarnia_backend.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        //Utworzenie relacji 1:1 z User
        public int UserId { get; set; }
        public User User { get; set; } = null!;

    }
}
