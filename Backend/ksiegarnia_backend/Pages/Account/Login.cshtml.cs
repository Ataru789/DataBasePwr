using ksiegarnia_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ksiegarnia_backend.Data;

namespace ksiegarnia_backend.Pages.Account
{
    public class LoginRegisterModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public LoginRegisterModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Credencial LoginCredentials { get; set; } = new();

        [BindProperty]
        public Credencial RegisterCredentials { get; set; } = new();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
           
            var action = Request.Form["action"].ToString();

            if (action == "login")
            {
            
                var user = await _dbContext.Users.FirstOrDefaultAsync(u =>
                    u.Email == LoginCredentials.Email && u.Password == LoginCredentials.Password);

                if (user != null)
                {
                   
                    return RedirectToPage("/Index");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login credentials.");
                    return Page();
                }
            }
            else if (action == "register")
            {
              
                if (ModelState.IsValid)
                {
                    _dbContext.Users.Add(RegisterCredentials);
                    await _dbContext.SaveChangesAsync();
                    return RedirectToPage("/Index");
                }

                return Page();
            }

            return Page();
        }
    }

    public class Credencial : User
    {
    }
}
