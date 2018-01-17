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
    public class EnrollmentController : Controller
    {
        private StudentsDbContext _context;

        public EnrollmentController(StudentsDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Enroll()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enroll(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}
