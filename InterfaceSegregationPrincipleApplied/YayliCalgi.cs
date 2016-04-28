using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleApplied
{
    class YayliCalgi : ICalgi, IYayliCalgi
    {
        public void Basla()
        {
            Console.WriteLine("Yaylı başlıyor...");
        }

        public void YayliCal()
        {
            Console.WriteLine("Yaylı çalınıyor...");
        }
    }
}
