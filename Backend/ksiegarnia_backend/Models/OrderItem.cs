using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public short Quantity { get; set; }
        public decimal Price { get; set; }

        //utworzenie relacji Order 1:wiele OrderItem
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        //utworzenie relacji Book 1:wiele OrderItem
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
    }
}
