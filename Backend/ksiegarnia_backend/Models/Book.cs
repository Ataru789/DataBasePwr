using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        [MaxLength(100)]
        public required string Title { get; set; }
        [Precision(10,2)]
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        [MaxLength(100)]
        public string ImageFileName { get; set; } = string.Empty;
        public required string Availability { get; set; }
    }
}
