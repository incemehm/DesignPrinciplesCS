using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleIncorrect
{
    class VurmaliCalgi : ICalgi
    {
        public void YayliCal()
        {
            throw new NotImplementedException();
        }

        public void UflemeliCal()
        {
            throw new NotImplementedException();
        }

        public void VurmaliCal()
        {
            Console.WriteLine("Vurmalı çalınıyor...");
        }

        public void Basla()
        {
            Console.WriteLine("Vurmalı başlıyor...");
        }
    }
}
