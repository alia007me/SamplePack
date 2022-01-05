using SamplePack.Interfaces;
using SamplePack.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePack.Impelements
{
    public class H : IO<CModel>, IO<DModel>
    {
        public void Handle(DModel model)
        {
            Console.WriteLine($"Write from {model.Content}");
        }

        public void Handle(CModel model)
        {
            Console.WriteLine($"Write from {model.Content}");
        }
    }
}
