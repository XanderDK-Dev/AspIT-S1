using Microsoft.VisualBasic;
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
            var myAge = today.Year - BirthDate.Year;

            // If the birthdate hasn't arrived yet, subtract one year.
            if (BirthDate.Date > today.AddYears(-myAge)) myAge--;

            return myAge;
        }

        public bool IsOlderThan(int age)
        {

            var myAge = GetAgeToday();

            if (myAge > age) {return true;}
            else return false;
        }

        public int GetAgeAt(DateTime date)
        {
            // Calculate the age.
            var myAge = date.Year - BirthDate.Year;

            // If the birthdate hasn't arrived yet, subtract one year.
            if (BirthDate.Date > date.AddYears(-myAge)) myAge--;

            return myAge;
        }

        public double GetBmi()
        {
            double bmi = 0;
            double BmiHeight = Height;
            BmiHeight = BmiHeight / 100;
            BmiHeight = BmiHeight * BmiHeight;
            bmi = Weight / BmiHeight;
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

        public string PersonDescription()
        {
            string fName = FirstName;
            string lName = LastName;
            DateTime bDay = BirthDate;
            var ageToday = GetAgeToday();
            DateTime adult = bDay.AddYears(18);
            DateTime today = DateTime.Now;
            double bmi = GetBmi();
            string bmiStatus = BmiDescription();

            string story = $"{fName} {lName} was born the {bDay.ToShortDateString()} and is today {today.ToShortDateString()} {ageToday} years old. {fName} was 18 years old in {adult.Year} and has a BMI at {bmi} which is considered {bmiStatus}";

            return story;
        }
    }
}
