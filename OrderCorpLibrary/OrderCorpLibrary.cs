using OrderCorpLibrary.ExtDependencies;
using System;

namespace OrderCorpLibrary
{
    public class OrderCorpLib
    {
        private readonly IPacking packing;
        private readonly INotify notify;
        private readonly IMembership membership;

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
            bool orderCreated = false;

            switch (product.ProductType)
            {
                case (int)ProductTypes.ProdType.Physical:
                    packing.GenerateSlip();
                    orderCreated = true;
                    break;
                case (int)ProductTypes.ProdType.Book:
                    packing.GenerateDuplicateSlip((int)Department.Royalty);
                    orderCreated = true;
                    break;
                case (int)ProductTypes.ProdType.Membership:
                    if (product.Purpose == "Activate")
                    {
                        membership.Activate();
                        notify.NotifyUser(product.Purpose);
                    }
                    else if (product.Purpose == "Upgrade")
                    {
                        membership.Upgrade();
                        notify.NotifyUser(product.Purpose);
                    }
                    orderCreated = true;
                    break;
                case (int)ProductTypes.ProdType.Video:
                    if (String.Equals(product.ProductName, "Learning to Ski"))
                    {
                        packing.GenerateSlip();
                        packing.AddFreeVideo();
                    }
                    orderCreated = true;
                    break;

                default:
                    break;
            }

            return orderCreated;
        }

    }
}
