using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MutantFactions.Models;
using MutantFactions.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MutantFactions.Controllers
{
    public class HomeController : Controller
    {
        private MutantDbContext _context;

        public HomeController(MutantDbContext context)
        {
            _context = context;
        }
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student mutant)
        {
            _context.MutantDB.Add(mutant);
            _context.SaveChanges();
            return RedirectToAction("Details");
        }

        public IActionResult Details()
        {
            IEnumerable<Student> allMutants = _context.MutantDB;
            return View(allMutants);
        }
    }
}
