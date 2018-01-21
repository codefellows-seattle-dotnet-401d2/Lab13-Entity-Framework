using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeadHighSchool.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string HomeClass { get; set; }

        public static implicit operator Student(Task<List<Student>> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Student(Task<Student> v)
        {
            throw new NotImplementedException();
        }
    }
}
