using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Enrollment
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string  LastName { get; set; }

        public int PhoneNumber { get; set; }

        public int ClassSelection { get; set; }
        
    }
}
