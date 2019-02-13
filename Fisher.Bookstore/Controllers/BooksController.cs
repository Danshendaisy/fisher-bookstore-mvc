using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    [Route("books")]
    public class BooksController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
          return View();
        //    return Content("Index-Book");
        }
        [Route("new")]
         public IActionResult New()
        {
            return View();
         //  return Content("New-Book");
        }
        
        [Route("best-sellers")]
         public IActionResult Best()
        {
         return View();
        //return Content("BS-Book");
        }
    }
}