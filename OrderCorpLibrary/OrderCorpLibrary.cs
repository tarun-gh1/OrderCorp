using OrderCorpLibrary.ExtDependencies;
using System;

namespace OrderCorpLibrary
{
    public class OrderCorpLib
    {
        private readonly IPacking packing;

        public OrderCorpLib()
        {
                
        }
        public OrderCorpLib(IPacking packing)
        {
            this.packing = packing;
        }
        public bool CreateOrder()
        {
            bool orderCreated = true;


            return orderCreated;
        }
        public bool CreateOrder(IProduct product)
        {
            bool orderCreated = true;


            return orderCreated;
        }

    }
}
