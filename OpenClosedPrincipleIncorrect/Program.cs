using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleIncorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            Write(new A3());
            Write(new A4());
        }

        private static void Write(object paper)
        {
            if (paper is A3)
                ((A3)paper).Write();

            if (paper is A4)
                ((A4)paper).Write();
        } 
    }
}
