
using Microsoft.AspNetCore.Mvc.RazorPages;
using TTMWebRazor_Temp.Data;
using TTMWebRazor_Temp.Models;

namespace TTMWebRazor_Temp.Pages.Categories
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
