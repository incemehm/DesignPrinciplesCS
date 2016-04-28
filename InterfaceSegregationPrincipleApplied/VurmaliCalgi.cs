using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleApplied
{
    class VurmaliCalgi : ICalgi, IVurmaliCalgi
    {
        public void Basla()
        {
            Console.WriteLine("Vurmalı başlıyor...");
        }

        public void VurmaliCal()
        {
            Console.WriteLine("Vurmalı çalınıyor...");
        }

    }
}
