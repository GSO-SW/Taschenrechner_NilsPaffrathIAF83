using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenrechnerUHD
{
    class Berechnungen
    {

        public static double ergebnis;


        public static double Addition(double wert1, double wert2)
        {
           
            ergebnis = wert1 + wert2;
            return ergebnis;
        }

        public static double Subtraktion(double wert1, double wert2)
        {
        
            ergebnis = wert1 - wert2;
            return ergebnis;

        }

        public static double Multiplikation(double wert1, double wert2)
        {
            ergebnis = wert1 * wert2;
            return ergebnis;
        }

        public static double Division(double wert1, double wert2)
        {
            ergebnis = wert1 / wert2;
            return ergebnis;
        }

        public static double PotenzrechnungHoch2(double wert1)
        {
            ergebnis = wert1 * wert1;
            return ergebnis;
        }

        public static double PotenzrechnungXHochY(double wert1,int hochzahl)
        {
            double zwischenergebnis = wert1;
            for (int i = 1; i < hochzahl; i++)
            {
                ergebnis = zwischenergebnis * wert1;
                zwischenergebnis = ergebnis;
            }
            return ergebnis;
        }


    }
}
