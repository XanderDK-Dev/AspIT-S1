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
        }
    }
}
