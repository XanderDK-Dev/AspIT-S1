namespace OOPEncapsulation
{

    internal class OOPEncapsulationProgram
    {
        static void Main(string[] args)
        {
            Person p = new();
            try
            {
                p.Name = "Old Greek Philosophy History";
                p.Code = "CJG-678";
                p.TName = "Karl Hansen";
                p.Ects = 2;
                p.Start = new DateTime(2025, 08, 11);
                p.End = new DateTime(2030, 06, 25);
                p.Exam = new DateTime(2028, 02, 05);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }


            string output = p.Duration();
            Console.WriteLine(output);
            string output2 = p.ToExam();
            Console.WriteLine(output2);
        }
    }
}
