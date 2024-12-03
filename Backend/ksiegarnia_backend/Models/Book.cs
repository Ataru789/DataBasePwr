using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public required string Title { get; set; }
        public decimal Price { get; set; }
        public required string Availability { get; set; }
    }
}
