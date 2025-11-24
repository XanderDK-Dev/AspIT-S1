using System;

namespace Smart_Menu
{
    internal class MenuProgram
    {
        static void Main(string[] args)
        {
            string[] options = { "Artemis", "Project hail mary", "The martian", "bye bye" };
            int selection = 0;
            bool isRun = true;

            while (isRun)
            {
                Console.Clear();
                if (selection == 0)
                {
                    Console.WriteLine($"*{options[0]}*");
                }
                else
                {
                    Console.WriteLine(options[0]);
                }
                if (selection == 1)
                {
                    Console.WriteLine($"*{options[1]}*");
                }
                else
                {
                    Console.WriteLine(options[1]);
                }
                if (selection == 2)
                {
                    Console.WriteLine($"*{options[2]}*");
                }
                else
                {
                    Console.WriteLine(options[2]);
                }
                if (selection == 3)
                {
                    Console.WriteLine($"*{options[3]}*");
                }
                else
                {
                    Console.WriteLine(options[3]);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key) 
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        selection--;
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        selection++;
                        break;
                }
                if (selection > 3)
                {
                    selection = 0;
                }

                if (selection < 0)
                {
                    selection = 3;
                }
                if (selection == 3 && keyInfo.Key == ConsoleKey.Enter)
                {
                    Environment.Exit(0);
                }
                if (selection == 0 && keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Artemis is a 2017 science fiction novel by American writer Andy Weir.\n It takes place in the late 2080s in Artemis, the first and so far only city on the Moon\n. It follows the life of porter and smuggler Jasmine \"Jazz\" Bashara as she gets caught up\n in a conspiracy for control of the city.");
                }
            }
        }
    }
}
