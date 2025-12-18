using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;

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
                    throw new ArgumentException("Name cant be empty.");
                }
                
                if (value.Length <= 4)
                {
                    throw new ArgumentException("Name has to be longer than 4 characters");
                }
                name = value;
            }
        }

        private string code;
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
<<<<<<< HEAD
                    throw new ArgumentException("Code cant be empty..");
                }
                
                if (value.Length != 7)
                {
                    throw new ArgumentException("");
                }

                string code1 = value.Substring(0, 3);
                if (code1.Any(char.IsDigit))
                {
                    throw new ArgumentException("The first part of the code cannot include numbers.");
                }

                if (code1.Any(char.IsLower))
                {
                    throw new ArgumentException("The first part of the code has to be uppercase.");
                }

                string code2 = value.Substring(3, 1);
                if (code2 != "-")
                {
                    throw new ArgumentException("The middle has to be -");
                }

                string code3 = value.Substring(4, 3);
                if (code3.Any(char.IsLetter))
                {
                    throw new ArgumentException("The last part of the code cannot include letters.");
                }

                string code4 = value.Substring(4, 1);
                if (code4 == "0")
                {
                    throw new ArgumentException("The first number cannot be 0.");
=======
                    throw new ArgumentException("Not allowed as code.");
>>>>>>> fdb5c79a559d5e16d32459eefc0f64235131916d
                }
                code = value;
            }
        }

        private string tName;
        public string TName
        {
            get
            {
                return tName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
<<<<<<< HEAD
                    throw new ArgumentException("Teacher name cant be empty.");
                }

                if (Regex.IsMatch(value, @"^-?\+$"))
                {
                    throw new ArgumentException("Teacher name cannot include special characters.");
                }

                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentException("Teacher name cannot include numbers.");
=======
                    throw new ArgumentException("Not allowed as name.");
>>>>>>> fdb5c79a559d5e16d32459eefc0f64235131916d
                }
                tName = value;
            }
        }

        private int ects;
        public int Ects
        {
            get
            {
                return ects;
            }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new ArgumentException("Not allowed as ECTS point.");
                }
                ects = value;
            }
        }

        private DateTime start;

        public DateTime Start
        {
            get
            {
                return start;
            }
            set
            {
                //if ()
                //{
                //    throw new ArgumentException("Not allowed as Start date.");
                //}
                start = value;
            }
        }

        private DateTime end;

        public DateTime End
        {
            get
            {
                return end;
            }
            set
            {
                if (start > value)
                {
                    throw new ArgumentException("End date cannot come before start date.");
                }
                end = value;
            }
        }

        private DateTime exam;

        public DateTime Exam
        {
            get
            {
                return exam;
            }
            set
            {
                if (start > value || value > end)
                {
                    throw new ArgumentException("Exam date has to be within start and end dates.");
                }
                exam = value;
            }
        }

        public string Duration()
        {
            var StartDate = start;
            var EndDate = end;

            int years;
            int months;
            int days;

            for (var i = 1; ; ++i)
            {
                if (StartDate.AddYears(i) > EndDate)
                {
                    years = i - 1;

                    break;
                }
            }

            for (var i = 1; ; ++i)
            {
                if (StartDate.AddYears(years).AddMonths(i) > EndDate)
                {
                    months = i - 1;

                    break;
                }
            }

            for (var i = 1; ; ++i)
            {
                if (StartDate.AddYears(years).AddMonths(months).AddDays(i) > EndDate)
                {
                    days = i - 1;

                    break;
                }
            }
            return $"The duration of the course is: {years} years {months} months {days} days";
        }

        public string ToExam()
        {
            var StartDate = DateTime.Now;
            var EndDate = Exam;

            int years;
            int months;
            int days;

            for (var i = 1; ; ++i)
            {
                if (StartDate.AddYears(i) > EndDate)
                {
                    years = i - 1;

                    break;
                }
            }

            for (var i = 1; ; ++i)
            {
                if (StartDate.AddYears(years).AddMonths(i) > EndDate)
                {
                    months = i - 1;

                    break;
                }
            }

            for (var i = 1; ; ++i)
            {
                if (StartDate.AddYears(years).AddMonths(months).AddDays(i) > EndDate)
                {
                    days = i - 1;

                    break;
                }
            }

            return $"There is: {years} years {months} months {days} days until the exam";
        }
    }
}
