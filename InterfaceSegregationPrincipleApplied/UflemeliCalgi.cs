using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleApplied
{
    class UflemeliCalgi : ICalgi, IUflemeliCalgi
    {
        public void Basla()
        {
            Console.WriteLine("Üflemeli başlıyor...");
        }

        public void UflemeliCal()
        {
            Console.WriteLine("Üflemeli çalınıyor...");
        }
    }
}
