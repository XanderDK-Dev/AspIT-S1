using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPEncapsulation
{
    internal class Person
    {
        private string name;
        public string Name 
        {
            get 
            { 
                return name;
            }
            set 
            { 
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Not allowed as name.");
                }
                name = value;
            }
        }








        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
