using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
          //  return Content("Index-Author");
        }
         public IActionResult Featured()
        {
            return View();
          //  return Content("Featured");
        }
       
    }
}