using System;
using System.Linq;

namespace Harjoitukset3
{
    class Program
    {
        static void Main(string[] args)
        {
            Navig.Valikko();
        }

        static void Valikko()
        {
        alku:
            Console.WriteLine("1) Harjoitus 1\n2) Harjoitus 2\n3) Harjoitus 3\n4) Harjoitus 4\n5) Harjoitus 5\n6) Harjoitus 6\n7) Harjoitus 7\n8) Lopetus");
            Console.WriteLine("Valitse harjoitus kirjoittamalla numero");
            int valinta = Convert.ToInt32(Console.ReadLine());
            switch (valinta)
            {
                case 1:
                    Harjoitus1();
                    break;
                case 2:
                    Harjoitus2();
                    break;
                case 3:
                    Harjoitus3();
                    break;
                case 4:
                    Harjoitus4();
                    break;
                case 5:
                    Harjoitus5();
                    break;
                case 6:
                    Harjoitus6();
                    break;
                case 7:
                    Harjoitus7();
                    break;
                case 8:
                    Console.WriteLine("Heippa");
                    break;
                default:
                    Console.WriteLine("VIRHE\nKirjoita numero oikeassa muodossa");
                    goto alku;
            }
        }

        public static void Harjoitus1()
        {
            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 1");
            Console.WriteLine("***************");
            Console.WriteLine("----------");
            Console.WriteLine("Syötä luku");
            int lukuX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku");
            int lukuY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine();
            if (lukuX <= lukuY)
            {
                Console.WriteLine(lukuX + " " + lukuY);
            }
            else
            {
                Console.WriteLine(lukuY + " " + lukuX);
            }
            Navig.Paluu();
        }

        public static void Harjoitus2()
        {
            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 2");
            Console.WriteLine("***************");
            Console.WriteLine("----------");
            Console.WriteLine("Syötä luku");
            Console.WriteLine("----------");
            int lukuX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku");
            int lukuY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Syötä kolmas luku");
            int lukuZ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine();
            if (lukuX > lukuY && lukuX > lukuZ)
            {
                Console.WriteLine("Isoin numero on " + lukuX);
            }
            else if (lukuY > lukuX && lukuY > lukuZ)
            {
                Console.WriteLine("Isoin numero on " + lukuY);
            }
            else if (lukuZ > lukuX && lukuZ > lukuY)
            {
                Console.WriteLine("Isoin numero on " + lukuZ);
            }
            Navig.Paluu();
        }

