using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleIncorrect
{
    interface IYetki
    {
        void Sorgula();
        void Yetkilendir(string kullaniciAdi);
    }
}
