using ksiegarnia_backend.Data;
using ksiegarnia_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ksiegarnia_backend.Pages.Authors
{
    [BindProperties]
    public class DeleteAuthorModel : PageModel
    {
        private readonly AppDbContext _db;
        public Author Author { get; set; }
        public DeleteAuthorModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null & id != 0)
            {
                Author = _db.Authors.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            Author obj = _db.Authors.Find(Author.AuthorId);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Authors.Remove(obj);
            _db.SaveChanges();
            return RedirectToPage("IndexAuthor");
        }
    }
}