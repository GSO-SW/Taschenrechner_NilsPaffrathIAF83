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

        public static double Potenzrechnung(double wert1, double wert2)
        {
            return ergebnis;
        }


    }
}
