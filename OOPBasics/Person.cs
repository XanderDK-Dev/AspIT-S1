using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPBasics
{
    internal class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetInitials()
        {
            return $"{FirstName.Substring(0, 2).ToUpper()}{LastName.Substring(0, 2).ToUpper()}";
        }

        public int GetAgeToday()
        {
            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - BirthDate.Year;

            // If the birthdate hasn't arrived yet, subtract one year.
            if (BirthDate.Date > today.AddYears(-age)) age--;

            return age;
        }

        public bool IsOlderThan(int age)
        {
           
            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var myAge = today.Year - BirthDate.Year;

            // If the birthdate hasn't arrived yet, subtract one year.
            if (BirthDate.Date > today.AddYears(-myAge)) myAge--;

            if (myAge > age) {return true;}
            else return false;
        }

        public int GetAgeAt(DateTime date)
        {
            // Calculate the age.
            var age = date.Year - BirthDate.Year;

            // If the birthdate hasn't arrived yet, subtract one year.
            if (BirthDate.Date > date.AddYears(-age)) age--;

            return age;
        }

        public double GetBmi()
        {
            double bmi = 0;
            Height = Height / 100;
            Height = Height * Height;
            bmi = Weight / Height;
            return bmi;

        }

        public string BmiDescription()
        {
            string bmiStatus = "";
            double bmi = GetBmi();

            if (bmi < 18.5) { bmiStatus = "Underweight"; }
            else if (bmi > 18.5 && bmi < 24.9) { bmiStatus = "Normal weight"; }
            else if (bmi > 24.9 && bmi < 29.9) { bmiStatus = "Overweight"; }
            else if (bmi > 29.9 && bmi < 34.9) { bmiStatus = "Obese Class 1"; }
            else if (bmi > 34.9 && bmi < 39.9) { bmiStatus = "Obese Class 2"; }
            else if (bmi > 39.9) { bmiStatus = "Obese Class 3"; }
            return bmiStatus;
        }
    }
}
