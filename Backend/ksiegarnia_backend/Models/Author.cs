using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        //utworzenie relacji Author 1:wiele Book
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
