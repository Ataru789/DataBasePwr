using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public required string Title { get; set; }
        public double Price { get; set; }
        public required int Availability { get; set; }

        //utworzenie relacji Author 1:wiele Book
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        //utworzenie relacji Book 1:wiele OrderItem
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
