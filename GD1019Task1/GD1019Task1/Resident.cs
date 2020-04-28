namespace GD1019Task1
{
    public class Resident : IName
    {
        public string Name { get; private set; }

        public Resident(string name = "Robin")
        {
            Name = name;
        }
    }
}
