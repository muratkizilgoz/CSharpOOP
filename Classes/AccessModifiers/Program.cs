using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1923, 10, 29));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
