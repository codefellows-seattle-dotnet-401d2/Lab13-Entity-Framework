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
        public ViewResult Index() => View(repository.Products);
        private StudentsDBContext _context;

        public HomeController(StudentsDBContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //POST:
        //[HttpPost]
        //public IActionResult Index(Student student)
        //{

        //}
    }
}
