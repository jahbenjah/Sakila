using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sakila.Infrastructure;
using Sakila.Web.Models;

namespace Sakila.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SakilaContext _context;
        public HomeController(SakilaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Actor.ToList());
        }

        public IActionResult Privacy()
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
