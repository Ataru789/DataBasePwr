using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public int BookId { get; set; }
        public short Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
