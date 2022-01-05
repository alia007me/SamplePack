using SamplePack.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePack.Impelements
{
    public class B : IB
    {
        public void Handle()
        {
            Console.WriteLine("We are in B Write");
        }
    }
}
