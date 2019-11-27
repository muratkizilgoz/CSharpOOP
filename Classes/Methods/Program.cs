using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var sayi = int.Parse("asd");
            //    Console.WriteLine(sayi);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("failed " + ex);
            //}

            var result = int.TryParse("asd", out int number);
            if (result)
                Console.WriteLine(number);
            Console.WriteLine("failed");

            UseParams();
            UsePoints();
        }

        static void UseParams()
        {
            Console.WriteLine(Calculator.Add(1, 2, 3));
            Console.WriteLine(Calculator.Add(1, 2, 3, 4, 5));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(14, 12);
                //point.Move(new Point(50, 70));
                point.Move(null);
                Console.WriteLine($"Point is at {point.X} {point.Y}");

                point.Move(100, 200);
                Console.WriteLine($"Point is at {point.X} {point.Y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Beklenmedik bir hata oluştu " + ex);
            }
        }
    }
}
