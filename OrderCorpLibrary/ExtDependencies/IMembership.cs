using System;
using System.Collections.Generic;
using System.Text;

namespace OrderCorpLibrary.ExtDependencies
{
    public interface IMembership
    {
        public string Purpose { get; set; }
        void Upgrade();
        void Activate();

    }
}
