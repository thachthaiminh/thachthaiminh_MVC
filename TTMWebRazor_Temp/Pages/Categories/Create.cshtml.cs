using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TTMWebRazor_Temp.Data;
using TTMWebRazor_Temp.Models;

namespace TTMWebRazor_Temp.Pages.Categories
{
    [BindProperties]
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

        public IActionResult OnPost() { 
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category Created successfully!";
            return RedirectToPage("Index");
        }
    }
}
