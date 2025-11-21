namespace EX11While
{
    internal class EX11Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a) Udskriv talrækker\nb) Udskriv tabeller\nc) Få det rette input");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.Clear();
            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                    int x = 0;
                    while (x < 10)
                    {
                        x++;
                        Console.WriteLine(x);
                    }
                    Console.WriteLine("----");
                    int y = 11;
                    while (y > 1)
                    {
                        y--;
                        Console.WriteLine(y);
                    }
                    Console.WriteLine("----");
                    int z = 0;
                    while (z < 20)
                    {
                        z++;
                        if (z % 2 == 0)
                        {
                            Console.WriteLine(z);
                        }

                    }
                    Console.WriteLine("----");
                    int a = 0;
                    while (a < 20)
                    {
                        a++;
                        if (a % 2 != 0)
                        {
                            Console.WriteLine(a);
                        }

                    }
                    Console.WriteLine("----");
                    break;

                case ConsoleKey.B:
                    int num1 = 0;
                    int num2 = 0;
                    int time = 0;
                    Console.WriteLine("Indtast en tabel (fx 7, 13 eller lignende");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    while (time < 10)
                    {
                        time = time + 1;
                        num2 = num1 + num2;
                        Console.WriteLine(num2);

                    }
                    break;
                
                case ConsoleKey.C:
                    int tryAgain = 1;
                    int number = 0;
                    while (tryAgain == 1)
                    {
                        Console.WriteLine("Indtast et tal mellem 1 og 10.");
                        number = int.Parse(Console.ReadLine());
                        if (number >= 1 && number <= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Well done!");
                            tryAgain = 0;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Number was not between 1 and 10");
                        }

                    }
                    break;
            }

        }
    }
}
