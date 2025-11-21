namespace Opgave1
{
    internal class Opgave1Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast en af følgene dyr:\n" +
                "Gris, Hund, Kat eller Ko:");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "gris":
                    Console.WriteLine("Grisen har en grisehale og leverer bacon.");
                    break;
                case "hund":
                    Console.WriteLine("Hunde kan lygte mindst 40 gange bedre end os");
                    break;
                case "kat":
                    Console.WriteLine("Katte kan hoppe 5 gange deres højde");
                    break;
                case "Ko":
                    Console.WriteLine("Køer bliver normalt op til 20 år");
                    break;
                default: Console.WriteLine("Error...");
                    break;
            }
        }
    }
}
