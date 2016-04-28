using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleIncorrect
{
    class YayliCalgi : ICalgi
    {
        public void YayliCal()
        {
            Console.WriteLine("Yaylı çalınıyor...");
        }

        public void UflemeliCal()
        {
            throw new NotImplementedException();
        }

        public void VurmaliCal()
        {
            throw new NotImplementedException();
        }

        public void Basla()
        {
            Console.WriteLine("Yaylı başlıyor...");
        }
    }
}
