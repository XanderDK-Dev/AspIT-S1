namespace WhileOpgave1
{
    internal class WhileOpgave1Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a) Opgave1\nb) Udskriv tabeller\nc) Få det rette input");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.Clear();
            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                    int x = -1;
                    while (x < 9)
                    {
                        x++;
                        Console.WriteLine($"While statement {x}");
                    }
                    Console.WriteLine("Denne løkke har kørt 10 gange.");
                    break;
                case ConsoleKey.B:
                    Console.WriteLine("1st number");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("2nd Number");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("3rd Number");
                    int num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("4th Number");
                    int num4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("5th Number");
                    int num5 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    int finalArea = num1 + num2 + num3 + num4 + num5;
                    Console.WriteLine(finalArea);
                    break;
            }
        }
    }
}
