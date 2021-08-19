using System;
using System.Collections.Generic;
using System.Text;

namespace SIM
{
    public class NanoSIMCard
    {
        private Data data;

        public Data Read()
        {
            Console.WriteLine("beni oku.");
            return data;
        }

        public void Write(Data data)
        {
            this.data = data;
            Console.WriteLine("beni yaz.");
        }
    }
}
