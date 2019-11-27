using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Base
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Kopyalandı");
        }

        public void Duplicate()
        {
            Console.WriteLine("Duplicated");
        }
    }
}
