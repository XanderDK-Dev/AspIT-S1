using System.Reflection;

namespace EX07SelectionIfElse
{
    internal class EX07Program
    {
        static void Main(string[] args)
        {
            string pickInput = "";
            Console.WriteLine("Where do you want to go:\n1) Discount calculator\n2) Check if 2 numbers are the same\n3) Divide 2 numbers\n4) Find highest of 2 number\n5) Align 2 numbers\n6) See if a number is positive or negative\n7) Check what it will cost to ship based on weight\n8) Calculator\nInput choice:");
            pickInput = Console.ReadLine();
            if (pickInput == "1")
            {
                double price = 0;
                Console.WriteLine("How much do you want to shop for?");
                price = double.Parse(Console.ReadLine());
                if (price >= 1000)
                {
                    Console.WriteLine(price * 0.05);
                }
                else
                {
                    Console.WriteLine("Not eligible for a discount");
                }
            }
            else if (pickInput == "2")
            {
                int num1 = 0;
                int num2 = 0;
                Console.WriteLine("Input a number, afterwards press enter:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Input a number, afterwards press enter:");
                num2 = int.Parse(Console.ReadLine());
                if (num1 == num2)
                {
                    Console.WriteLine("The 2 numbers are the same");
                }
                else
                {
                    Console.WriteLine("The 2 numbers are not the same");
                }

            }
            else if (pickInput == "3")
            {
                double inputOne = 0;
                double inputTwo = 0;
                Console.WriteLine("Input number one, afterwards press enter:");
                inputOne = double.Parse(Console.ReadLine());
                Console.WriteLine("Input number two, afterwards press enter:");
                inputTwo = double.Parse(Console.ReadLine());
                if (inputTwo != 0)
                {
                    Console.WriteLine(inputOne / inputTwo);
                }
                else { Console.WriteLine("Number 2 cannot equal 0"); }
            }
            else if (pickInput == "4")
            {
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
            else if (pickInput == "5")
            {
                int alignOne = 0;
                int alignTwo = 0;
                Console.WriteLine("Input number one, afterwards press enter:");
                alignOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Input number two, afterwards press enter:");
                alignTwo = int.Parse(Console.ReadLine());
                if (alignTwo == alignOne)
                {
                    Console.WriteLine($"{alignOne} {alignTwo}");
                }
                else if (alignTwo < alignOne)
                {
                    Console.WriteLine($"{alignTwo} {alignOne}");
                }
                else if (alignTwo > alignOne)
                {
                    Console.WriteLine($"{alignOne} {alignTwo}");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else if (pickInput == "6")
            {
                int positiveOne = 0;
                Console.WriteLine("Input number, afterwards press enter:");
                positiveOne = int.Parse(Console.ReadLine());
                if (positiveOne < 0)
                {
                    Console.WriteLine("The number is negative");
                }
                else if (positiveOne > 0)
                {
                    Console.WriteLine("The number is positive");
                }
                else if (positiveOne == 0)
                {
                    Console.WriteLine("The number is neither negative or positive");
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
            else if (pickInput == "7")
            {
                int gram = 0;
                int price = 0;
                string express = "";
                Console.WriteLine("How many gram does it weigh?");
                gram = int.Parse(Console.ReadLine());
                if (gram < 20)
                {
                    Console.WriteLine("5,00 kr.");
                    price = int.Parse(Console.ReadLine());
                }
                else if (gram >= 20 && gram < 50)
                {
                    Console.WriteLine("7,00 kr.");
                    price = 7;
                }
                else if (gram >= 50 && gram < 100)
                {
                    Console.WriteLine("10,00 kr.");
                    price = 10;
                }
                else if (gram >= 100 && gram < 150)
                {
                    Console.WriteLine("15,00 kr.");
                    price = 15;
                }
                else if (gram >= 150 && gram < 200)
                {
                    Console.WriteLine("20,00 kr.");
                    price = 20;
                }
                else
                {
                    Console.WriteLine("30,00 kr.");
                    price = 30;
                }
                Console.WriteLine("if you want express say express otherwise say normal");
                express = Console.ReadLine();
                if (express == "express")
                {
                    Console.WriteLine($"{price * 1.50} kr.");
                }
                else
                {
                    Console.WriteLine($"{price} kr.");
                }
            }
            else if (pickInput == "8")
            {
                string mathChoice = "";
                int numberOne = 0;
                int numberTwo = 0;
                Console.WriteLine("Input number one, afterwards press enter:");
                numberOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Input number two, afterwards press enter:");
                numberTwo = int.Parse(Console.ReadLine());
                Console.WriteLine("Pick an operation:\n1) Plus\n2) Minus\n3) Gange\n4) Division\n5) Modulo\nInput choice:");
                mathChoice = Console.ReadLine();
                if (mathChoice == "1")
                {
                    Console.WriteLine(numberOne + numberTwo);
                }
                else if (mathChoice == "1")
                {
                    Console.WriteLine(numberOne + numberTwo);
                }
                else if (mathChoice == "2")
                {
                    Console.WriteLine(numberOne - numberTwo);
                }
                else if (mathChoice == "3")
                {
                    Console.WriteLine(numberOne * numberTwo);
                }
                else if (mathChoice == "4")
                {
                    Console.WriteLine(numberOne / numberTwo);
                }
                else if (mathChoice == "5")
                {
                    Console.WriteLine(numberOne % numberTwo);
                }
            }
        }
        }
    }
