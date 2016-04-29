using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleApplied
{
    class Admin : IYuksekYetki, ITemelYetki
    {
        public void Sorgula()
        {
            Console.WriteLine("Admin sorguladı");
        }

        public void Yetkilendir(string kullaniciAdi)
        {
            Console.WriteLine("Admin, " + kullaniciAdi + " kullanıcısına yetki verdi");
        }
    }
}
