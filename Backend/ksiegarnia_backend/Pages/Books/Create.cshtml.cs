using ksiegarnia_backend.Data;
using ksiegarnia_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ksiegarnia_backend.Pages.Books
{
    public class CreateBookModel : PageModel
    {
        private readonly AppDbContext _db;
        [BindProperty]
        public Book Book { get; set; }
        public CreateBookModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _db.Books.Add(Book);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
