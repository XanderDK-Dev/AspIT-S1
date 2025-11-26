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

                case ConsoleKey.C:
                    string input1 = "";
                    Console.WriteLine("Skriv noget tekst:");
                    input1 = Console.ReadLine();
                    char[] chars = input1.ToCharArray();
                    foreach (char c in chars)
                        Console.WriteLine(c);
                    break;
               
                case ConsoleKey.D:
                    string input2 = "";
                    while (input2.ToLower() != "exit")
                    {
                        Console.WriteLine("Skriv 'exit' for at afslutte:");
                        input2 = Console.ReadLine();
                        Console.WriteLine($"Du skrev: {input2.ToLower()}");
                    }
                    break;
                
                case ConsoleKey.E:
                    while (true)
                    {
                        Console.WriteLine("Skriv exit for at stoppe");
                        string input = Console.ReadLine();
                        if (input == "exit")
                        {
                            break;
                        }
                    }
                    break;

                case ConsoleKey.F:
                    int num = 15;
                    while (num < 0 || num > 11)
                    {
                        Console.Clear();
                        Console.WriteLine("Indtast et tal der er større end 0 og mindre end 11");
                        num = int.Parse(Console.ReadLine());
                    }
                    break;

                case ConsoleKey.G:
                    int gNum = 1;
                    while (gNum == 1 || gNum == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("1) for at høre noget om køer\n2) for at få resultatet af 2*4\n3) for at afslutte programmet");
                       gNum = int.Parse(Console.ReadLine());
                    }
                    break;
                case ConsoleKey.H:
                    int hNum = -1;
                    do
                    {
                        hNum++;
                        Console.WriteLine($"While statement {hNum}");
                    } while (hNum < 9);
                    break;
                case ConsoleKey.I:
                    int iNum = 11;
                    do
                    {
                        iNum--;
                        Console.WriteLine($"While statement {iNum}");
                    } while (iNum > 1);
                    break;
                case ConsoleKey.J:
                    bool jFinal = false;
                    while (jFinal == false)
                    {
                        
                        Random rnd = new Random();
                        int jNum1 = rnd.Next(1, 10);
                        int jNum2 = rnd.Next(1, 10);
                        int jResult = jNum1 + jNum2;
                        int jAnswer = -1;
                        string jInput = string.Empty;
                        Console.WriteLine($"{jNum1} + {jNum2} = ?");
                        Console.WriteLine("Skriv dit svar:");
                        keyInfo = Console.ReadKey();

                        if (keyInfo.Key == ConsoleKey.Escape || keyInfo.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("Du har ikke indtasted noget.");
                        }

                        else if (keyInfo.Key == ConsoleKey.Q)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            jInput += keyInfo.KeyChar;
                        }

                        if (jAnswer > -1)
                        {
                            if (jAnswer == jResult)
                            {
                                jFinal = true;
                            }

                            else 
                            {
                                jFinal = false;
                            }

                            if (jFinal == true)
                            {
                                Console.WriteLine("Tillykke, du har svaret rigtigt!");
                            }

                            else if (jFinal == false)
                            {
                                Console.WriteLine("Desværre, det er ikke det rigtige svar. Prøv igen.");
                            }

                        }
                    }
                    break;
            }
        }
    }
}
