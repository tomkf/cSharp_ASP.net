using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace in_Class5.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()

        {
            return View();
        }
    }
}