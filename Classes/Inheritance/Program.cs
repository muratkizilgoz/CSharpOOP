using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.FontName = "Arial";
            text.FontSize = 14;

            text.HyperLink("google.it");
            text.Copy();
            text.Duplicate();
        }
    }
}
