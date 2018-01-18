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
    public class EnrollementController : Controller
    {
        private MutantDbContext _context;

        public EnrollementController(MutantDbContext context)
        {
            _context = context;
        }
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
