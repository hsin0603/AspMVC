using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //overloading
        public string SayHi()=> "Hi";

        // home/sayhi?name=Mary
        [HttpPost]
        public string SayHi(string name) => $"Hi {name}";

        public string XMLDemo()
        {
            return "<book><title>c#</title><price>50</price></book>";
        }
        public IActionResult XMLDemo2()
        {
            return Content("<book><title>c#</title><price>50</price></book>",Text.Xml);
        }

        public IActionResult JsonDemo()
        {
            var opera = new 
            {
                OperaID = 1,
                Title = "Euridice",
                Year = 1600,
                Composer = "Jacopo Peri"
            };

            return Json(opera);
        }

    }
}
