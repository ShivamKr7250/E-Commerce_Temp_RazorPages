using E_Commerce_Temp_RazorPages.Data;
using E_Commerce_Temp_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce_Temp_RazorPages.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category? Category { get; set; }

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int? id)
        {
            if(id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category Updated Successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
