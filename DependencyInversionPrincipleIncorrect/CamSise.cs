using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleIncorrect
{
    class CamSise
    {
        int miktar { get; set; }
        public void Doldur(int miktar)
        {
            this.miktar = miktar;
        }
    }
}
