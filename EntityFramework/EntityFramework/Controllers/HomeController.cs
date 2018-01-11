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
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        private EnrollmentDbContext _context;

        public HomeController(EnrollmentDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public IActionResult Index(Enrollment enrollment)
        {
            //add ind. enrolled names to the database
            _context.Enrollment.Add(enrollment);
            //Saving the entry
            _context.SaveChanges();

            //Redirect to details action
            return RedirectToAction("Details");
        }

        public IActionResult Details()
        {
            //////    //Get All Reservations from the Database
            IEnumerable<Enrollment> myEnrollments = _context.Enrollment;
            return View(myEnrollments);
        }

        [HttpGet]
        //Bring in Id of reservation
        // send reservation back to view from DB
        public IActionResult Update(int id)
        {
            return View(_context.Enrollment.FirstOrDefault(r => r.ID == id));
        }

        [HttpPost]
        public IActionResult Update(Enrollment r)
        {
            _context.Update(r);
            _context.SaveChanges();
            return RedirectToAction("Details");
        }

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    return View(_context.Enrollment.First(x => x.ID == id));
        //}

        //[HttpPost]
        //public IActionResult Delete(Enrollment r)
        //{
        //    _context.Remove(r);
        //    _context.SaveChanges();
        //    return RedirectToAction("Details");
        //}

    }
}
