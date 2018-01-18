using System;
using Xunit;
using MutantFactions.Data;
using MutantFactions.Controllers;
using MutantFactions.Models;
using Microsoft.EntityFrameworkCore;

namespace XUnitTestWebApp
{
    public class UnitTest1
    {
        MutantDbContext _context;

        DbContextOptions<MutantDbContext> options = new DbContextOptionsBuilder<MutantDbContext>()
                                                        .UseInMemoryDatabase(Guid.NewGuid().ToString())
                                                        .Options;
        Student mutant = new Student
        {
            RealName = "Scott Summers",
            CodeName = "Cyclops",
            MutantPower = "Concussive Optic Blasts",
            MutantFaction = "X-Men"
        };

        [Fact]
        public void TestModelProperties()
        {
            Assert.Equal("Scott Summers", mutant.RealName);
            Assert.Equal("Cyclops", mutant.CodeName);
            Assert.Equal("Concussive Optic Blasts", mutant.MutantPower);
            Assert.Equal("X-Men", mutant.MutantFaction);
        }

        [Fact]
        public void TestHomeIndexReturnsView()
        {
            using (_context = new MutantDbContext(options))
            {
                _context.MutantDB.Add(mutant);
                _context.SaveChanges();
                // Arrange
                HomeController controller = new HomeController(_context);
                // Act
                var result = controller.Index();
                // Assert
                Assert.NotNull(result);
            }
        }

        [Fact]
        public void TestHomeDetailsReturnsView()
        {
            using (_context = new MutantDbContext(options))
            {
                _context.MutantDB.Add(mutant);
                _context.SaveChanges();
                // Arrange
                HomeController controller = new HomeController(_context);
                // Act
                var result = controller.Details();
                // Assert
                Assert.NotNull(result);
            }
        }
    }

}
