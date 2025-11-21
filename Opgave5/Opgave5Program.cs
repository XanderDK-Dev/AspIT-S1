namespace Opgave5
{
    internal class Opgave5Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tryk på en vilkårlig tast");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.Clear();
            switch (keyInfo.Key)
            {
                case ConsoleKey.B:
                case ConsoleKey.D:
                case ConsoleKey.F:
                case ConsoleKey.G:
                case ConsoleKey.H:
                case ConsoleKey.J:
                case ConsoleKey.K:
                case ConsoleKey.L:
                case ConsoleKey.M:
                case ConsoleKey.N:
                case ConsoleKey.P:
                case ConsoleKey.Q:
                case ConsoleKey.R:
                case ConsoleKey.S:
                case ConsoleKey.T:
                case ConsoleKey.V:
                case ConsoleKey.X:
                case ConsoleKey.Z:
                    Console.WriteLine("Du trykkede på en konsonant");
                    break;
                case ConsoleKey.A:
                case ConsoleKey.E:
                case ConsoleKey.I:
                case ConsoleKey.O:
                case ConsoleKey.U:
                case ConsoleKey.Y:
                    Console.WriteLine("Du trykkede på en vokal");
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ukendt tastetryk");
                    break;
            }
        }
    }
}
