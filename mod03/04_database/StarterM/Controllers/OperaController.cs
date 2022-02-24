using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarterM.Data;
using StarterM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Controllers
{
    public class OperaController : Controller
    {
        readonly OperaContext _context;

        public OperaController(OperaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Operas.ToListAsync());
        }
    }
}
