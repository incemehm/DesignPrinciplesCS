using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleApplied
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
            // yayli.UflemeliCal();   //  Yaylı için tanımsız
            // yayli.VurmaliCal();    //  Yaylı için tanımsız

            uflemeli.Basla();
            uflemeli.UflemeliCal();
            // uflemeli.YayliCal();   //  Üflemeli için tanımsız
            // uflemeli.VurmaliCal(); //  Üflemeli için tanımsız

            vurmali.Basla();
            vurmali.VurmaliCal();
            // vurmali.UflemeliCal(); //  Vurmalı için tanımsız
            // vurmali.YayliCal();    //  Vurmalı için tanımsız
        }
    }
}
