using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CatalogoInMemory.Models;

namespace CatalogoInMemory.Controllers
{
    public class ActorController : Controller
    {
        private readonly CatalogContext _context;

        public ActorController(CatalogContext context)
        {
            _context = context;
        }

        // GET: Actor
        public async Task<IActionResult> Index()
        {
              return _context.Actors != null ? 
                          View(await _context.Actors.ToListAsync()) :
                          Problem("Entity set 'CatalogContext.Actors'  is null.");
        }

        // GET: Actor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Actors == null)
            {
                return NotFound();
            }

            var actorModel = await _context.Actors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actorModel == null)
            {
                return NotFound();
            }

            return View(actorModel);
        }

        // GET: Actor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Actor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LastName")] ActorModel actorModel)
        {
                _context.Add(actorModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }

        // GET: Actor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Actors == null)
            {
                return NotFound();
            }

            var actorModel = await _context.Actors.FindAsync(id);
            if (actorModel == null)
            {
                return NotFound();
            }
            return View(actorModel);
        }

        // POST: Actor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,LastName")] ActorModel actorModel)
        {
            if (id != actorModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actorModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActorModelExists(actorModel.Id))
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
            return View(actorModel);
        }

        // GET: Actor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Actors == null)
            {
                return NotFound();
            }

            var actorModel = await _context.Actors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actorModel == null)
            {
                return NotFound();
            }

            return View(actorModel);
        }

        // POST: Actor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Actors == null)
            {
                return Problem("Entity set 'CatalogContext.Actors'  is null.");
            }
            var actorModel = await _context.Actors.FindAsync(id);
            if (actorModel != null)
            {
                _context.Actors.Remove(actorModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActorModelExists(int id)
        {
          return (_context.Actors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
