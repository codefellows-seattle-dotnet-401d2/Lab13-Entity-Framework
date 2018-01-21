using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeadHighSchool.Data;
using MeadHighSchool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            List<Student> allstudents = _context.Students.OrderBy(student => student.LastName).ToList();
            return View(allstudents);
        }

        //POST:
        //[HttpPost]
        //public IActionResult Index(Student student)
        //{

        //}
    }
}
