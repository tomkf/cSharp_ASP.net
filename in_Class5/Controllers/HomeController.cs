using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using in_Class5.Models;
using in_Class5.Models.Portfolio;
using Portfolio.Models;

namespace in_Class5.Controllers
{
    public class HomeController : Controller
    {
        private ProtfolioContext db;

        // Initialize context when controller is created.
        // when home controller created, pass it the context
        public HomeController(ProtfolioContext db)
        {
            this.db = db;
            Seeder seeder = new Seeder(db);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
