using System;
using System.Collections.Generic;
using System.Text;

namespace OrderCorpLibrary.ExtDependencies
{
    public class Notify : INotify
    {
        public void NotifyUser(string purpose)
        {
            Console.WriteLine($"User notified. Purpose: {purpose}");
        }
    }
}
