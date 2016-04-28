using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleApplied
{
    class Musluk
    {
        public void Doldur(ISise sise, int miktar)
        {
            sise.Doldur(miktar);
        }
    }
}
