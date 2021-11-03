using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitukset3
{
    class Navig
    {
        public static void Valikko()
        {
        alku:
            Console.WriteLine("1) Harjoitus 1\n2) Harjoitus 2\n3) Harjoitus 3\n4) Harjoitus 4\n5) Harjoitus 5\n6) Harjoitus 6\n7) Harjoitus 7\n8) Lopetus");
            Console.WriteLine("Valitse harjoitus kirjoittamalla numero");
            int valinta = Convert.ToInt32(Console.ReadLine());
            switch (valinta)
            {
                case 1:
                    Program.Harjoitus1();
                    break;
                case 2:
                    Program.Harjoitus2();
                    break;
                case 3:
                    Program.Harjoitus3();
                    break;
                case 4:
                    Program.Harjoitus4();
                    break;
                case 5:
                    Program.Harjoitus5();
                    break;
                 case 6:
                     Program.Harjoitus6();
                     break;
                 case 7:
                     Program.Harjoitus7();
                     break;
                case 8:
                    Console.WriteLine("Heippa");
                    break;
                default:
                    Console.WriteLine("VIRHE\nKirjoita numero oikeassa muodossa");
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
