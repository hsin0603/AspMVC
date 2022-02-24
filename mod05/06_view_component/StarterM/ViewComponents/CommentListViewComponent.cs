using Microsoft.AspNetCore.Mvc;
using StarterM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.ViewComponents
{
    public class CommentListViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Comment> data = new()
            {
              new Comment{Id=100,Subject="A"},
              new Comment{Id=200,Subject="B"},
              new Comment{Id=300,Subject="C"},
              new Comment{Id=400,Subject="D"},
              new Comment{Id=500,Subject="E"},
              new Comment{Id=600,Subject="F"}
            };
            return View(data);
        }
    }
}
