using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Data;
using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly HogwartsDbContext _context;

        public HomeController(HogwartsDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Hogwarts hogs)
        {
            //add student info reservation to the database
            _context.Hogwarts.Add(hogs);
            //Saving the entry
            _context.SaveChanges();

            //Redirect to details action
            return RedirectToAction("Enrollment");
        }

        public IActionResult Enrollment()
        {
            IEnumerable <Hogwarts> allStudents = _context.Hogwarts;
            return View(allStudents);
        }
    }
}
