using Furndaqaaqas.Data;
using Furndaqaaqas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Furndaqaaqas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ExampleDB _context;
        public HomeController(ILogger<HomeController> logger, ExampleDB context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Myslider"] = _context.Sliders.ToList();
            ViewData["Category"] = _context.Categories.ToList();
            ViewData["BestProducts"] = _context.BestProducts.ToList();
            ViewData["New"] = _context.News.ToList();
            ViewData["Products"] = _context.Products.ToList();
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
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
