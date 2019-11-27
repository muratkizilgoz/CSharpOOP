using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
                Console.WriteLine("Level 1");
            Console.WriteLine("Promote Level 2");
        }

        public void Promote(bool ornek2)
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            Console.WriteLine("Promote örnek 2");
        }

        private int CalculateRating()
        {
            return 0;
        }
    }
}
