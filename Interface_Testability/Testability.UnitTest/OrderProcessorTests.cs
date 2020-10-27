using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.UnitTest
{
    [TestClass]
    public class OrderProcessorTests
    {
        // MethodName_Condition_Expectation
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlredyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FackeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };
            orderProcessor.Process(order);
        }
        
        [TestMethod]
        public void Process_OrdeIsNotShipped_ShoudSetTheShipmenPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FackeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1),order.Shipment.ShippingDate);
        }
    }

    public class FackeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
