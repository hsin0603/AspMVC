using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string Title { get; set; } = "Ucom";
        public IActionResult Index()
        {
            ViewBag.date1 = DateTime.Now;
            ViewData["date2"] = DateTime.Now;
            return View(DateTime.Now);
        }
    }
}
