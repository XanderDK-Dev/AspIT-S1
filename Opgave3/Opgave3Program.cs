namespace Opgave3
{
    internal class Opgave3Program
    {
        static void Main(string[] args)
        {
            string tryAgain = "1";
            while (tryAgain == "1")
            {
                Console.Clear();
                Random rnd = new Random();
                int dice = rnd.Next(1, 7);
                string result = "";
                switch (dice)
                {
                    case 1:
                        result = "etter"; break;
                    case 2:
                        result = "toer"; break;
                    case 3:
                        result = "treer"; break;
                    case 4:
                        result = "fire"; break;
                    case 5:
                        result = "femmer"; break;
                    case 6:
                        result = "sekser"; break;
                    default:
                        break;
                }
                Console.WriteLine($"Du har slået en {result}!");
                Console.WriteLine("1) Prøv igen\n2) Afslut");
                tryAgain = Console.ReadLine();
            }
                    
        }
    }
}
