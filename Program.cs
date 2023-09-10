namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal("Vinga", "dog", "omnivore");
            Animal lion = new Animal("Leo", "lion", "carnivore");
            Animal koala = new Animal("Kolle", "koala", "herbivore");
            Animal pig = new Animal ("Piggy", "pig", "omnivore");
            Animal dolphine = new Animal("Dolly", "dolphine", "carnivore");
            Animal elephant = new Animal("Elo", "elephant", "herbivore");

            Zookeeper angela = new Zookeeper("Angela");

            angela.FeedAnimals(dog);
            lion.GetFed(angela);
          

            List<Animal> animals = new List<Animal>();
            animals.Add(dog);
            animals.Add(lion);
            animals.Add(koala);
            animals.Add(pig);
            animals.Add(dolphine);
            animals.Add(elephant);
            
            foreach (Animal animal in animals)
            {
                PrintStars();
                animal.GetSpecies();
                angela.FeedAnimals(animal);
            } 
            
            

            Console.ReadKey();
        }

        static void PrintStars()
        {
            Console.WriteLine("\n*************************\n");
        }
    }
}