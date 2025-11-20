using System;

namespace Opgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime thisDate1 = new DateTime(2011, 6, 10);
            Console.WriteLine("Today is " + thisDate1.ToString("MMMM dd, yyyy") + ".");

            DateTime today = DateTime.Today;
            DateTime.Now.ToString("M/d/yyyy");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(today);
            string dayOfWeek = today.DayOfWeek.ToString("d");
            Console.WriteLine(dayOfWeek);

        }
    }
}
