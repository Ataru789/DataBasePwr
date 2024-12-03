using System.ComponentModel.DataAnnotations;

namespace ksiegarnia_backend.Models
{
    public class ShippingInfo
    {
        [Key]
        public int ShippingId { get; set; }
        public int OrderId { get; set; }
        public  Status ShippingStatus { get; set; }
        public decimal ShippingCost { get; set; }
    }

    public enum Status
    {
        WTrakcieRealizacji,
        Wyslane,
        Dostarczone
    }
}
