using System;
using System.Collections.Generic;
using System.Text;

namespace OrderCorpLibrary
{
    public interface IProduct
    {
        int ProductType { get; set; }
        string ProductName { get; set; }

        string Purpose { get; set; }
    
    }
}
