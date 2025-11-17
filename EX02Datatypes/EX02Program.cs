namespace EX02Datatypes
{
    internal class EX02Program
    {
        static void Main(string[] args)
        {
            string firstName = "Karsten";
            string lastName = "Hansen";
            int age = 35;
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine($"{firstName} {lastName} {age}");
            string bookTitle = "Lord of The Rings – The Two Towers)";
            long isbn = 9780007117116;
            int sides = 400;
            double price = 249.49;
            Console.WriteLine($"{bookTitle} {isbn} {sides} {price}");
            int intMaxNum = 2147483647;
            int intMinNum = -2147483648;
            uint uintMaxNum = 4294967295;
            uint uintMinNum = 0;
            long longMaxNum = 922337203854775807;
            long longMinNum = -9223372036854775808;
            byte bytMaxNum = 255;
            byte bytMinNum = 0;
            Console.WriteLine($"{intMaxNum} {intMinNum} {uintMaxNum}  {uintMinNum} {longMaxNum} {longMinNum} {bytMaxNum} {bytMinNum}");
        }
    }
}
