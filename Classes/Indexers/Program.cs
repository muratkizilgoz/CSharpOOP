using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie { ["name"] = "Peppa Pig" };
            Console.WriteLine(cookie["name"]);
        }
    }
}
