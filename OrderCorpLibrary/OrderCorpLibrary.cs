using OrderCorpLibrary.ExtDependencies;
using System;

namespace OrderCorpLibrary
{
    public class OrderCorpLib
    {
        private readonly IPacking packing;
        private INotify notify;
        private IMembership membership;

        public OrderCorpLib()
        {
                
        }
        public OrderCorpLib(IPacking packing)
        {
            this.packing = packing;
        }

        public OrderCorpLib(IPacking packing, INotify notify, IMembership membership)
        {
            this.packing = packing;
            this.notify = notify;
            this.membership = membership;
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
