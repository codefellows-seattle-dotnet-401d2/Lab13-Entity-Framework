using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MutantFactions.Models;

namespace MutantFactions.Data
{
    public class MutantDbContext : DbContext
    {
        public MutantDbContext(DbContextOptions<MutantDbContext> options) : base(options)
        {

        }

        public DbSet<Student> MutantDB { get; set; }
    }
}
