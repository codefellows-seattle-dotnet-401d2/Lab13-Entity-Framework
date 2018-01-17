using System;
using Xunit;
using MeadHighSchool;
using MeadHighSchool.Models;
using MeadHighSchool.Data;
using MeadHighSchool.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void HttpStatusTest()
        {
            DbContextOptions<StudentsDbContext> options = new DbContextOptionsBuilder<StudentsDbContext>()
            .UseInMemoryDatabase(databaseName: "getStatusCode")
            .Options;
            using (StudentsDbContext context = new StudentsDbContext(options))
            {
                Student student = new Student()
                {
                    FirstName = "Test",
                    LastName = "McStudent",
                    Phone = "5",
                    HomeClass = "Lunch",
            };
                context.Students.Add(student);
                context.SaveChanges();
                HomeController controller = new HomeController(context);
                var result = controller.Index();
                ObjectResult objectResult = (ObjectResult)result;
                Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)objectResult.StatusCode.Value);
            }
        }
    }
}
