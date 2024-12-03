using System.ComponentModel.DataAnnotations;


namespace ksiegarnia_backend.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string City { get; set; }
        public required string ZipCode { get; set; }
        public required string Street { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
