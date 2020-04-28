using System;
using System.Collections.Generic;
using System.Text;

namespace GD1019Task1
{
    public class Park : IName
    {
        public string Name { get; private set; }

        public int TreeCount => trees.Count; // public int TreeCount { get { return trees.Count; } }

        private List<Tree> trees = new List<Tree>();

        public Park(string name)
        {
            Name = name;
        }

        public void AddNewTree()
        {
            trees.Add(new Tree());

            Console.WriteLine($"New tree added to park {Name}.");
        }
    }
}
