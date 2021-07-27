using Jdair.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jdair.Areas.Operation.Controllers
{
    [Area("Operation")]
    public class AircraftController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AircraftController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.Aircraft.ToListAsync());
        }
    }
}
