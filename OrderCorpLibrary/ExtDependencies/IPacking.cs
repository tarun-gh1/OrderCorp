using System;
using System.Collections.Generic;
using System.Text;

namespace OrderCorpLibrary.ExtDependencies
{
    public interface IPacking
    {
        void GenerateSlip();
        void GenerateDuplicateSlip(int Dept);
        void AddFreeVideo();
    }
}
