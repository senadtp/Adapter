using System;
using System.Collections.Generic;
using System.Text;

namespace SIM
{
    public class SmartPhone
    {
        SIMcardSocket simCardSocket;
        public SmartPhone(SIMcardSocket simcardsocket)
        {
            this.simCardSocket = simcardsocket;
        }

    }
}
