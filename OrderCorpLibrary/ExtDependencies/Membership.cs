using System;
using System.Collections.Generic;
using System.Text;

namespace OrderCorpLibrary.ExtDependencies
{
    public class Membership : IMembership
    {
        public string Purpose { get; set; }

        public void Activate()
        {
            Console.WriteLine("Membership Activated");
        }

        public void Upgrade()
        {
            Console.WriteLine("Membership Upgraded");
        }
    }
}
