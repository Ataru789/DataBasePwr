using ksiegarnia_backend.Data;
using ksiegarnia_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ksiegarnia_backend.Pages.Books
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _db;
        public Book Book { get; set; }
        public DeleteModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null & id != 0)
            {
                Book = _db.Books.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            Book obj = _db.Books.Find(Book.BookId);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Books.Remove(obj);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}