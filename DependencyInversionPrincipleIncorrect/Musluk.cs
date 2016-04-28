using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleIncorrect
{
    class Musluk
    {
        public void Doldur(PetSise sise, int miktar)
        {
            sise.Doldur(miktar);
        }
    }
}
