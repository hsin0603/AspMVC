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

    
      
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opera = await _context.Operas.FirstOrDefaultAsync(o => o.OperaID == id);
            if (opera == null)
            {
                return NotFound();
            }

            _context.Remove(opera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opera = await _context.Operas.FindAsync(id);


            if (opera == null)
            {
                return NotFound();
            }

            return View(opera);
        }

        [HttpPost]
                public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opera = await _context.Operas.FindAsync(id);

            if (ModelState.IsValid)
            {
                _context.Update(opera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(opera);
        }



        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(opera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(opera);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }

            var opera = await _context.Operas.FirstOrDefaultAsync(o => o.OperaID == id);
           

            if (opera==null)
            {
                return NotFound();
            }

            return View(opera);
        }

        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewBag.titleSort = sortOrder == "title" ? "title_desc" : "title";
            ViewBag.yearSort = sortOrder == "year" ? "year_desc" : "year";

            var query = _context.Operas.AsQueryable();

            switch (sortOrder)
            {
                case "title":
                    query = query.OrderBy(o => o.Title);
                    break;
                case "title_desc":
                    query = query.OrderByDescending(o => o.Title);
                    break;
                case "year":
                    query = query.OrderBy(o => o.Year);
                    break;
                case "year_desc":
                    query = query.OrderByDescending(o => o.Year);
                    break;

                default:
                    break;
            }


            return View(await query.ToListAsync());
        }
    }
}
