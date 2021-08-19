using System;
using System.Collections.Generic;
using System.Text;

namespace SIM
{
    public class NanoSIMCardAdapter : SIMcard
    {
        SmartPhone smartphone;
        NanoSIMCard nanoSimCard;
        private SIMcardSocket simCardSocket;

        public NanoSIMCardAdapter(NanoSIMCard simCard)
        {
            this.nanoSimCard = simCard;
        }

        public Data Read()
        {
            Console.WriteLine("beni oku");
            return nanoSimCard.Read();
        }

        public void Write(Data data)
        {
            Console.WriteLine("beni yaz");
            nanoSimCard.Write(data);
        }
    }
}
