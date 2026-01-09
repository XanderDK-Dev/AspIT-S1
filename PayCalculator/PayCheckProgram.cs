namespace PayCheck
{
    internal class PayCheckProgram
    {
        static void Main(string[] args)
        {
            try
            {
                PayCalculator p = new PayCalculator(
                248,
                (DateTime.Parse("2026-01-05"), DateTime.Parse("2026-01-19")),  // 14 days starting Monday
                0.35,      // taxPercent (35%)
                74m,       // hoursWorked
                293m       // hourSalary
                );

                // Test the calculations
                Console.WriteLine($"Gross Pay: {p.GrossPay()} kr");
                Console.WriteLine($"Tax Amount: {p.TaxAmount()} kr");
                Console.WriteLine($"Net Pay: {p.NetPay()} kr");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
