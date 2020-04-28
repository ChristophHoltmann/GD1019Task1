using System.Collections.Generic;

namespace GD1019Task1
{
    public class Building
    {
        public string Name { get; private set; }

        public int FreePlaces { get { return TotalPlaces - UsedPlaces; } }

        public int UsedPlaces { get { return residents.Count; } }

        public int TotalPlaces { get; private set; }

        private List<Resident> residents = new List<Resident>();

        public Building(string name, int places)
        {
            Name = name;
            TotalPlaces = places;
        }

        public bool AddNewResident(string name = "Robin")
        {
            if (FreePlaces > 0)
            {
                // Add new resident id there is space
                residents.Add(new Resident(name));
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetAllResidentNamesAsString()
        {
            string names = string.Empty; // ""
            foreach (var resident in residents)
            {
                // Add every name to the string
                names += $"{resident.Name}, ";
            }

            if (names.Length > 2)
            {
                names = names.Remove(names.Length - 2);
            }

            return names;
        }
    }
}
