using ksiegarnia_backend.Data;
using ksiegarnia_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ksiegarnia_backend.Pages.BooksUser
{
    public class CartModel : PageModel
    {
        private readonly AppDbContext _db;

        public CartModel(AppDbContext db)
        {
            _db = db;
        }

        public List<ShoppingCart> CartItems { get; set; }

        public void OnGet()
        {
            int customerId = 1; // Przyk³adowy UserId 
            CartItems = _db.ShoppingCarts
                .Include(c => c.Book)
                .Where(c => c.CustomerId == customerId)
                .ToList();
        }

    }
}