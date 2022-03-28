using Microsoft.AspNetCore.Mvc;
using System;

namespace MyInAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }

        public IActionResult Details(int id)
        {
            return Ok("You have entered id = " + id);
        }
    }
}
