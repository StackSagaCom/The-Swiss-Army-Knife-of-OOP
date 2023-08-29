using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.OOP
{
    public class Inheritance
    {
        public class Details : User
        {
            public int Age;
            public Details()
            {
                Console.WriteLine("Child Class Constructor");
            }
            public void GetAge()
            {
                Console.WriteLine("Age: {0}", Age);
            }
        }
    }
    public class User
    {
        public string Name;
        private string Location;
        public User()
        {
            Console.WriteLine("Base Class Constructor");
        }
        public void GetUserInfo(string loc)
        {
            Location = loc;
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
        }
    }
}
