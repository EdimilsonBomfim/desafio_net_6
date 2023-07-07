using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TGregDemo.Domain.Entities;
using TGregDemo.Web.Data;

namespace TGregDemo.Web.Controllers
{
    public class AdressesController : Controller
    {
        private readonly TGregDemoWebContext _context;

        public AdressesController(TGregDemoWebContext context)
        {
            _context = context;
        }

        // GET: Adresseses
        public async Task<IActionResult> Index()
        {
              return _context.Adresses != null ? 
                          View(await _context.Adresses.ToListAsync()) :
                          Problem("Entity set 'TGregDemoWebContext.Adresses'  is null.");
        }

        // GET: Adresseses/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Adresses == null)
            {
                return NotFound();
            }

            var adress = await _context.Adresses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adress == null)
            {
                return NotFound();
            }

            return View(adress);
        }

        // GET: Adresseses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Adresseses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,Name,Number,PostalCode,City,State,Id")] Adress adress)
        {
            if (ModelState.IsValid)
            {
                adress.Id = Guid.NewGuid();
                _context.Add(adress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adress);
        }

        // GET: Adresseses/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Adresses == null)
            {
                return NotFound();
            }

            var adress = await _context.Adresses.FindAsync(id);
            if (adress == null)
            {
                return NotFound();
            }
            return View(adress);
        }

        // POST: Adresseses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CustomerId,Name,Number,PostalCode,City,State,Id")] Adress adress)
        {
            if (id != adress.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdressesExists(adress.Id))
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
            return View(adress);
        }

        // GET: Adresseses/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Adresses == null)
            {
                return NotFound();
            }

            var adress = await _context.Adresses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adress == null)
            {
                return NotFound();
            }

            return View(adress);
        }

        // POST: Adresseses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Adresses == null)
            {
                return Problem("Entity set 'TGregDemoWebContext.Adresses'  is null.");
            }
            var adress = await _context.Adresses.FindAsync(id);
            if (adress != null)
            {
                _context.Adresses.Remove(adress);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdressesExists(Guid id)
        {
          return (_context.Adresses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
