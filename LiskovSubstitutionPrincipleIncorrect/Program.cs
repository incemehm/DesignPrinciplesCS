using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleIncorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IYetki> kullanicilar = new List<IYetki>
                          {
                             new Admin(),
                             new Kullanici(),
                             new Kullanici()
                          };

            Sorgula(kullanicilar);
            IslemYap(kullanicilar);
        }

        static void Sorgula(List<IYetki> kullanicilar)
        {   
            kullanicilar.ForEach(k => k.Sorgula());
        }

        static void IslemYap(List<IYetki> kullanicilar)
        {
            //kullanicilar.ForEach(k => k.Yetkilendir("TestUser")); // throw new NotImplementedException();

            kullanicilar.ForEach(k => { if (k is Admin) k.Yetkilendir("TestUser"); });
            // Nesneye tip kontrolü yapmak ilk akla gelen, fakat hatalı bir çözüm
        }
    }
}
