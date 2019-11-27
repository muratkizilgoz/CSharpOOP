using System;
using System.Collections.Generic;
using System.Text;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        // readonly ile ya burda yada constructorsda instance alabilirsin. Defensive Programming
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // burda instance alırsan çok ayıp edersin (geçmişi silemezsin)
            // şüphesiz ki burda instance alamaman için readonly oluşturduk.
            //Orders = new List<Order>();
        }
    }
}
