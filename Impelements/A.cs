using SamplePack.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePack.Impelements
{
    public class A : IA
    {
        public void Write()
        {
            Console.WriteLine("We are in A Write");
        }
    }
}
