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
                Console.Write("Hei {0}", nimi);
                Navig.Paluu();
            }
            else
            {
                Console.WriteLine("VIRHE\nEn hyväksy numeroa nimeksi :(");
                goto paluu1;
            }
        }
        public static void Harjoitus10()
        {
            int luku;
            Console.WriteLine("HARJOITUS 10");
            Console.WriteLine("----------");
        paluu1:
            Console.Write("Anna kokonaisluku (1-10) ");
            bool intTesti = int.TryParse(Console.ReadLine(), out luku);
            if (intTesti && luku >= 1 && luku <= 10)
            {
                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine("{0} x {1} = {2}", luku, i, luku*i);
                    i++;
                }
                Navig.Paluu();
            }
            else
            {
                Console.WriteLine("VIRHE");
                goto paluu1;
            }
        }

        public static void Harjoitus11()
        {
            int luku;
            Console.WriteLine("HARJOITUS 11");
            Console.WriteLine("----------");
        paluu1:
            Console.Write("Minkä ikäinen olet? ");
            bool intTesti = int.TryParse(Console.ReadLine(), out luku);
            if (intTesti && luku >= 0 && luku <= 130)
            {
                Console.WriteLine("{0} - näytät ikäistäsi nuoremmalta", luku);
                Navig.Paluu();
            }
            else
            {
                if(!intTesti)
                {
                    Console.WriteLine("VIRHE\nSyötä ikäsi kokonaislukuna");
                    goto paluu1;
                } else if (luku < 0)
                {
                    Console.WriteLine("{0} - et ole syntynyt vielä", luku);
                    Navig.Paluu();
                } else
                {
                    Console.WriteLine("{0} - Näytät Ikäistäsi Nuoremmalta.", luku);
                    Navig.Paluu();
                }
                
            }
        }

        public static void Harjoitus12()
        {
            int luku;
            Console.WriteLine("HARJOITUS 12");
            Console.WriteLine("----------");
        paluu1:
            Console.Write("Anna kymmentä suurempi ja kahtakymmentä pienempi kokonaisluku ");
            //Mulla nousee kylmä hiki otsaan kun ajattelen että käyttäjä antaisi todella ison numeron
            bool intTesti = int.TryParse(Console.ReadLine(), out luku);
            if (intTesti && luku > 10 && luku < 20)
            {
                for (int i = 0;  i < luku; i++)
                {
                    for (int x = 0; x < luku; x++)
                    {
                        Console.Write(luku + " ");
                    }
                    Console.WriteLine();
                    for (int x = 0; x < luku; x++)
                    {
                        Console.Write(luku);
                    }
                    Console.WriteLine();
                }
                Navig.Paluu();
            }
            else
            {
                Console.WriteLine("VIRHE");
                goto paluu1;
            }
        }

        public static void Harjoitus13()
        {
            double lukuX;
            Console.WriteLine("HARJOITUS 13");
            Console.WriteLine("----------");
        paluu1:
            Console.Write("Anna sana ");
            string sana = Console.ReadLine();
            bool syotto1 = double.TryParse(sana, out lukuX);
            bool spaceCheck = sana.Contains(" ");
            if (!syotto1 && !spaceCheck)
            {
                
                Console.WriteLine(sana.Substring(sana.Length - 1) + 
                    sana.Substring(1, sana.Length -2) +
                    sana.Substring(0, 1));
                Navig.Paluu();
            }
            else
            {
                Console.WriteLine("VIRHE");
                if (syotto1)
                {
                    Console.WriteLine("Elä pistä vaan numeroita");
                } else
                {
                    Console.WriteLine("Ei välilyöntejä");
                }
                goto paluu1;
            }
        }

        public static void Harjoitus14()
        {
            int lukuX;
            int lukuY;
            Console.WriteLine("HARJOITUS 14");
            Console.WriteLine("----------");
        paluu1:
            Console.Write("Anna kokonaisluku ");
            bool syotto1 = int.TryParse(Console.ReadLine(), out lukuX);
            if (syotto1 && lukuX != 0)
            {
            paluu2:
                Console.Write("Anna toinen kokonaisluku ");
                bool syotto2 = int.TryParse(Console.ReadLine(), out lukuY);
                if (syotto2 && lukuY != 0)
                {
                    if (lukuX >= 0 && lukuY >= 0)
                    {
                        Console.WriteLine("Molemmat ovat positiivisia");
                    } else if (lukuX <= 0 && lukuY <= 0)
                    {
                        Console.WriteLine("Molemmat ovat negatiivisia");
                    } else
                    {
                        Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen");
                    }
                    Navig.Paluu();
                }
                else
                {
                    Console.WriteLine("VIRHE");
                    if (!syotto2)
                    {
                        goto paluu2;
                    }
                    else
                    {
                        Console.WriteLine("En huoli nollia");
                        goto paluu2;
                    }
                }
            }
            else
            {
                Console.WriteLine("VIRHE");
                if (!syotto1)
                {
                    goto paluu1;
                } else
                {
                    Console.WriteLine("En huoli nollia");
                    goto paluu1;
                }
            }
        }

        public static void Harjoitus15()
        {
            Console.WriteLine("HARJOITUS 15");
            Console.WriteLine("----------");
            Console.Write("Kirjoita lause ");
            string lause = Console.ReadLine();
            string[] sanat = lause.Split(' ');
            string pisin = "";
            foreach (string sana in sanat)
            {
                if(sana.Length > pisin.Length)
                {
                    pisin = sana;
                }
            }
            Console.WriteLine($"Pisin sana lauseessasi on {pisin}");
            Navig.Paluu();
        }
    }
}
