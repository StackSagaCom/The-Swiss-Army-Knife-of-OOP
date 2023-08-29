using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.DesignPatterns
{
    public class Factory
    {
        public interface IAnimal
        {
            void Speak();
        }

        public class Dog : IAnimal
        {
            public void Speak()
            {
                Console.WriteLine("Dog says: Grr-Wow.");
            }
        }

        public class Cat : IAnimal
        {
            public void Speak()
            {
                Console.WriteLine("Cat says: Purr-Meow.");
            }
        }

        public static class AnimalFactory
        {
            public static IAnimal CreateAnimal(string animalType)
            {
                switch (animalType.ToLower())
                {
                    case "dog":
                        return new Dog();
                    case "cat":
                        return new Cat();
                    default:
                        throw new ArgumentException("Invalid animal type.");
                }
            }
        }

    }
}
