using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleApplied
{
    class Program
    {
        static void Main(string[] args)
        {
            Write(new A3());
            Write(new A4());
        }

        private static void Write(IPaper paper)
        {
            paper.Write();
        } 
    }
}
