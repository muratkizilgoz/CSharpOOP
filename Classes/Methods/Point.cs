﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        //OverLoading
        public void Move(Point newLocation)
        {
            //Defensive programming
            if (newLocation == null)
                throw new ArgumentException("newLocation");
            Move(newLocation.X, newLocation.Y);
        }
    }
}
