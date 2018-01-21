using System;
using Xunit;
using MeadHighSchool;
using MeadHighSchool.Models;
using MeadHighSchool.Data;
using MeadHighSchool.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    // Amanda helped me work this out
    public class UnitTest1
    {
        [Fact]
        public void StudentExistsinDatabase()
        {
            DbContextOptions<StudentsDbContext> options = new DbContextOptionsBuilder<StudentsDbContext>()
            //Fake DB
            .UseInMemoryDatabase(databaseName: "StudentExists")
            .Options;
            using (StudentsDbContext context = new StudentsDbContext(options))
            {
                // Fake student
                Student student = new Student()
                {
                    FirstName = "Test",
                    LastName = "McStudent",
                    Phone = "5",
                    HomeClass = "Lunch"
                };

                // Add student to fake DB
                context.Students.Add(student);
                context.SaveChanges();

                // This is super stupid but it grabs the first student out of the fake database.
                Student st = context.Students.FirstOrDefaultAsync(x => x.FirstName == "Test").Result;

                Assert.Equal(student, st);
            };

        }

        [Fact]
        public void StudentNameCanBeChanged()
        {
            Student s = new Student();
            s.FirstName = "Harry";
            s.LastName = "Potter";
            s.FirstName = "Dustin";
            Assert.Equal("Dustin", s.FirstName);
        }
    }
}
