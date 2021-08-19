using System;
using System.Collections.Generic;
using System.Text;

namespace SIM
{
    public interface SIMcard
    {
        Data Read();

        //void read();
        void Write(Data data);
    }
}
