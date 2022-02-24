using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarterM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.ViewComponents
{
    public class OperaListViewComponent:ViewComponent
    {
        readonly OperaContext _context;

        public OperaListViewComponent(OperaContext context)
        {
            _context = context;
        }

        //public IViewComponentResult Invoke()
        //{
        //    return View(_context.Operas.ToList());
        //}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Operas.ToListAsync());
        }
    }
}
