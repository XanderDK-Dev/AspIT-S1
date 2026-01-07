namespace PayCheck
{
    internal class PayCheckProgram
    {
        static void Main(string[] args)
        {
            PayCalculator p = new();
            try
            {
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
