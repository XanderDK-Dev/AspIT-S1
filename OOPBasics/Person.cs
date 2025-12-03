using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBasics
{
    internal class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetInitials()
        {
            return $"{FirstName.Substring(0, 2).ToUpper()}{LastName.Substring(0, 2).ToUpper()}";
        }
    }
}
