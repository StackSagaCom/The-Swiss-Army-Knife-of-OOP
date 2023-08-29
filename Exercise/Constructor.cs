using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Constructor
    {
            public string name, location;
            // Default Constructor
            public Constructor()
            {
                name = "This is my name, Arpad, and it will be shown automatically";
                location = "Also, my location is set to Croatia";
            }

        // Parametrized Constructor
        public Constructor(string name, string location)
        {
            this.name = name;
            this.location = location;
        }
    }
}
