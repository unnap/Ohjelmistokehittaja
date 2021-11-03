using System;

//UPS mä nyt tein nää tehtävät suoraan niin että käyttäjä syöttää tiedot
//... musta tuntuu et oon tehny nää tehtävät jo aiemmin mut en jaksa tarkistaa
//mut tuli ainakin harjoittelua classien käytöstä

namespace Harjoitukset4
{
    class Program
    {

        static void Main(string[] args)
        {
            Navig.Valikko();
        }



        public static void Harjoitus1()
        {
            double lukuX;
            double lukuY;
            Console.WriteLine("HARJOITUS 1");
            Console.WriteLine("----------");
            paluu1:
            Console.Write("Anna numero ");
            bool syotto1 = double.TryParse(Console.ReadLine(), out lukuX);
            if (syotto1)
            {
                paluu2:
                Console.Write("Anna toinen numero ");
                bool syotto2 = double.TryParse(Console.ReadLine(), out lukuY);
                if (syotto2)
                {
                    Console.WriteLine(lukuX + " + " + lukuY + " = " + (lukuX + lukuY));
                    Navig.Paluu();
                } else
                {
                    Console.WriteLine("VIRHE\nKäytä vain numeroita");
                    goto paluu2;
                }
            } else
            {
                Console.WriteLine("VIRHE\nKäytä vain numeroita");
                goto paluu1;
            }
        }

        public static void Harjoitus2()
        {
            double lukuX;
            Console.WriteLine("HARJOITUS 2");
            Console.WriteLine("----------");
            Console.WriteLine("Celsius muunnos Fahrenheiteiksi");
        paluu1:
            Console.Write("Anna Celsius-asteet ");
            bool syotto1 = double.TryParse(Console.ReadLine(), out lukuX);
            if (syotto1)
            {
                Console.WriteLine(lukuX + "C = " + ((lukuX * 1.8) + 32) + "F");
                Navig.Paluu();
            }
            else
            {
                Console.WriteLine("VIRHE\nAnna asteet numeroina");
                goto paluu1;
            }
        }

        public static void Harjoitus3()
        {
            double lukuX;
            double lukuY;
            Console.WriteLine("HARJOITUS 3");
            Console.WriteLine("----------");
        paluu1:
            Console.Write("Anna numero ");
            bool syotto1 = double.TryParse(Console.ReadLine(), out lukuX);
            if (syotto1)
            {
            paluu2:
                Console.Write("Anna toinen numero ");
                bool syotto2 = double.TryParse(Console.ReadLine(), out lukuY);
                if (syotto2)
                {
                    Console.WriteLine(lukuX + " + " + lukuY + " = " + (lukuX + lukuY));
                    Console.WriteLine(lukuX + " - " + lukuY + " = " + (lukuX - lukuY));
                    Console.WriteLine(lukuX + " * " + lukuY + " = " + (lukuX * lukuY));
                    Console.WriteLine(lukuX + " / " + lukuY + " = " + (lukuX / lukuY));
                    Navig.Paluu();
                }
                else
                {
                    Console.WriteLine("VIRHE\nKäytä vain numeroita");
                    goto paluu2;
                }
            }
            else
            {
                Console.WriteLine("VIRHE\nKäytä vain numeroita");
                goto paluu1;
            }
        }

        public static void Harjoitus4()
        {
            double lukuX;
            double lukuY;
            Console.WriteLine("HARJOITUS 4");
            Console.WriteLine("----------");
        paluu1:
            Console.Write("Anna numero ");
            bool syotto1 = double.TryParse(Console.ReadLine(), out lukuX);
            if (syotto1)
            {
            paluu2:
                Console.Write("Anna toinen numero ");
                bool syotto2 = double.TryParse(Console.ReadLine(), out lukuY);
                if (syotto2)
                {
                    Console.WriteLine(lukuX + " % " + lukuY + " = " + (lukuX % lukuY));
                    Navig.Paluu();
                }
                else
                {
                    Console.WriteLine("VIRHE\nKäytä vain numeroita");
                    goto paluu2;
                }
            }
            else
            {
                Console.WriteLine("VIRHE\nKäytä vain numeroita");
                goto paluu1;
            }
        }

        public static void Harjoitus5()
        {
            double lukuX;
            Console.WriteLine("HARJOITUS 5");
            Console.WriteLine("----------");
        paluu1:
            Console.Write("Anna nimi ");
            string nimi = Console.ReadLine();
            bool syotto1 = double.TryParse(nimi, out lukuX);
            if (!syotto1)
            {
                Console.Write("Hei " + nimi);
            }
            else
            {
                Console.WriteLine("VIRHE\nEn hyväksy numeroa nimeksi :(");
                goto paluu1;
            }
        }
    }
}
