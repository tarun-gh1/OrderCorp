using NUnit.Framework;
using OrderCorpLibrary;
using OrderCorpLibrary.ExtDependencies;

namespace OrderCorpTests
{
    public class Tests
    {
        IProduct product = new Product()
        {
            ProductType = 1,
            ProductName = "Learning to Ski",
            Purpose = "Upgrade"

        };

        [Test]
        public void TestOrderCreateInitial()
        {
            // Arrange
            var order = new OrderCorpLib();

            // Act
            bool orderCreated = order.CreateOrder();
            
            // Assert
            Assert.AreEqual(true, orderCreated);
        }

        [Test]
        public void TestOrderCreatePassProduct()
        {
            // Arrange
            var order = new OrderCorpLib();
            
            // Act
            bool orderCreated = order.CreateOrder(product);

            // Assert
            Assert.AreEqual(true, orderCreated);
        }

        [Test]
        public void TestPackingMembershipNotifyDependencies()
        {
            // Arrange
            IPacking packing = new PackingSlip();
            var order = new OrderCorpLib(packing);

            // Act
            bool orderCreated = order.CreateOrder(product);

            // Assert
            Assert.AreEqual(true, orderCreated);
        }
    }
}