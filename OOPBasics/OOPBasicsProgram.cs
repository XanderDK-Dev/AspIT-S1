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
            p.GetInitials();

            string output = p.GetInitials();
            Console.WriteLine(output);

            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - p.BirthDate.Year;

            // If the birthdate hasn't arrived yet, subtract one year.
            if (p.BirthDate.Date > today.AddYears(-age)) age--;

            Console.WriteLine(age);

        }
    }
}
