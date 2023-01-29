using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using C0550_Project_MVC.Data;
using CO550_Project_Razor.Models;

namespace C0550_Project_MVC.Controllers
{
    public class FilmShowsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FilmShowsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FilmShows
        public async Task<IActionResult> Index()
        {
              return View(await _context.FilmShow.ToListAsync());
        }

        // GET: FilmShows/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FilmShow == null)
            {
                return NotFound();
            }

            var filmShow = await _context.FilmShow
                .FirstOrDefaultAsync(m => m.FilmShowID == id);
            if (filmShow == null)
            {
                return NotFound();
            }

            return View(filmShow);
        }

        // GET: FilmShows/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FilmShows/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FilmShowID,DateTime")] FilmShow filmShow)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filmShow);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(filmShow);
        }

        // GET: FilmShows/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FilmShow == null)
            {
                return NotFound();
            }

            var filmShow = await _context.FilmShow.FindAsync(id);
            if (filmShow == null)
            {
                return NotFound();
            }
            return View(filmShow);
        }

        // POST: FilmShows/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FilmShowID,DateTime")] FilmShow filmShow)
        {
            if (id != filmShow.FilmShowID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filmShow);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmShowExists(filmShow.FilmShowID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(filmShow);
        }

        // GET: FilmShows/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FilmShow == null)
            {
                return NotFound();
            }

            var filmShow = await _context.FilmShow
                .FirstOrDefaultAsync(m => m.FilmShowID == id);
            if (filmShow == null)
            {
                return NotFound();
            }

            return View(filmShow);
        }

        // POST: FilmShows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FilmShow == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FilmShow'  is null.");
            }
            var filmShow = await _context.FilmShow.FindAsync(id);
            if (filmShow != null)
            {
                _context.FilmShow.Remove(filmShow);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmShowExists(int id)
        {
          return _context.FilmShow.Any(e => e.FilmShowID == id);
        }
    }
}
