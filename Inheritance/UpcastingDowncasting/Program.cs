using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 123;
            //shape.Width = 23;
            ////Same object referance diffrent view. result 23
            //Console.WriteLine(text.Width);

            //StreamReader reader = new StreamReader(new MemoryStream());

            ////Like a mevlana
            //var arrayList = new ArrayList();
            //arrayList.Add(213);
            //arrayList.Add("asdasda");
            //arrayList.Add(new Text());

            ////Sadece shape of you..
            //var list = new List<Shape>();

            Shape shape = new Text();
            Text text = (Text) shape;


        }
    }
}
