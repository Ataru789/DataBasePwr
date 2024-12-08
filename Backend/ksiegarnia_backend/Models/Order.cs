using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime Date { get; set; }

        //utworzenie relacji Customer 1:wiele Order
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        //utworzenie relacji Order 1:wiele OrderItem
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        //utworzenie relacji Order 1:1 ShippingInfo
        public ShippingInfo ShippingInfo { get; set; }

    }
}
