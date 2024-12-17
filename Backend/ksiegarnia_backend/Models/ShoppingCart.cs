using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ksiegarnia_backend.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartId { get; set; }
        public short Quantity { get; set; }

        //utworzenie relacji Customer 1:wiele ShoppingCart
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; } = null!;

    }
}
