using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Person
            //var person = new Person(){Name = "Murat"};
            //person.Introduce("Bruce");

            //var person = Person.Parse("Murat");
            //person.Introduce("Bruce"); 
            #endregion

            #region CustomerOrder
            var customer = new Customer(1, "Bruce");
            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine($"{customer.Id} {customer.Name}");
            #endregion
        }
    }
}
