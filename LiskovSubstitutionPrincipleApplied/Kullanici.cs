using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleApplied
{
    class Kullanici : ITemelYetki
    {
        public void Sorgula()
        {
            Console.WriteLine("Kullanıcı sorguladı");
        }
    }
}
