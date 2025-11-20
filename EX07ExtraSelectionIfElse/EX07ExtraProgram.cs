using System;

namespace EX07ExtraSelectionIfElse
{
    internal class EX07ExtraProgram
    {
        static void Main(string[] args)
        {
            string pickInput = "";
            Console.WriteLine("Velkommen til mit store program!\n\nTast et bogstav for det du ønsker, og afslut med enter\na) Velkomstbesked\nb) Udregning af BMI\nc) Størst af to tal");
            pickInput = Console.ReadLine();
            if (pickInput == "a")
            {
                Console.Clear();
                Console.WriteLine("Indtast dit fornavm efterfulgt af enter");
                string firstName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Indtast dit efternavm efterfulgt af enter");
                string lastName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Velkommen {firstName}. Jeg kan se dit efternavn er {lastName}.");
            }
            else if (pickInput == "b")
            {
                string bmiStatus = "";
                double bmi = 0;
                Console.Clear();
                Console.WriteLine("Indtast din højde i meter, efterfulgt af enter");
                double height = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Indtast din vægt i kg, efterfulgt af enter");
                int weight = int.Parse(Console.ReadLine());
                Console.Clear();
                height = height * height;
                bmi = weight / height;
                Console.WriteLine($"Din BMI er: {bmi}");
                if (bmi < 18.5) { bmiStatus = "Undervægtig"; }
                else if (bmi > 18.5 && bmi < 24.9) { bmiStatus = "Sund vægt"; }
                else if (bmi > 24.9 && bmi < 29.9) { bmiStatus = "Overvægtig"; }
                else if (bmi > 30.0) { bmiStatus = "Obese"; }
                Console.WriteLine($"Din vægt er: {bmiStatus}");
            }
            else if (pickInput == "c")
            {
                Console.Clear();
                int numOne = 0;
                int numTwo = 0;
                Console.WriteLine("Input number one, afterwards press enter:");
                numOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Input number two, afterwards press enter:");
                numTwo = int.Parse(Console.ReadLine());
                if (numTwo == numOne)
                {
                    Console.WriteLine("The 2 numbers are equal");
                }
                else if (numTwo < numOne)
                {
                    Console.WriteLine($"The highest number is {numOne}");
                }
                else if (numTwo > numOne)
                {
                    Console.WriteLine($"The highest number is {numTwo}");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error only type a, b or c");

            }
        }
    }
}
