using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3._2
{
    internal class Zoo
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public List<Animal> Animals { get; set; }

        public Zoo(string name, string location, int capacity)
        {
            Name = name;
            Location = location;
            Capacity = capacity;
            Animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void DisplayAnimals()
        {
            Console.WriteLine($"Animals in {Name}:");

            foreach (var animal in Animals)
            {
                Console.WriteLine($"{animal.Name} - {animal.Species}, Age: {animal.Age}, Carnivorous: {animal.IsCarnivorous}");
            }
        }
    }
}
