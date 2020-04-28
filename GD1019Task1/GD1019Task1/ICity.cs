using System;

namespace GD1019Task1
{
    public interface ICity
    {
        void NewBuilding();

        void NewResident(string name);

        void NewPark(string name);

        Park GetPark(string name);

        void PrintInfo();
    }
}
