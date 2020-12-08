using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OshawaMechanic.Models;

namespace OshawaMechanic.Controllers
{
    public class CoustmersController : Controller
    {
        private readonly OshawaMechanicContext _context;

        public CoustmersController(OshawaMechanicContext context)
        {
            _context = context;
        }

        // GET: Coustmers
        public async Task<IActionResult> ViewCoustmers()
        {
            return View(await _context.Coustmers.ToListAsync());
        }

        // GET: Coustmers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coustmers = await _context.Coustmers
                .FirstOrDefaultAsync(m => m.coustmerId == id);
            if (coustmers == null)
            {
                return NotFound();
            }

            return View(coustmers);
        }

        // GET: Coustmers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Coustmers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("coustmerId,coustmerName,coustmerphoneNumber,coustmerAddress")] Coustmers coustmers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coustmers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ViewCoustmers));
            }
            return View(coustmers);
        }

        // GET: Coustmers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coustmers = await _context.Coustmers.FindAsync(id);
            if (coustmers == null)
            {
                return NotFound();
            }
            return View(coustmers);
        }

        // POST: Coustmers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("coustmerId,coustmerName,coustmerphoneNumber,coustmerAddress")] Coustmers coustmers)
        {
            if (id != coustmers.coustmerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coustmers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoustmersExists(coustmers.coustmerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ViewCoustmers));
            }
            return View(coustmers);
        }

        // GET: Coustmers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coustmers = await _context.Coustmers
                .FirstOrDefaultAsync(m => m.coustmerId == id);
            if (coustmers == null)
            {
                return NotFound();
            }

            return View(coustmers);
        }

        // POST: Coustmers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coustmers = await _context.Coustmers.FindAsync(id);
            _context.Coustmers.Remove(coustmers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ViewCoustmers));
        }

        private bool CoustmersExists(int id)
        {
            return _context.Coustmers.Any(e => e.coustmerId == id);
        }
    }
}
