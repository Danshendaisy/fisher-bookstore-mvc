using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Index-Author");
        }
         public IActionResult Featured()
        {
            return Content("Featured");
        }
       
    }
}