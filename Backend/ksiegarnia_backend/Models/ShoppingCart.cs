using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public short Quantity { get; set; }
    }
}
