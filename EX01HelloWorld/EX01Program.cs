namespace EX01HelloWorld;

class EX01Program
{
    static void Main(string[] args)
    {
        string schoolName = "AspIT";
        Console.WriteLine(schoolName);

        schoolName = "AspIT -  Trekanten";
        Console.WriteLine(schoolName);

        string motto = "Fokuseret Talent";
        Console.WriteLine($"{schoolName} {motto}");
    }
}
