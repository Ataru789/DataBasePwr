using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ksiegarnia_backend.Data;
using ksiegarnia_backend.Models;

namespace ksiegarnia_backend.Pages.BooksUser
{
    public class AddToCartModel : PageModel
    {
        private readonly AppDbContext _db;

        public AddToCartModel(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult OnGet(int id)
        {
            // Przyk³adowy UserId - nale¿y pobraæ go z aktualnie zalogowanego u¿ytkownika
            int customerId = 1;

            var existingCartItem = _db.ShoppingCarts
                .FirstOrDefault(c => c.BookId == id && c.CustomerId == customerId);

            if (existingCartItem != null)
            {
                existingCartItem.Quantity += 1;
            }
            else
            {
                var cartItem = new ShoppingCart
                {
                    BookId = id,
                    CustomerId = customerId,
                    Quantity = 1
                };
                _db.ShoppingCarts.Add(cartItem);
            }

            _db.SaveChanges();

            return RedirectToPage("/BooksUser/IndexUser");
        }
    }
}
