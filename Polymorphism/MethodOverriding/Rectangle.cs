﻿using System;

namespace MethodOverriding
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle Draw");
            base.Draw();
        }
    }
}