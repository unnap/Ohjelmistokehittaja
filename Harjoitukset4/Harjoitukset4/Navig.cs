using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitukset4
{
    class Navig
    {
        public static void Valikko()
        {
        alku:
            Console.WriteLine("a) Harjoitus 1\nb) Harjoitus 2\nc) Harjoitus 3\n" +
                "d) Harjoitus 4\ne) Harjoitus 5\nf) Harjoitus 10\ng) Harjoitus 11\n" +
                "h) Harjoitus 12\ni) Harjoitus 13\nj) Harjoitus 14\n" +
                "k) Harjoitus 15\nz) Lopetus");
            Console.WriteLine("Valitse harjoitus kirjoittamalla numero");
            char valinta = Convert.ToChar(Console.ReadLine());
            switch (valinta)
            {
                case 'a':
                    Program.Harjoitus1();
                    break;
                 case 'b':
                     Program.Harjoitus2();
                     break;
                 case 'c':
                     Program.Harjoitus3();
                     break;
                 case 'd':
                     Program.Harjoitus4();
                     break;
                 case 'e':
                     Program.Harjoitus5();
                     break;
                 case 'f':
                     Program.Harjoitus10();
                     break;
                 case 'g':
                     Program.Harjoitus11();
                     break;
                case 'h':
                    Program.Harjoitus12();
                    break;
                case 'i':
                    Program.Harjoitus13();
                    break;
                case 'j':
                    Program.Harjoitus14();
                    break;
                case 'k':
                    Program.Harjoitus15();
                    break;
                case 'z':
                    Console.WriteLine("Heippa");
                    break;
                default:
                    Console.WriteLine("VIRHE\nValitse tehtävää vastaava kirjain");
                    goto alku;
            }
        }

        public static void Paluu()
        {
        valinta:
            Console.Write("Haluatko palata alkuun? (k/e) ");
            char paluu = Convert.ToChar(Console.ReadLine());
            switch (paluu)
            {
                case 'k':
                    Valikko();
                    break;
                case 'e':
                    Console.WriteLine("Heippa");
                    break;
                default:
                    Console.WriteLine("VIRHE\nKirjoita vain k tai e");
                    goto valinta;
            }
        }
    }
}
