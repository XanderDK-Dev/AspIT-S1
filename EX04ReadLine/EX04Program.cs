namespace EX04ReadLine
{
    internal class EX04Program
    {
        static void Main(string[] args)
        {
            static void pickMode()
            {
                string pickInput = "";
                Console.WriteLine("Vælg Mode: Login for login. Firkant for areal calculator. Art for art.");
                pickInput = Console.ReadLine();
                if (pickInput == "Login")
                {
                    Console.Clear();
                    Console.WriteLine("Whats your first name:");
                    string firstName = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Whats your last name:");
                    string lastName = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("How old are you:");
                    int age = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"Velkommen {firstName} {lastName} alder {age}");
                }
                else if (pickInput == "Firkant")
                {
                    Console.Clear();
                    Console.WriteLine("Side one of your square");
                    int sideOne = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Side two of your square");
                    int sideTwo = int.Parse(Console.ReadLine());
                    Console.Clear();
                    int finalArea = sideOne * sideTwo;
                    Console.WriteLine($"Arealet af din firkant er: {finalArea}");
                }
                else if (pickInput == "Art")
                {
                    Console.Clear();
                    Console.WriteLine("     AA          BBBB         CCC");
                    Console.WriteLine("    A  A         B    B     C      C");
                    Console.WriteLine("   A    A        B    B    C");
                    Console.WriteLine("  AAAAAAAA       BBBB      C");
                    Console.WriteLine(" A        A      B    B     C      C");
                    Console.WriteLine("A          A     BBBB         CCC");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Input");
                }
            }
            pickMode();

        }
    }
}
