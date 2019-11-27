using System;

namespace ConstructorsInheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber):base(registrationNumber)
        {
            Console.WriteLine($"Car initialized {registrationNumber}");
        }
    }
}