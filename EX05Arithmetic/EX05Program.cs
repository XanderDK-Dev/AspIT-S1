namespace EX05Arithmetic
{
    internal class EX05Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double numAdd = 0;
            double numSub = 0;
            double numMul = 0;
            double numDiv = 0;
            double numMod = 0;
            Console.WriteLine("Intast et tal, efterfulgt af enter:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Intast endnu et tal, efterfulgt af enter:");
            num2 = double.Parse(Console.ReadLine());
            numAdd = num1 + num2;
            numSub = num1 - num2;
            numMul = num1 * num2;
            numDiv = num1 / num2;
            numMod = num1 % num2;
            Console.WriteLine($"----- RESULTATER -----\nPlus:           {num1} + {num2} = {numAdd}\nMinus:          {num1} - {num2} = {numSub}\nGange:          {num1} * {num2} = {numMul}\nDivision:       {num1} / {num2} = {numDiv}\nModulo:         {num1} % {num2} = {numMod}\n----------------------");


          //Console.WriteLine($"Resultated af de to tal lagt sammen er: {numAdd}");
          //Console.WriteLine($"Resultated af de to tal trukket fra hinanden er: {numSub}");
          //Console.WriteLine($"Resultated af de to tal ganget sammen er: {numMul}");
          //Console.WriteLine($"Resultated af de to tal divideret med hinanden er: {numDiv}");
          //Console.WriteLine($"Resultated af de to tal modulo med hinanden er: {numMod}");
        }
    }
}
