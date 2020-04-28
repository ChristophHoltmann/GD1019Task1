namespace GD1019Task1
{
    public class Resident : IName, IAge
    {
        public string Name { get; private set; }

        public float Age { get; }

        public Resident(string name = "Robin")
        {
            Name = name;
            Age = 0f;
        }

        public void GetOlder()
        {
            //throw new System.NotImplementedException();
        }
    }
}
