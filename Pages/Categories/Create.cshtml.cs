using E_Commerce_Temp_RazorPages.Data;
using E_Commerce_Temp_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce_Temp_RazorPages.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Category Category { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;

        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category Created Successfully";
            return RedirectToPage("Index");
        }
    }
}
