using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StarterM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        //[ViewData]
        //public List<SelectListItem> Categories { get; set; }=
        //      new List<SelectListItem>
        //     {
        //        new SelectListItem { Value = "1", Text = "Arts" },
        //        new SelectListItem { Value = "2", Text = "Cookbooks" },
        //        new SelectListItem { Value = "3", Text = "Computers" },
        //        new SelectListItem { Value = "4", Text = "History" },
        //        new SelectListItem { Value = "5", Text = "Literature" }
        //     };


        public IActionResult Index()
        {          
            return View();
        }
        [HttpPost]
        public IActionResult Index(Book book)
        {
            return Json(book);
            //return View();
        }
    }
}
