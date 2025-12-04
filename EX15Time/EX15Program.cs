namespace EX15Time
{
    internal class EX15Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1969, 12, 7);
            //Console.WriteLine(myBirthday.ToShortDateString());

            //DateTime myBirthday = DateTime.Parse("12/7/1969");
            //TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            //Console.WriteLine(myAge.TotalDays);

            Console.WriteLine("a) Time right now\nb) Time until christmas\nc) Time until my brithday\nd) Time until a specified date");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.Clear();
            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                    {
                        
                        TimeSpan d = DateTime.Now.TimeOfDay;
                        string date = string.Format("{0}:{1}:{2}", d.Hours, d.Minutes, d.Seconds);

                        Console.WriteLine(date);                                                             
                    }
                    break;

                case ConsoleKey.B:
                    {
                        //Console.WriteLine(myValue.ToString());
                        //DateTime nextChristmas = DateTime.Parse("24/12/2025");
                        //TimeSpan toChristmas = DateTime.Now.Subtract(nextChristmas);
                        //Console.WriteLine(toChristmas);

                        //Get these values however you like.
                        int currentYear = DateTime.Now.Year;
                        DateTime startDate = DateTime.Now;

                        if (/*DateTime.Now.Date*/ startDate > new DateTime(currentYear, 12, 24))
                        {
                            currentYear++;
                        }

                        DateTime daysLeft = DateTime.Parse($"24/12/{currentYear} 6:00:00 PM");
                        //Calculate countdown timer.
                        TimeSpan t = daysLeft - startDate;
                        string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds until christmas.", t.Days, t.Hours, t.Minutes, t.Seconds);

                        Console.WriteLine(countDown);

                    }
                    break;

                case ConsoleKey.C:
                    {
                        int currentYear = DateTime.Now.Year;
                        DateTime startDate = DateTime.Now;

                        if (/*DateTime.Now.Date*/ startDate > new DateTime(currentYear, 04, 19))
                        {
                            currentYear++;
                        }

                        DateTime daysLeft = DateTime.Parse($"19/04/{currentYear} 12:00:0 PM");
                        //Calculate countdown timer.
                        TimeSpan t = daysLeft - startDate;
                        string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds until my birthday.", t.Days, t.Hours, t.Minutes, t.Seconds);

                        Console.WriteLine(countDown);
                    }
                    break;

                case ConsoleKey.D:
                    {
                        Console.WriteLine("Input a date like the following 24/05/1992");
                        string inputDate = Console.ReadLine();
                        DateTime date = DateTime.Parse(inputDate);

                        TimeSpan t = date - DateTime.Now;
                        string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds until your date.", t.Days, t.Hours, t.Minutes, t.Seconds);
                        Console.WriteLine(countDown);
                    }
                    break;
            }
        }
    }
}
