using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing
            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Luke");
            arrayList.Add(DateTime.Today);

            //Unboxing cast exception
            var number = (int) arrayList[1];

            //no boxing
            var list = new List<int>();
            list.Add(1);

            var stringList = new List<string>();
            stringList.Add("Luke");
        }
    }
}
