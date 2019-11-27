using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    public class Person
    {
        public string Name;

        public void Introduce(string name)
        {
            Console.WriteLine($"Helü {name}, I'm {Name}");
        }

        public static Person Parse(string name)
        {
            var person = new Person() { Name = name };
            return person;
        }
    }
}
