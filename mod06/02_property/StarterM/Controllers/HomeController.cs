using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public IActionResult Index()
        {
            ViewBag.result = Id;
            return View();
        }
    }
}
