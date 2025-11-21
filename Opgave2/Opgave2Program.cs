using System;
using System.Globalization;

namespace Opgave2
{
    internal class Opgave2Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now.ToString("dd/MM/yyyy");
            var day = DateTime.Today.DayOfWeek;
            Console.WriteLine($"Dags dato: {date}");
            Console.WriteLine($"Dagen i dag er {day}.");

        }
    }
}
