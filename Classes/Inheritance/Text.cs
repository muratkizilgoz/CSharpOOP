using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Text : Base
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void HyperLink(string url)
        {
            Console.WriteLine("Added a link to " + url);
        }


    }
}
