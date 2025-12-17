using CarHandler;
namespace EX17Objects
{
    internal class EX17Program
    {

        static void Main(string[] args)
        {
            //Car myCar = new Car("Ford", "Mustang", 1987, "Red" );
            //Console.WriteLine(myCar.ToString());
            //Console.WriteLine(myCar.GetInfo());
            //myCar.Color = "Blue";
            //Console.WriteLine(myCar.StartCar());

            List<Car> cars = new();

            Car car1 = new Car("Ford", "Mustang", 1966, "Red");
            Car car2 = new Car("Porsche", "911", 2004, "Silver");

            cars.Add(car1);
            cars.Add(car2);

            string pickInput = "";
            string carMake = "";
            string carModel = "";
            int carProductionYear = 0;
            string carColor = "";
            bool running = true;
            string searchTerm = "";
            bool foundAny = false;
            int startAttempts = 0;
            while (running)
            {
                Console.WriteLine("You have 2 options. Do you wish to:\nSubmit a car (1)?\nSee information about all cars (2)?\nSearch for a car brand (3)\nInput your choice:");
                pickInput = Console.ReadLine();
                if (pickInput == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Whats the make of your car");
                    carMake = Console.ReadLine();
                
                    Console.Clear();
                    Console.WriteLine("Whats the model of your car");
                    carModel = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Whats the production year of your car");
                    carProductionYear = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Whats the color of your car");
                    carColor = Console.ReadLine();

                    Console.Clear();

                    Car newCar = new Car(carMake, carModel, carProductionYear, carColor);

                    while (newCar.StartCar() == false)
                    {
                        startAttempts++;
                    }

                    Console.WriteLine($"{newCar} used {startAttempts} attempts to start");

                    cars.Add(newCar);

                    Console.WriteLine("Car added successfully!");
                }

                if (pickInput == "2")
                {
                    Console.Clear();
                    foreach (Car c in cars)
                    {
                        Console.WriteLine($"c\n");
                    }
                }

                if (pickInput == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Search for brand:");
                    searchTerm = Console.ReadLine();
                    foreach (Car c in cars)
                    {
                        if (c.Make.ToLower() == searchTerm.ToLower())
                        {
                            Console.WriteLine($"{c}\n");
                            foundAny = true;
                        }
                    }

                    if (!foundAny)
                    {
                        Console.WriteLine("No cars found!");
                    }
                }
            }


        }
    }
}
