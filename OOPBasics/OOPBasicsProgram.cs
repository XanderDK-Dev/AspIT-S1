namespace OOPBasics
{

    internal class OOPBasicsProgram
    {
        static void Main(string[] args)
        {
            Person p = new();
            p.FirstName = "Karl";
            p.LastName = "Hansen";
            p.BirthDate = new DateTime(1946, 01, 02);
            p.Height = 182;
            p.Weight = 74;
            p.GetInitials();
            p.GetAgeToday();
            string output = p.GetInitials();
            Console.WriteLine(output);

            int output2 = p.GetAgeToday();
            Console.WriteLine(output2);

            bool output3 = p.IsOlderThan(42);
            Console.WriteLine(output3);

            int output4 = p.GetAgeAt(new DateTime(2026, 02, 03));
            Console.WriteLine(output4);

            double output5 = p.GetBmi();
            Console.WriteLine(output5);

            string output6 = p.PersonDescription();
            Console.WriteLine(output6);


            Car c = new();
            c.Make = "Volkswagen";
            c.Model = "Golf";
            c.ManufacturingDate = new DateTime(2011, 08, 28);
            c.NewPrice = 295998;
            c.KilometresDriven = 287000;
            c.Colour = "Grey";
            c.TopSpeed = 190;
            c.EnginePeformanceKilowatt = 77;
            c.CarType = "Diesel";

            string output7 = c.SalesPrice();
            Console.WriteLine(output7);

            Product i = new();
            i.Id = 592017;
            i.Name = "Sonos Era 100";
            i.Created = new DateTime(2023, 03, 28);
            i.Price = 187;
            string output8 = i.ToString();
            Console.WriteLine(output8);
        }
    }
}
