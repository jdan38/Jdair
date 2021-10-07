using Jdair2.Data;
using Jdair2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jdair2.Areas.Operation.Controllers
{
    [Area("Operation")]
    public class AirportsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AirportsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _db.Airports.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Airports airports)
        {
            if (ModelState.IsValid)
            {
                _db.Airports.Add(airports);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(airports);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var airports = await _db.Airports.FindAsync(id);
            if (airports == null)
            {
                return NotFound();
            }
            return View(airports);
        }

        [HttpPost, ]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Airports airports)
        {
            if (ModelState.IsValid)
            {
                _db.Airports.Update(airports);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(airports);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var airports = await _db.Airports.FindAsync(id);
            if (airports == null)
            {
                return NotFound();
            }
            return View(airports);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var airports = await _db.Airports.FindAsync(id);
            if (airports == null)
            {
                return NotFound();
            }

            _db.Airports.Remove(airports);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            var airports = await _db.Airports.FindAsync(id);
            if (airports == null)
            {
                return NotFound();
            }
            return View(airports);
        }

    }
}
