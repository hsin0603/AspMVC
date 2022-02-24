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
        public IActionResult GetComments()
        {
            List<Comment> data = new List<Comment> {
             new Comment { Id = 100, Subject = "A" },
             new Comment { Id = 200, Subject = "B" },
             new Comment { Id = 300, Subject = "C" }
           };
            return View(data);
        }
        public IActionResult GetOtherComments()
        {
            List<Comment> data = new List<Comment> {
             new Comment { Id = 400, Subject = "D" },
             new Comment { Id = 500, Subject = "E" },
             new Comment { Id = 600, Subject = "F" }
           };
            return View(data);
        }

    }
}
