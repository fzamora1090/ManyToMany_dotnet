using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAndCategories.Models;

namespace ProductsAndCategories.Controllers
{
    public class HomeController : Controller
    {
        private PandCDBContext _db;
        public HomeController(PandCDBContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            MainModel dashboard = new MainModel();
            dashboard.allProducts = _db.Products
                .Include(p => p.Categories)
                // .ThenInclude(p => p.Associations)  
                .ToList();

            return View(dashboard);
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