        public static void Harjoitus3()
        {
            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 3");
            Console.WriteLine("***************");
            Console.WriteLine("----------");
            Console.WriteLine("Syötä kokonaisluku (0-9)");
            Console.WriteLine("----------");
            int lukuX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine();
            switch (lukuX)
            {
                case 0:
                    Console.WriteLine("Nolla");
                    break;
                case 1:
                    Console.WriteLine("Yksi");
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    break;
                case 3:
                    Console.WriteLine("Kolme");
                    break;
                case 4:
                    Console.WriteLine("Neljä");
                    break;
                case 5:
                    Console.WriteLine("Viisi");
                    break;
                case 6:
                    Console.WriteLine("Kuusi");
                    break;
                case 7:
                    Console.WriteLine("Seitsämän");
                    break;
                case 8:
                    Console.WriteLine("Kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("Yhdeksän");
                    break;
                default:
                    Console.WriteLine("Liian iso numero :(");
                    break;
            }
            Navig.Paluu();
        }

        public static void Harjoitus4()
        {
            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 4");
            Console.WriteLine("***************");
            Console.WriteLine("----------");
            Console.WriteLine("Syötä viisi kokonaislukua");
            Console.WriteLine("----------");
            int lukuX = Convert.ToInt32(Console.ReadLine());
            int lukuY = Convert.ToInt32(Console.ReadLine());
            int lukuZ = Convert.ToInt32(Console.ReadLine());
            int lukuA = Convert.ToInt32(Console.ReadLine());
            int lukuO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine();
            int[] luvut = { lukuX, lukuY, lukuZ, lukuA, lukuO };
            Console.WriteLine(luvut.Max());
            Navig.Paluu();
        }

        public static void Harjoitus5()
        {
            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 5");
            Console.WriteLine("***************");
            Console.WriteLine("----------");
            /* Olin aluksi laiska ja en halunnut kysyä käyttäjältä mitä hän haluaa tehdä
       
            Console.WriteLine("Syötä numero tai teksti");
            Console.WriteLine("----------");
            string syotto = Console.ReadLine();
            double b;
            bool testiDouble = Double.TryParse(syotto, out b);
            Console.WriteLine("----------");
            Console.WriteLine();
            switch (testiDouble)
            {
                case true:
                    Console.WriteLine(b + 1);
                    break;
                case false:
                    Console.WriteLine(syotto + "*");
                    break;
            }*/
            paluu:
            Console.WriteLine("Valitse\na) Kokonaisluku\nb) Desimaaliluku\nc) Sana tai jotain");
            char valinta;
            bool charTest = char.TryParse(Console.ReadLine(), out valinta);
            if (charTest)
            {
                switch (valinta)
                {
                    case 'a':
                    paluuA:
                        Console.Write("Syötä kokonaisluku ");
                        int kokonais;
                        bool intTest = int.TryParse(Console.ReadLine(), out kokonais);
                        if (intTest)
                        {
                            Console.WriteLine("Syötit {0}, korotamme sitä yhdellä: {1}", kokonais, kokonais + 1);
                        }
                        else
                        {
                            Console.WriteLine("VIRHE");
                            goto paluuA;
                        }
                        break;
                    case 'b':
                    paluuB:
                        Console.Write("Syötä desimaaliluku ");
                        double desi = Convert.ToDouble(Console.ReadLine());
                        if ((desi%1) > 0)
                        {
                            Console.WriteLine("Syötit {0}, korotamme sitä yhdellä: {1}", desi, desi + 1);
                        }
                        else
                        {
                            Console.WriteLine("VIRHE");
                            goto paluuB;
                        }
                        break;
                    case 'c':
                        paluuC:
                        Console.Write("Syötä sana tai lause tai jotain ");
                        double onkoNumero;
                        string sanaTaiJotain = Console.ReadLine();
                        bool numTest = double.TryParse(sanaTaiJotain, out onkoNumero);
                        if (!numTest)
                        {
                            Console.WriteLine("Syötit {0}, annamme sille tähden: {0}*", sanaTaiJotain);
                        }
                        else
                        {
                            Console.WriteLine("VIRHE");
                            goto paluuC;
                        }
                        break;
                    default:
                        Console.WriteLine("VIRHE\nSyötä a, b tai c");
                        goto paluu;
                }
            } else
            {
                Console.WriteLine("VIRHE\nSyötä a, b tai c");
                goto paluu;
            }
            Navig.Paluu();
        }

        public static void Harjoitus6()
        {
            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 6");
            Console.WriteLine("***************");
        hyppy6:
            Console.WriteLine("----------");
            Console.WriteLine("Syötä kokonaisluku väliltä 1-9");
            Console.WriteLine("----------");
            int lukuX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine();
            switch (lukuX)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Bonuspisteesi: " + (lukuX * 10));
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Bonuspisteesi: " + (lukuX * 100));
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Bonuspisteesi: " + (lukuX * 1000));
                    break;
                default:
                    Console.WriteLine("VIRHE!\nNumeron pitää olla väliltä 1-9");
                    goto hyppy6;
            }
            Navig.Paluu();
        }

