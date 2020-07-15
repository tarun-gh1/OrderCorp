using OrderCorpLibrary;
using OrderCorpLibrary.ExtDependencies;
using System;

namespace OrderCorp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool orderStatus = false;
            IPacking packing = new PackingSlip();
            INotify notify = new Notify();
            IMembership membership = new Membership();

            var order = new OrderCorpLib(packing, notify, membership);

            // Physical Product
            IProduct product = new Product()
            {
                ProductType = (int)ProductTypes.ProdType.Video,
                ProductName = "Learning to Ski",
                Purpose = "Activate"   // OR Upgrade

            };
            orderStatus = order.CreateOrder(product);
            
            if (orderStatus == true)
            {
                Console.WriteLine("Order created.");
            }
            else
            {
                Console.WriteLine("Error creating Order. Please check.");
            }
            Console.ReadLine();
       
        }
    }
}
