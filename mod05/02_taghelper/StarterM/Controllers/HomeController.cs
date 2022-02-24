using Microsoft.AspNetCore.Mvc;
using StarterM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Book book)
        {
            //return Json(book);
            return View();
        }
    }
}
