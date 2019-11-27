using System;

namespace MethodOverriding
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Base Draw");
        }
    }
}