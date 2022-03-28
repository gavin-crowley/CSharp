using Microsoft.AspNetCore.Mvc;
using MyInAndOut.Data;
using MyInAndOut.Models;
using System.Collections.Generic;

namespace MyInAndOut.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }
    }
}
