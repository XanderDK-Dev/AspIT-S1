using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPBasics
{
    internal class Car
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public int NewPrice { get; set; }
        public int KilometresDriven { get; set; }
        public string Colour { get; set; }
        public int TopSpeed { get; set; }
        public int EnginePeformanceKilowatt { get; set; }
        public string CarType { get; set; }

        public string SalesPrice()
        {
            double currentPrice = NewPrice;
            int i = 0;

            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - ManufacturingDate.Year;

            // If the birthdate hasn't arrived yet, subtract one year.
            if (ManufacturingDate.Date > today.AddYears(-age)) age--;

            double avgKm = KilometresDriven / age;
            Console.WriteLine(avgKm);

            while (i < age)
            {
                if (i < 5)
                {
                    currentPrice -= currentPrice * 0.15;
                    i++;
                    if (avgKm > 25000)
                    {
                        currentPrice -= currentPrice * 0.075;
                    }
                }
                else if (i > 35)
                {
                    currentPrice += currentPrice * 0.05;
                    i++;
                    if (avgKm > 25000)
                    {
                        currentPrice -= currentPrice * 0.075;
                    }
                }
                else
                {
                    currentPrice -= currentPrice * 0.10;
                    i++;
                    if (avgKm > 25000)
                    {
                        currentPrice -= currentPrice * 0.075;
                    }
                }
            }
            string formattedPrice = NewPrice.ToString("N0");
            string formattedKm = KilometresDriven.ToString("N0");
            string formattedDate = ManufacturingDate.ToShortDateString();

            string story = $"The car is a {Make} {Model} it was manufactured {formattedDate} the new price was {formattedPrice}Dkk it has driven {formattedKm}km it is {Colour} and has a top speed of {TopSpeed}km/h has {EnginePeformanceKilowatt}kw and its a {CarType}";

            return story;
        }
    }
}
