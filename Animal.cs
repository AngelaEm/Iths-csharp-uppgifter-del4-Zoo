using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Animal
    {
        public string Name;
        public string Species;
        public string Diet;

        public Animal(string name, string species, string diet)
        {
            this.Name = name;
            this.Species = species;
            this.Diet = diet;
        }

        public void MakeSound(string sound)
        {
            Console.WriteLine($"A {Species} make this sound: {sound}");
        }

        public void PrintInformation()
        {
            Console.WriteLine($"This is a {Species} named {Name}. Its diet is {Diet}.");
        }

        public void GetSpecies()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Diet: {Diet}");
        }

        public void GetFed(Zookeeper namn)
        {
            Console.WriteLine($"{Species} is fed by {namn.ZookeeperName}!");
        }

        


    }
}
