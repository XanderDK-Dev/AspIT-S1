using System;
using System.Collections.Generic;
namespace CompetenceTest
{
    public class Product 
    {
        public string name = "";
        public double price = 0;
    }
    internal class CompetenceProgram
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new();

            

            string pickInput = "";
            bool running = true;
            bool BRunning = true;
            bool ARunning = true;
            bool foundAny = false;
            string searchTerm = "";

            while (running)
            {
                Console.Clear();
                Console.WriteLine("a. Indtast varer\nb. Udregn total\nc. Afslut");
                pickInput = Console.ReadLine();
                if (pickInput == "a")
                {
                    while (ARunning)
                    {
                        Console.Clear();
                        Console.WriteLine("Hvad er navnet på din vare?");
                        Product product = new Product();
                        product.name = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Hvad koster din vare?");
                        product.price = double.Parse(Console.ReadLine());

                        Console.Clear();
                        products.Add(product.name, product.price);

                        Console.WriteLine("Produkt opretted!");
                        Console.WriteLine("Hvis du ønsker at gå tilbage tryk e ellers tryk r");
                        pickInput = Console.ReadLine();
                        if (pickInput == "e")
                        {
                            ARunning = false;
                        }
                    }
                }

                if (pickInput == "b")
                {
                    while (BRunning)
                    {
                        BRunning = true;
                        Console.Clear();
                        foreach (KeyValuePair<string, double> p in products)
                        {
                            Console.WriteLine($"{p.Key}: {p.Value}kr\n");
                        }
                        Console.WriteLine($"Summen af alt er {products.Sum(p => p.Value)}kr");
                        Console.WriteLine("Hvis du ønsker at gå tilbage tryk e");
                        pickInput = Console.ReadLine();
                        if (pickInput == "e")
                        {
                            BRunning = false;
                        }
                    }
                }

                if (pickInput == "c")
                {
                    Console.Clear();
                    Console.WriteLine("Farvel");
                }

                if ((pickInput != "a") || (pickInput != "b") || (pickInput != "c"))
                {
                    Console.WriteLine("Du skal indaste enten a, b eller c");
                }
            }
        }
    }
}
