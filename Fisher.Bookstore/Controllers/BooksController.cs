using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
          return View();
          //  return Content("Index-Book");
        }
         public IActionResult New()
        {
            return View();
           // return Content("New-Book");
        }
        
        [ActionName("Best-Sellers")]
         public IActionResult Best()
        {
        return View();
          //  return Content("BS-Book");
        }
    }
}