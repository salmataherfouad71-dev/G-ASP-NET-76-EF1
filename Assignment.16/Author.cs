using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._16
{
    public class Author
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string EmailAddress { set; get; }
        public string ShortBiography { set; get; } 
        public DateOnly DateOfBirth { set; get; }

    }
}
