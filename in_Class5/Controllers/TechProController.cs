using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using in_Class5.Models.Portfolio;
using Microsoft.AspNetCore.Mvc;

namespace in_Class5.Controllers
{

    [Route("t")]
    public class TechProController : Controller
    {

        private readonly ProtfolioContext _context;
      
        public TechProController(ProtfolioContext _context)
        {
            this._context = _context;
        }

        public IActionResult Index()
        {
            var result = _context.TechnologyProjects;
            return View(result);
        }
    }
}