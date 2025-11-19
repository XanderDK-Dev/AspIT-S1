namespace EX06ComparisonOperators
{
    internal class EX06Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            Console.WriteLine(a == b); //false
            Console.WriteLine(a > b); //false
            Console.WriteLine(a <= b); //true
            Console.WriteLine(a - b > 0); //false
            Console.WriteLine(a + b > 0); //true
            Console.WriteLine(a > 1 - b); //false //wrong guess
        }
    }
}
