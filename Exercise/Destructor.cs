using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Destructor
    {
        public Destructor()
        {
            Console.WriteLine("An Instance of class created");
        }
        // Destructor
        ~Destructor()
        {
            Console.WriteLine("An Instance of class destroyed");
            Console.WriteLine("END OF EXAMPLE Destructor");
            Console.WriteLine("\n ------------------------");
        }
    }
}
