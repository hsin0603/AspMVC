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
        //public IActionResult Index(int operaid, string title)
        //{
        //    Opera opera = new()
        //    {
        //        OperaID = operaid,
        //        Title = title,
        //        Year = 1600,
        //        Composer = "佩里"
        //    };
        //    return View(opera);
        //}

        public IActionResult Index(Opera opera) //Model Binding
        {
            //Model Validation
            if (!ModelState.IsValid)
            {
                return View("~/views/home/index.cshtml");
            }
            return View(opera);
        }
    }
}
