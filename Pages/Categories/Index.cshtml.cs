using E_Commerce_Temp_RazorPages.Data;
using E_Commerce_Temp_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce_Temp_RazorPages.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public List<Category> CategoryList { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
            
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList(); 
        }
    }
}
