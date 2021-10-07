using Jdair2.Data;
using Jdair2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jdair2.Areas.Operation.Controllers
{
    [Area("Operation")]
    public class MakemodelController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MakemodelController (ApplicationDbContext db)
        {
            _db = db;
        }



        // GET: Makemodel
        public async Task<IActionResult> Index()
        {
            return View(await _db.Makemodel.ToListAsync());
        }

       

        // GET: MakemodelController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MakemodelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Makemodel makemodel)
        {
          if(ModelState.IsValid)
            {
                _db.Makemodel.Add(makemodel);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(makemodel);
        }


        // GET: MakemodelController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            var makemodel = await _db.Makemodel.FindAsync(id);
            if(makemodel==null)
            {
                return NotFound();
            }
            return View(makemodel);
        }

        // POST: MakemodelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Makemodel makemodel)
        {
          if(ModelState.IsValid)
            {
                _db.Update(makemodel);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(makemodel);
        }

        // GET: MakemodelController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            {
                if (id == null)
                {
                    return NotFound();
                }

                var makemodel = await _db.Makemodel.FindAsync(id);
                if (makemodel == null)
                {
                    return NotFound();
                }
                return View(makemodel);
            }
        }

        // POST: MakemodelController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            
            var makemodel = await _db.Makemodel.FindAsync(id);
            
            if (makemodel == null)
            {
                return View();
            }
            _db.Makemodel.Remove(makemodel);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Makemodel/Details/
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var makemodel = await _db.Makemodel.FindAsync(id);
            if (makemodel == null)
            {
                return NotFound();
            }
            return View(makemodel);
        }
    }
}
