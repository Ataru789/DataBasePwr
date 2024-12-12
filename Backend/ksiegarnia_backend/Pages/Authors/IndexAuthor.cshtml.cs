using ksiegarnia_backend.Data;
using ksiegarnia_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ksiegarnia_backend.Pages.Authors
{
    public class IndexAuthorModel : PageModel
    {
        private readonly AppDbContext _db;
        public List<Author> AuthorList { get; set; }
        public IndexAuthorModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            AuthorList = _db.Authors.ToList();
        }
    }
}

