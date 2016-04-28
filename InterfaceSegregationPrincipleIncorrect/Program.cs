using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleIncorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            
            YayliCalgi yayli = new YayliCalgi();
            UflemeliCalgi uflemeli = new UflemeliCalgi();
            VurmaliCalgi vurmali = new VurmaliCalgi();

            yayli.Basla();
            yayli.YayliCal();
            yayli.UflemeliCal(); // throw new NotImplementedException();
            yayli.VurmaliCal(); // throw new NotImplementedException();

            uflemeli.Basla();
            uflemeli.UflemeliCal();
            uflemeli.YayliCal(); // throw new NotImplementedException();
            uflemeli.VurmaliCal(); // throw new NotImplementedException();

            vurmali.Basla();
            vurmali.VurmaliCal();
            vurmali.UflemeliCal(); // throw new NotImplementedException();
            vurmali.YayliCal(); // throw new NotImplementedException();
        }
    }
}
