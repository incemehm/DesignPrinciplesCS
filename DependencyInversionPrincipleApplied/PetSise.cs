using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleApplied
{
    class PetSise : ISise
    {
        int miktar;

        public void Doldur(int miktar)
        {
            this.miktar = miktar;
        }
    }
}
