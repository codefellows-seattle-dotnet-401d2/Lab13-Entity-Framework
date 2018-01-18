using System;
using Xunit;
using EntityFramework.Controllers;
using System.Threading.Tasks;
using EntityFramework.Models;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
       [Fact]
        public void TestFirstName()
        {
            Hogwarts s = new Hogwarts();
            s.FirstName = "Josh";
            s.FirstName = "Jeff";

            Assert.Equal("Jeff", s.FirstName);
        }

        [Fact]
        public void TestLastName()
        {
            Hogwarts s = new Hogwarts();
            s.LastName = "Potter";
            s.LastName = "Weasley";

            Assert.Equal("Weasley", s.LastName);
        }

        [Fact]
        public void TestPhone()
        {
            Hogwarts s = new Hogwarts();
            s.Phone = 253;
            s.Phone = 352;

            Assert.Equal(352, s.Phone);
        }

        [Fact]
        public void TestHouse()
        {
            Hogwarts s = new Hogwarts();
            s.House = "Hufflepuff";
            s.House = "Gryffindor";

            Assert.Equal("Gryffindor", s.House);
        }
    }
}
