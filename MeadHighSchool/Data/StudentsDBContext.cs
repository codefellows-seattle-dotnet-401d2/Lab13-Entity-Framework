using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeadHighSchool.Data
{
    public class StudentsDbContext
    {
        public DbSet<Models.Student> Students { get; set; }

        public StudentsDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<StudentsDbContext> options) : base(options)
        {

        }
    }
}
