using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class HogwartsDbContext : DbContext
    {
        public HogwartsDbContext(DbContextOptions<HogwartsDbContext> options) : base(options)
        {

        }

        // creates table when make code migration
        public DbSet<Models.Hogwarts> Hogwarts { get; set; }
    }
}
