using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.OOP
{
    public class Composition
    {
        public class BodyPart
        {
            public string Name { get; }

            public BodyPart(string name)
            {
                Name = name;
            }
        }

        public class Animal
        {
            public string Species { get; }
            public List<BodyPart> BodyParts { get; }

            public Animal(string species)
            {
                Species = species;
                BodyParts = new List<BodyPart>();
            }

            public void AddBodyPart(string bodyPartName)
            {
                BodyParts.Add(new BodyPart(bodyPartName));
            }
        }
    }
}
