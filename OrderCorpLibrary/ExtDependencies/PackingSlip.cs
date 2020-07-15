using System;
using System.Collections.Generic;
using System.Text;

namespace OrderCorpLibrary.ExtDependencies
{
    public class PackingSlip : IPacking
    {
        public void AddFreeVideo()
        {
            Console.WriteLine("Free video added");
        }

        public void GenerateDuplicateSlip(int Dept)
        {
            Console.WriteLine("");
        }

        public void GenerateSlip()
        {
            Console.WriteLine("Packing slip generated");
        }
    }
}
