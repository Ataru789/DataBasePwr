using System.ComponentModel.DataAnnotations;

namespace ksiegarnia_backend.Models
{
    public class ShippingInfo
    {
        [Key]
        public int ShippingId { get; set; }
        public  Status ShippingStatus { get; set; }
        public decimal ShippingCost { get; set; }

        //utworzenie relacji Order 1:1 ShippingInfo
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
    }

    public enum Status
    {
        WTrakcieRealizacji,
        Wyslane,
        Dostarczone
    }
}
