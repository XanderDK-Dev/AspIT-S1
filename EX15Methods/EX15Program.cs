namespace EX15Methods
{
    internal class EX15Program
    {

        public static string GetName()
        {
            Console.WriteLine("Indtast Navn");
            string name = Console.ReadLine();
            return name;
        }
        public static void SayHello(string name)
        {
            Console.WriteLine($"Hej {name}");
        }

        public static void SayGoodbye(string name)
        {
            Console.WriteLine($"Farvel {name}");
        }

        public static int DoubleUp(int num)
        {
            return num * 2;
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int HighestNum(int hNum1, int hNum2)
        {
            if (hNum1 < hNum2)
            {
                return hNum2;
            }
            else
            {
                return hNum1;
            }
        }

        public static void PrintArray(string[] array)
        {
            foreach (string str in array)
            {
                Console.WriteLine(str);
            }
        }

        static void Main(string[] args)
        {
            string name = GetName();
            SayHello(name);
            SayGoodbye(name);


            Console.WriteLine("Indtast tal");
            int.TryParse(Console.ReadLine(), out int num);
            int finalNum = DoubleUp(num);
            Console.WriteLine(finalNum);


            Console.WriteLine("Indtast tal");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Indtast tal");
            int.TryParse(Console.ReadLine(), out int num2);
            int finalSum = Sum(num1, num2);
            Console.WriteLine(finalSum);

            Console.WriteLine("Indtast tal");
            int.TryParse(Console.ReadLine(), out int hNum1);
            Console.WriteLine("Indtast tal");
            int.TryParse(Console.ReadLine(), out int hNum2);
            int hFinalNum = HighestNum(hNum1, hNum2);
            Console.WriteLine(hFinalNum);

            string[] array = { "Test 1", "Test 2", "Test 3" };
            PrintArray(array);
        }
    }
}
