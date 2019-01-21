using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("Index-Book");
        }
         public IActionResult New()
        {
            return Content("New-Book");
        }
        
        [ActionName("Best-Seller")]
         public IActionResult Best()
        {
            return Content("BS-Book");
        }
    }
}