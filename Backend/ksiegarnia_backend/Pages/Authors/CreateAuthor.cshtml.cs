using ksiegarnia_backend.Data;
using ksiegarnia_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ksiegarnia_backend.Pages.Authors
{
    public class CreateAuthorModel : PageModel
    {
        private readonly AppDbContext _db;
        [BindProperty]
        public Author Author { get; set; }
        public CreateAuthorModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _db.Authors.Add(Author);
            _db.SaveChanges();
            return RedirectToPage("IndexAuthor");
        }
    }
}
