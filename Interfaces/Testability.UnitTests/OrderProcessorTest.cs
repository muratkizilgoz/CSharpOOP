using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTest
    {
        //methodname_condition_expectation
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnEx()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalc());
            var order = new Order()
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetThePropOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalc());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1,order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today,order.Shipment.ShippingDate);

        }
    }

    public class FakeShippingCalc : IShippingCalculator
    {
        public decimal CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
