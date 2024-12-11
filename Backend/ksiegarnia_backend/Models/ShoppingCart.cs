using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartId { get; set; }
        public int BookId { get; set; }
        public short Quantity { get; set; }

        //utworzenie relacji Customer 1:wiele ShoppingCart
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

    }
}
