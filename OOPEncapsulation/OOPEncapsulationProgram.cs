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
<<<<<<< HEAD


            Person p1 = new();
            try
            {
                p1.Name = "Tesst";
                p1.Code = "ABC-256";
                p1.TName = "Bob A";
                p1.Ects = 8;
                p1.Start = new DateTime(2015, 08, 11);
                p1.End = new DateTime(2092, 06, 25);
                p1.Exam = new DateTime(2086, 02, 05);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }


            string output3 = p1.Duration();
            Console.WriteLine(output3);
            string output4 = p1.ToExam();
            Console.WriteLine(output4);


            Person p2 = new();
            try
            {
                p2.Name = "i do not know";
                p2.Code = "HuN-542";
                p2.TName = "My name";
                p2.Ects = 10;
                p2.Start = new DateTime(20255, 08, 11);
                p2.End = new DateTime(20320, 06, 25);
                p2.Exam = new DateTime(20248, 02, 05);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }


            string output5 = p.Duration();
            Console.WriteLine(output5);
            string output6 = p.ToExam();
            Console.WriteLine(output6);

            Person p3 = new();
            try
            {
                p3.Name = "ADwadAF";
                p3.Code = "AJK-832";
                p3.TName = "Awd awDwd";
                p3.Ects = 1;
                p3.Start = new DateTime(2025, 08, 11);
                p3.End = new DateTime(2030, 06, 25);
                p3.Exam = new DateTime(2028, 02, 05);
                p3.Name = " 1 A23 DFG";
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }


            string output7 = p.Duration();
            Console.WriteLine(output7);
            string output8 = p.ToExam();
            Console.WriteLine(output8);

            Person p4 = new();
            try
            {
                p4.Name = " ";
                p4.Code = "CJG-678";
                p4.TName = "Karl Hansen";
                p4.Ects = 2;
                p4.Start = new DateTime(2025, 08, 11);
                p4.End = new DateTime(2030, 06, 25);
                p4.Exam = new DateTime(2028, 02, 05);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }


            string output9 = p.Duration();
            Console.WriteLine(output9);
            string output10 = p.ToExam();
            Console.WriteLine(output10);

            Person p5 = new();
            try
            {
                p5.Name = "Naaaaaame";
                p5.Code = "CJG-678";
                p5.TName = "1 karl 2 a";
                p5.Ects = 7;
                p5.Start = new DateTime(2025, 08, 11);
                p5.End = new DateTime(2030, 06, 25);
                p5.Exam = new DateTime(2028, 02, 05);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }


            string output11 = p.Duration();
            Console.WriteLine(output11);
            string output12 = p.ToExam();
            Console.WriteLine(output12);


=======
>>>>>>> fdb5c79a559d5e16d32459eefc0f64235131916d
        }
    }
}
