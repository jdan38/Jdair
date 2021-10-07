using Microsoft.AspNetCore.Mvc;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jdair2.Data;
using Microsoft.EntityFrameworkCore;

namespace Jdair2.Areas.Operation.Controllers
{
    [Area("Operation")]
    public class FlightController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FlightController(ApplicationDbContext db)
        {
            _db = db;
        }

       
        public async Task<IActionResult> Index()
        {
            return View(await _db.Flight.ToListAsync());
        }

        public IActionResult Create()
        {

            return View();
        }
    }
}
