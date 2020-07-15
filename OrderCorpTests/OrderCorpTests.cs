using NUnit.Framework;
using OrderCorpLibrary;

namespace OrderCorpTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            var order = new OrderCorpLib();

            // Act
            bool orderCreated = order.CreateOrder();
            
            // Assert
            Assert.AreEqual(true, orderCreated);
        }
    }
}