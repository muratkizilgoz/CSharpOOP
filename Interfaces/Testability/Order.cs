using System;

namespace Testability
{
    public class Order
    {
        public decimal TotalPrice { get; set; }
        public bool IsShipped => Shipment != null;
        public DateTime CreatedDate { get; set; }
        public Shipment Shipment { get; set; }

    }
}