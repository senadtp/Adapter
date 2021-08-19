using System;

namespace SIM
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            SIMcardSocket simCardSocket = new SIMcardSocket();
         

            NanoSIMCard nanoSimCard = new NanoSIMCard();
            NanoSIMCardAdapter sena = new NanoSIMCardAdapter(nanoSimCard);
            sena.Write(data);
            sena.Read();       

           
        }
    }
}
