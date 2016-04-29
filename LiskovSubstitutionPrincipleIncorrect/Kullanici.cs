using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleIncorrect
{
    class Kullanici : IYetki
    {
        public void Sorgula()
        {
            Console.WriteLine("Kullanıcı sorguladı");
        }

        public void Yetkilendir(string kullaniciAdi)
        {
            throw new NotImplementedException();
        }
    }
}
