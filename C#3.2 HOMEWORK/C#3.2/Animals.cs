using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3._2
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public bool IsCarnivorous { get; set; }

        public Animal(string name, string species, int age, bool isCarnivorous)
        {
            Name = name;
            Species = species;
            Age = age;
            IsCarnivorous = isCarnivorous;
        }
    }
}
