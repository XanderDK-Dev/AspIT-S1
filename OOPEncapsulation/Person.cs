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
                    throw new ArgumentException("Not allowed as code.");
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
                    throw new ArgumentException("Not allowed as name.");
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
