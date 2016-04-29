using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleApplied
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITemelYetki> temelKullanicilar = new List<ITemelYetki>
                          {
                             new Admin(),
                             new Kullanici(),
                             new Kullanici()
                          };

            List<IYuksekYetki> yetkililer = new List<IYuksekYetki>
                          {
                             new Admin(),
                             new Admin()
                          };

            Sorgula(temelKullanicilar);
            IslemYap(yetkililer);
        }

        static void Sorgula(List<ITemelYetki> kullanicilar)
        {
            kullanicilar.ForEach(k => k.Sorgula());
        }

        static void IslemYap(List<IYuksekYetki> kullanicilar)
        {
            kullanicilar.ForEach(k => k.Yetkilendir("TestUser"));
            // Artık tip kontrolü yapmadan nesnemizi istediğimiz gibi kullanabiliriz
        }
    }
}