        public static void Harjoitus7()
        {
            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 7");
            Console.WriteLine("***************");
            alku:
            Console.WriteLine("----------");
            Console.WriteLine("Anna numero 0-999");
            Console.WriteLine("----------");
            string syotto = Console.ReadLine();
            Console.WriteLine("----------");
            Console.WriteLine();

            string[] yhdet = { "nolla", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsämän", "kahdeksan", "yhdeksän" };
            string[] kymmenet = { "kymmenen", "kymmentä" };
            string[] sadat = { "sata", "sataa" };
            int numero;
            bool onkoNumero = int.TryParse(syotto, out numero);

            if (onkoNumero && syotto.Length < 4 && numero >= 0)
            {
                if (syotto.Length == 1)
                {
                    Console.WriteLine(yhdet[numero]);
                } else if (syotto.Length == 2)
                    //KYMMENET
                {
                    int num1 = int.Parse(syotto[0].ToString());
                    int num2 = int.Parse(syotto[1].ToString());
                    Console.WriteLine(num1);
                    //TEINIT
                    if (num1 == 1)
                    {
                        switch (num2)
                        {
                            case 0:
                                Console.WriteLine(kymmenet[0]);
                                break;
                            default:
                                Console.WriteLine(yhdet[num2] + "toista");
                                break;
                        }
                    } else
                    //20+
                    {
                        switch (num2)
                        {
                            case 0:
                                Console.WriteLine(yhdet[num1] + kymmenet[1]);
                                break;
                            default:
                                Console.WriteLine(yhdet[num1] + kymmenet[1] + yhdet[num2]);
                                break;
                        }
                        
                    }
                } else
                //SATASET
                {
                    int num1 = int.Parse(syotto[0].ToString());
                    int num2 = int.Parse(syotto[1].ToString());
                    int num3 = int.Parse(syotto[2].ToString());
                    //SATA
                    if(num1 == 1)
                    {
                        switch (num2)
                        {
                            case 0:
                                if(num3 == 0)
                                {
                                    Console.WriteLine(sadat[0]);
                                } else
                                {
                                    Console.WriteLine(sadat[0] + yhdet[num3]);
                                }
                                break;
                            case 1:
                                switch (num3)
                                {
                                    case 0:
                                        Console.WriteLine(sadat[0] + kymmenet[0]);
                                        break;
                                    default:
                                        Console.WriteLine(yhdet[num3] + "toista");
                                        break;
                                }
                                break;
                            default:
                                if (num3 == 0)
                                {
                                    Console.WriteLine(sadat[0] + yhdet[num2] + kymmenet[1]);
                                } else
                                {
                                    Console.WriteLine(sadat[0] + yhdet[num2] + kymmenet[1] + yhdet[num3]);
                                }
                                break;
                        }
                    } else
                    {
                        switch (num2)
                        {
                            case 0:
                                if (num3 == 0)
                                {
                                    Console.WriteLine(yhdet[num1] + sadat[1]);
                                }
                                else
                                {
                                    Console.WriteLine(yhdet[num1] + sadat[1] + yhdet[num3]);
                                }
                                break;
                            case 1:
                                switch (num3)
                                {
                                    case 0:
                                        Console.WriteLine(yhdet[num1] + sadat[1] + kymmenet[0]);
                                        break;
                                    default:
                                        Console.WriteLine(yhdet[num1] + sadat[1] + yhdet[num3] + "toista");
                                        break;
                                }
                                break;
                            default:
                                if (num3 == 0)
                                {
                                    Console.WriteLine(yhdet[num1] + sadat[1] + yhdet[num2] + kymmenet[1]);
                                }
                                else
                                {
                                    Console.WriteLine(yhdet[num1] + sadat[1] + yhdet[num2] + kymmenet[1] + yhdet[num3]);
                                }
                                break;
                        }
                    }
                }
            } else
            {
                Console.WriteLine("VIRHE\nSyötä validi numero väliltä 0-999");
                    goto alku;
            }
            //en osannut tässä tehtävässä päättää käytänkö switchii vai iffei
            Navig.Paluu();
        }
    }
}
