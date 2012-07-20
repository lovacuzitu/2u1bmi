using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;

namespace KONZOLA
{
    class Program
    {
        double _rezultat;

        public Program(double rezultat)
        {
            _rezultat = rezultat;
        }

        public static double UcitajTezinu()
        {

            double tezina = 0;
            int brojPokusaja = 0;

            while (brojPokusaja < 3)
            {
                Console.WriteLine("Unesite sopstvenu tezinu u kilogramima: ");
                string d = Console.ReadLine();
                try
                {
                    tezina = Double.Parse(d);
                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Greska. Unesite cifru za tezinu.");
                    brojPokusaja++;
                }
            }
            return tezina;
        }

        public static double UcitajVIsinu()
        {

            double visina = 0;
            int brojPokusaja = 0;

            while (brojPokusaja < 3)
            {
                Console.WriteLine("Unesite sopstvenu visinu u metrima (decimale odvojiti tackom): ");
                string d = Console.ReadLine();
                try
                {
                    visina = Double.Parse(d);
                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Greska. Unesite cifru za visinu.");
                    brojPokusaja++;
                }
            }
            return visina;
        }

        static void Main(string[] args)
        {
            Program program = new Program(BMIKalkulator.ispisiKategoriju(BMIKalkulator.IzracunajBMI(UcitajVIsinu(),UcitajTezinu())));
            Console.ReadLine();
        }
    }
}
