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

        public IActionResult CSSDemo()
        {
            return View();
        }

        public IActionResult AjaxDemo()
        {
            return View();
        }

        // /home/getbook/1
        // /home/getbook?id=2
        public IActionResult GetBook(int id)
        {
            List<Book> books = new List<Book> {
                new Book { BookId=1, Title="C#", Price=1000 },
                new Book { BookId=2, Title="VB", Price=500 },
                new Book { BookId=3, Title="JS", Price=1200 },
                new Book { BookId=4, Title="MVC", Price=1500 },
                new Book { BookId=5, Title="XML", Price=300 }
            };
            var book = books.Find(b => b.BookId == id);
            if (book==null)
            {
                return NotFound();
            }

            return Json(book);
        }
    }
}
