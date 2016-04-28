using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleApplied
{
    class Program
    {
        static void Main(string[] args)
        {
            Musluk musluk = new Musluk();
            PetSise sise = new PetSise();
            musluk.Doldur(sise, 100);

            CamSise camSise = new CamSise();
            musluk.Doldur(camSise, 50); 
            // Artık cam şişe de doldurabiliyoruz
            // Musluk sınıfını, şişe sınıflarına daha az bağımlı hale getirdik
        }
    }
}
