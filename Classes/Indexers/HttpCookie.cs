using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Tarih { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }
    }
}
