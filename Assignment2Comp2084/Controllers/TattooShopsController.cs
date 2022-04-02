using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment2Comp2084.Data;
using Assignment2Comp2084.Models;

namespace Assignment2Comp2084.Controllers
{
    public class TattooShopsController : Controller
    {
        private readonly DataContext _context;

        public TattooShopsController(DataContext context)
        {
            _context = context;
        }

        // GET: TattooShops
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.tattooShops.Include(t => t.Owner);
            return View(await dataContext.ToListAsync());
        }

        // GET: TattooShops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tattooShop = await _context.tattooShops
                .Include(t => t.Owner)
                .FirstOrDefaultAsync(m => m.TattooShopID == id);
            if (tattooShop == null)
            {
                return NotFound();
            }

            return View(tattooShop);
        }

        // GET: TattooShops/Create
        public IActionResult Create()
        {
            ViewData["OwnerID"] = new SelectList(_context.owners, "OwnerID", "OwnerName");
            return View();
        }

        // POST: TattooShops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TattooShopID,TattooShopName,OwnerID,TattooShopLocation,TattooShopNumber")] TattooShop tattooShop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tattooShop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerID"] = new SelectList(_context.owners, "OwnerID", "OwnerName", tattooShop.OwnerID);
            return View(tattooShop);
        }

        // GET: TattooShops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tattooShop = await _context.tattooShops.FindAsync(id);
            if (tattooShop == null)
            {
                return NotFound();
            }
            ViewData["OwnerID"] = new SelectList(_context.owners, "OwnerID", "OwnerName", tattooShop.OwnerID);
            return View(tattooShop);
        }

        // POST: TattooShops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TattooShopID,TattooShopName,OwnerID,TattooShopLocation,TattooShopNumber")] TattooShop tattooShop)
        {
            if (id != tattooShop.TattooShopID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tattooShop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TattooShopExists(tattooShop.TattooShopID))
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
            ViewData["OwnerID"] = new SelectList(_context.owners, "OwnerID", "OwnerName", tattooShop.OwnerID);
            return View(tattooShop);
        }

        // GET: TattooShops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tattooShop = await _context.tattooShops
                .Include(t => t.Owner)
                .FirstOrDefaultAsync(m => m.TattooShopID == id);
            if (tattooShop == null)
            {
                return NotFound();
            }

            return View(tattooShop);
        }

        // POST: TattooShops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tattooShop = await _context.tattooShops.FindAsync(id);
            _context.tattooShops.Remove(tattooShop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TattooShopExists(int id)
        {
            return _context.tattooShops.Any(e => e.TattooShopID == id);
        }
    }
}
