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
    public class BookingsController : Controller
    {
        private readonly DataContext _context;

        public BookingsController(DataContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.bookings.Include(b => b.Client).Include(b => b.Employee).Include(b => b.TattooShop);
            return View(await dataContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.bookings
                .Include(b => b.Client)
                .Include(b => b.Employee)
                .Include(b => b.TattooShop)
                .FirstOrDefaultAsync(m => m.BookingID == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            ViewData["ClientID"] = new SelectList(_context.clients, "ClientID", "ClientName");
            ViewData["EmployeeID"] = new SelectList(_context.employees, "EmployeeID", "EmployeeName");
            ViewData["TattooShopID"] = new SelectList(_context.tattooShops, "TattooShopID", "TattooShopName");
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingID,Date,EmployeeID,ClientID,TattooShopID")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientID"] = new SelectList(_context.clients, "ClientID", "ClientName", booking.ClientID);
            ViewData["EmployeeID"] = new SelectList(_context.employees, "EmployeeID", "EmployeeName", booking.EmployeeID);
            ViewData["TattooShopID"] = new SelectList(_context.tattooShops, "TattooShopID", "TattooShopName", booking.TattooShopID);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["ClientID"] = new SelectList(_context.clients, "ClientID", "ClientName", booking.ClientID);
            ViewData["EmployeeID"] = new SelectList(_context.employees, "EmployeeID", "EmployeeName", booking.EmployeeID);
            ViewData["TattooShopID"] = new SelectList(_context.tattooShops, "TattooShopID", "TattooShopName", booking.TattooShopID);
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingID,Date,EmployeeID,ClientID,TattooShopID")] Booking booking)
        {
            if (id != booking.BookingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingID))
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
            ViewData["ClientID"] = new SelectList(_context.clients, "ClientID", "ClientName", booking.ClientID);
            ViewData["EmployeeID"] = new SelectList(_context.employees, "EmployeeID", "EmployeeName", booking.EmployeeID);
            ViewData["TattooShopID"] = new SelectList(_context.tattooShops, "TattooShopID", "TattooShopName", booking.TattooShopID);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.bookings
                .Include(b => b.Client)
                .Include(b => b.Employee)
                .Include(b => b.TattooShop)
                .FirstOrDefaultAsync(m => m.BookingID == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.bookings.FindAsync(id);
            _context.bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.bookings.Any(e => e.BookingID == id);
        }
    }
}
