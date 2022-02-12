using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazCRUD.Data;
using RazCRUD.Model;

namespace RazCRUD.Pages.Categories;

[BindProperties]
public class CreateModel : PageModel
{   //  In order to work with database, we need dependency injection with the application DB context
    private readonly ApplicationDbContext _db;

    // don't need an IEnumerable, just want one single category
    public Category Category { get; set; }

    public CreateModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost()
    {
        if (Category.Name == Category.DisplayOrder.ToString())
        {
            ModelState.AddModelError("Category.Name", "The DisplayOrder cannot exactly match the Name.");
        }/*
        Valid if form inputs are correct*/
        if (ModelState.IsValid)
        {
            /*add category object to category table in db*/
            await _db.Category.AddAsync(Category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
        // returns to Create page
        return Page();
    }
}