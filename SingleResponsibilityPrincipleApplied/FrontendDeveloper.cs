using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipleApplied
{
    public class FrontendDeveloper
    {
        public void DesignWebPage()
        {
            ChangeHTML();
            ChangeCSS();
            ChangeJS();
        }

        private void ChangeHTML()
        {
            Console.WriteLine("HTML changed");
        }

        private void ChangeCSS()
        {
            Console.WriteLine("CSS changed");
        }

        private void ChangeJS()
        {
            Console.WriteLine("JS changed");
        }
    }
}
