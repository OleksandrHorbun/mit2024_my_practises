using Microsoft.AspNetCore.Mvc;
using Practice_1.Models;
using System.Diagnostics;
using Practice_1.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Practice_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {

            IEnumerable<Grade> grades = _dbContext.Grades;

            ViewBag.Grades = grades;

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
