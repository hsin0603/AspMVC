using Microsoft.AspNetCore.Mvc;
using StarterM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Controllers
{
    public class OperaController : Controller
    {
        public IActionResult Index()
        {
            Opera opera = new()
            {
                OperaID = 1,
                Title = "尤麗狄西",
                Year = 1600,
                Composer = "佩里"

            };
            return View(opera);
        }
    }
}
