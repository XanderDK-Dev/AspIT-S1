namespace Opgave4
{
    internal class Opgave4Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et familiemedlem (fx mor, bedstefar eller lignende");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "mor":
                case "far":
                    Console.WriteLine("Du har indtastet et " +
                        "2. generationsmedlem af familien.");
                    break;
                case "mormor":
                case "farmor":
                case "farfar":
                    Console.WriteLine("Du har indtastet et " +
                        "3. generationsmedlem af familien.");
                    break;
                case "bedstemor":
                case "bedstefar":
                    Console.WriteLine("Du har indtastet et " +
                        "4. generationsmedlem af familien.");
                    break;
                default:
                    Console.WriteLine("Du har indtastet et ukendt familiemedlem");
                    break;
            }
        }
    }
}
