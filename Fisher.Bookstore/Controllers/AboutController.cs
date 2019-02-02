using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Content("About Controller Test");
        }
        public IActionResult History()
        {
           return View();
           // return Content("History Controller Test");
        }
        public IActionResult Location()
        {
            return View();
          //  return Content("Location Controller Test");
        }
    }
}