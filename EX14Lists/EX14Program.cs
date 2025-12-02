using System;

namespace EX14Lists
{
    internal class EX14Program
    {
        static void Main(string[] args)
        {
            //List<int> ages = new List<int>();
            //ages.AddRange(5, 17, 20, 40, 51);
            //foreach (int age in ages)
            //{
            //    Console.Write(age);
            //}


            //List<string> names = new List<string>();
            //names.AddRange("Jens", "Karl", "Johannes", "Anton", "Nicklas");
            //foreach (string name in names)
            //{
            //    Console.Write(name);
            //}

            //List<double> percentages = new List<double> { 0.75, 0.23, 0.86, 0.17 };
            //foreach (double percentage in percentages)
            //{
            //    Console.Write(percentage);
            //}

            //List<bool> areMarried = new List<bool> {true, false, false, true, true};
            //foreach (bool married in areMarried)
            //{
            //    Console.Write(married);
            //}

            //List<string> names = new List<string>();
            //names.AddRange("Hans", "Kristian", "Jens", "Karsten", "Ib");
            //names.Insert(3, "Anders");
            //names.Insert(2, "lars");
            //foreach (string name in names)
            //{
            //    Console.Write(name);
            //}

            List<int> ages = new List<int> {13, 14, 13, 15, 13, 14, 14, 15};
            ages.Remove(13);
            ages.Remove(15);
            ages.RemoveAt(3);
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }
        }
    }
}
