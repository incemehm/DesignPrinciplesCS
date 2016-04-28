using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipleApplied
{
    class Program
    {
        static void Main(string[] args)
        {
            BackendDeveloper developer1 = new BackendDeveloper();
            developer1.DevelopWebPage();

            FrontendDeveloper developer2 = new FrontendDeveloper();
            developer2.DesignWebPage();
        }
    }
}
