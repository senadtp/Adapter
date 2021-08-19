using System;
using System.Collections.Generic;
using System.Text;

namespace SIM
{
    public class SIMcardSocket 
    {
        SmartPhone smartPhone;
        SIMcard simCard;
        public void Insert(SIMcard simCard)
        {
            this.simCard = simCard;
            Console.WriteLine("eklendin");
        }

      
    }
}
