using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleIncorrect
{
    class UflemeliCalgi : ICalgi
    {
        public void YayliCal()
        {
            throw new NotImplementedException();
        }

        public void UflemeliCal()
        {
            Console.WriteLine("Üflemeli çalınıyor...");
        }

        public void VurmaliCal()
        {
            throw new NotImplementedException();
        }

        public void Basla()
        {
            Console.WriteLine("Üflemeli başlıyor...");
        }
    }
}
