using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    public class BMIKalkulator
    {
        public static double IzracunajBMI(double visina, double tezina)
        {
            if (visina < 1.2 || visina > 2.5)
            {
                Console.WriteLine("Greska. Visina mora biti izmedju 1.2 i 2.5 metara");
                return -1;
            }
            if (tezina < 30 || tezina > 200)
            {
                Console.WriteLine("Greska. Tezina mora biti izmedju 30 i 150 kg");
                return -1;
            }
            double rez = tezina / (visina * visina);
            return rez;
        }

        public static double ispisiKategoriju(double bmi)
        {
            if (bmi <= 15 && bmi >= 0)
            {
                Console.WriteLine("Vas bmi je " + bmi + " i vi pripadate grupi anoreksicnih.");             
            }

            if (bmi > 15 && bmi <= 18.5)
            {
                Console.WriteLine("Vas bmi je " + bmi + " i vi pripadate grupi mrsavih.");
            }

            if (bmi > 18.5 && bmi <= 25)
            {
                Console.WriteLine("Vas bmi je " + bmi + " i vi pripadate grupi normalnih.");
            }

            if (bmi > 25 && bmi <= 30)
            {
                Console.WriteLine("Vas bmi je " + bmi + " i vi pripadate grupi popunjenih.");
            }

            if (bmi > 30 && (bmi <= 40))
            {
                Console.WriteLine("Vas bmi je " + bmi + " i vi pripadate grupi debelih.");
            }

            if (bmi > 40)
            {
                Console.WriteLine("Vas bmi je " + bmi + " i vi pripadate grupi gojaznih.");
            }
            return bmi;
        }
    }
}
