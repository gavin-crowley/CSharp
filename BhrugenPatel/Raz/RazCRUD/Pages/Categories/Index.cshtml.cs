using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazCRUD.Data;
using RazCRUD.Model;

namespace RazCRUD.Pages.Categories
{
    public class IndexModel : PageModel
    {   //  In order  to work with database, we need dependency injection with the application DB context
        private readonly ApplicationDbContext _db;

        //  Create IEnumerable property to hold category list
        public IEnumerable<Category> Categories { get; set; }

        //Now we want an implementation of this class using dependency injection.That will be  done inside constructor.
        // implementation of application DB context and give  that to us in a variable with the name of dB
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {   // will retrieve list of categories
            Categories = _db.Category;
        }
    }
}
