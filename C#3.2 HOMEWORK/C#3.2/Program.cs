namespace C_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo myZoo = new Zoo("My Zoo", "City X", 1000);

            
            myZoo.AddAnimal(new Animal("Leo", "Lion", 5, true));
            myZoo.AddAnimal(new Animal("Giraffe1", "Giraffe", 7, false));
            myZoo.AddAnimal(new Animal("Giraffe2", "Giraffe", 4, false));
            myZoo.AddAnimal(new Animal("Penguin", "Penguin", 3, false));

            
            myZoo.DisplayAnimals();

        }
    }
}