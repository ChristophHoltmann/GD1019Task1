using System;
using System.Collections.Generic;

namespace GD1019Task1
{
    class Program
    {
        private static List<string> names = new List<string>() { "Robin", "Peter", "Olga", "Fritz", "Frida" };


        static void Main(string[] args)
        {
            ICity city = new City();
            ICity capital = new Capital();

            while (true)
            {
                Console.WriteLine("Type 'build' or 'b' to build a new Building.");
                Console.WriteLine("Type 'resident' or 'r' to add a new Resident to a Building.");
                Console.WriteLine("Type 'park' or 'p' to add a new Park.");
                Console.WriteLine("Type 'tree' or 't' to add a new Tree.");
                Console.WriteLine("Type 'info' or 'i' to get city info.");
                Console.WriteLine("Type 'exit' or 'x' to exit program.");

                string userInput = Console.ReadLine().ToLower();

                if (userInput == "build" || userInput.Equals("b"))
                {
                    city.NewBuilding();
                }
                else if (userInput.Equals("resident") || userInput.Equals("r"))
                {
                    Random random = new Random();
                    string name = names[random.Next(0, names.Count)];

                    city.NewResident(name);
                }
                else if(userInput.Equals("park") || userInput.Equals("p"))
                {
                    Console.WriteLine("Type a name for the park.");
                    string parkName = Console.ReadLine();
                    city.NewPark(parkName);
                }
                else if(userInput.Equals("tree") || userInput.Equals("t"))
                {
                    Console.WriteLine("Type the name of the park");
                    string parkName = Console.ReadLine();
                    Park park = city.GetPark(parkName);
                    if(park != null)
                    {
                        park.AddNewTree();
                    }
                    else
                    {
                        Console.WriteLine($"There is no park called: {parkName}");
                    }
                }
                else if (userInput.Equals("info") || userInput.Equals("i"))
                {
                    city.PrintInfo();
                }
                else if (userInput.Equals("exit") || userInput.Equals("x"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{userInput} is not a valide input!");
                }

                //Console.WriteLine(City.AllCityResidentCount);
                Console.WriteLine();
            }

            Console.WriteLine("Goodbye");
            Console.Read();
        }
    }
}
