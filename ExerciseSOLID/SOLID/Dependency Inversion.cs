using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSOLID.SOLID
{
    // Abstraction
    public interface IAnimal
    {
        void Eat();
    }

    // High-level module
    public class FeedingSystem
    {
        public void FeedAnimal(IAnimal animal)
        {
            animal.Eat();
        }
    }

    // Low-level modules
    public class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating dog food.");
        }
    }

    public class Cat : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Cat is eating fish.");
        }
    }

}
