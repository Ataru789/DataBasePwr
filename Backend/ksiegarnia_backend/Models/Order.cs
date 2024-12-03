using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
    }
}
