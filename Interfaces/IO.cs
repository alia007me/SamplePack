using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePack.Interfaces
{
    public interface IO<T>
    {
        void Handle(T model);
    }
}
