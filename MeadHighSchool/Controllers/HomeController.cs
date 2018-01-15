using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeadHighSchool.Data;
using MeadHighSchool.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeadHighSchool.Controllers
{
    public class HomeController : Controller
    {
        private StudentsDbContext _context;

        public HomeController(StudentsDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var connection = _context.Students;
            Student student = new Student
            {
                FirstName = "Dustin",
                LastName = "Mundy",
                HomeClass = "Jewelry",
                Phone = "(509)-844-5000"
            };

            _context.Students.Add(student);
            _context.SaveChanges();

            var x = _context.Students.Where(s => s.LastName == "Mundy");

            return View();
        }

        //POST:
        //[HttpPost]
        //public IActionResult Index(Student student)
        //{

        //}
    }
}
