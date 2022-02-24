using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Basic()
        {
            return View();
        }

        public IActionResult GridDemo()
        {
            return View();
        }

        public IActionResult FormDemo()
        {
            return View();
        }
    }
}
