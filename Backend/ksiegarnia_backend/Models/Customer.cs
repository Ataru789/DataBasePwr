using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string City { get; set; }
        public required string ZipCode { get; set; }
        public required string Street { get; set; }
        public required string PhoneNumber { get; set; }

        //utworzenie relacji 1:1 z User
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        //utworzenie relacji Customer 1:wiele Order
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        //utworzenie relacji Customer 1:wiele ShoppingCart
        public ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
    }
}
