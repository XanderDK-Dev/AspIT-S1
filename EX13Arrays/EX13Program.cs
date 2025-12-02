namespace EX13Arrays
{
    internal class EX13Program
    {
        static void Main(string[] args)
        {
            //int[ ] ages = new int [ 5 ];
            //ages [0] = 25;
            //ages [1] = 28;
            //ages [2] = 15;
            //ages [3] = 35;
            //ages [4] = 14;

            //for (int i = 0; i < ages.Length; i++)
            //{
            //    Console.WriteLine(ages[i]);
            //}

            //string[] names = new string[12];
            //names[0] = "Jonni";
            //names[1] = "Victor";
            //names[2] = "Nicklas";
            //names[3] = "Sanjay";
            //names[4] = "Alexander";
            //names[5] = "Forgot";
            //names[6] = "Anders";
            //names[7] = "Victor";
            //names[8] = "Jan";
            //names[9] = "Forgot";
            //names[10] = "Rasmus";
            //names[11] = "Forgot";

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //names[5] = "King Forgot";

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            int[] numbers = new int[] { 7, 79, 95, 78, 73, 18, 76, 80, 60, 21 };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] + 5;
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
