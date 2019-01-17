using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("About Controller Test");
        }
        public IActionResult History()
        {
            return Content("History Controller Test");
        }
        public IActionResult Location()
        {
            return Content("Location Controller Test");
        }
    }
}