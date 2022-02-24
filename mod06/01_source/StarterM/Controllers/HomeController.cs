using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromForm]string id, [FromHeader] string accept)
        {
            ViewBag.result = id;
            ViewBag.accept = accept;
            return View();
        }
    }
}
