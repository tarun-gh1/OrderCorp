using NUnit.Framework;
using OrderCorpLibrary;
using OrderCorpLibrary.ExtDependencies;

namespace OrderCorpTests
{
    public class Tests
    {
        IProduct product = new Product()
        {
            ProductType = (int)ProductTypes.ProdType.Physical,
            ProductName = "PhysicalProduct",
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
        /*
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
        */
        [Test]
        public void TestPackingMembershipNotifyDependencies()
        {
            // Arrange
            IPacking packing = new PackingSlip();
            INotify notify = new Notify();
            IMembership membership = new Membership();

            var order = new OrderCorpLib(packing, notify, membership);

            // Act
            bool orderCreated = order.CreateOrder(product);

            // Assert
            Assert.AreEqual(true, orderCreated);
        }

        [Test]
        public void TestCreateOrderWithPhysicalProduct()
        {
            // Arrange
            IPacking packing = new PackingSlip();
            INotify notify = new Notify();
            IMembership membership = new Membership();

            var order = new OrderCorpLib(packing, notify, membership);

            // Act
            bool orderCreated = order.CreateOrder(product);

            // Assert
            Assert.AreEqual(true, orderCreated);
        }
    }
}