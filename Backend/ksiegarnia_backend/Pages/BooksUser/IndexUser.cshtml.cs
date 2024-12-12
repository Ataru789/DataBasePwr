using ksiegarnia_backend.Data;
using ksiegarnia_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ksiegarnia_backend.Pages.Books
{
    public class IndexUserModel : PageModel
    {
        private readonly AppDbContext _db;
        public List<Book> BookList { get; set; }
        public IndexUserModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            BookList = _db.Books.ToList();
        }
    }
}