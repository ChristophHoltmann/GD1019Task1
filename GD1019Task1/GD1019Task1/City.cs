using System;
using System.Collections.Generic;

namespace GD1019Task1
{
    public class City : ICity, IName
    {
        public static int AllCityResidentCount { get; private set; }

        public string Name => "Wonderful City";

        private List<Building> buildings = new List<Building>();

        private List<Park> parks = new List<Park>();

        public City()
        {

        }

        public void NewBuilding()
        {
            Random random = new Random();
            int residentPlaces = random.Next(1, 4); // >= 1 && < 4

            string name = buildings.Count.ToString();
            buildings.Add(new Building(name, residentPlaces));

            Console.WriteLine($"New building (name: {name}) added with {residentPlaces} places.");
        }

        public void NewResident(string name = "Robin")
        {
            List<Building> possibleBuildings = new List<Building>();

            // Find buildings with empty spaces
            foreach (var building in buildings)
            {
                if (building.FreePlaces > 0)
                {
                    possibleBuildings.Add(building);
                }
            }

            // Place new resident randomly in one of the possible buildings
            if (possibleBuildings.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(0, possibleBuildings.Count);
                if (possibleBuildings[index].AddNewResident(name))
                {
                    AllCityResidentCount++;
                    Console.WriteLine($"New resident added to building {possibleBuildings[index].Name}.");
                }
                else
                {
                    Console.WriteLine("No resident could be added!");
                }
            }
            else
            {
                Console.WriteLine("No free buildings!");
            }
        }

        public void NewPark(string name)
        {
            parks.Add(new Park(name));
            Console.WriteLine($"New park (name: {name}) added.");
        }

        public Park GetPark(string name)
        {
            //foreach(var park in parks)
            //{
            //    if(park.Name.Equals(name))
            //    {
            //        return park;
            //    }
            //}

            //return null;

            return parks.Find(park => park.Name.Equals(name));
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Building count: {buildings.Count}.");
            Console.WriteLine($"Park count: {parks.Count}.");

            // ToDo: Static Method
            string parkNames = string.Empty;
            foreach (var park in parks)
            {
                // Add every name to the string
                parkNames += $"{park.Name}: tree count = {park.TreeCount}, ";
            }
            if (parkNames.Length > 2)
            {
                parkNames = parkNames.Remove(parkNames.Length - 2);
            }
            Console.WriteLine($"Parks: {parkNames}");

            int residentCount = 0;
            int emptyBuildings = 0;
            foreach (var building in buildings)
            {
                // Count residents
                residentCount += building.UsedPlaces;

                if (building.UsedPlaces == 0)
                {
                    // Count empty buildings
                    emptyBuildings++; // += 1; // emptyBuildings = emptyBuildings + 1;
                }
                else
                {
                    Console.WriteLine($"Residents of building {building.Name}: {building.GetAllResidentNamesAsString()}.");
                }
            }

            Console.WriteLine($"Total resident count: {residentCount}.");
            Console.WriteLine($"Empty building count: {emptyBuildings}.");
        }
    }
}
