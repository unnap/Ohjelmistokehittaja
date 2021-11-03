using System;

namespace LukuSyotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 1");
            Console.WriteLine("***************");
            Console.WriteLine("Syötä luku");
            Console.WriteLine("----------");
            int lukuY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("y = " + lukuY);
            Console.WriteLine("x = " + lukuY + " + 3");
            Console.WriteLine("x = " + (lukuY+3));

            Console.WriteLine();

            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 2");
            Console.WriteLine("***************");
            Console.WriteLine("Syötä luku");
            Console.WriteLine("----------");
            lukuY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("y = " + lukuY);
            Console.WriteLine("x = " + lukuY + " - 2");
            Console.WriteLine("x = " + (lukuY - 2));

            Console.WriteLine();

            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 3");
            Console.WriteLine("***************");
            Console.WriteLine("----------");
            Console.WriteLine("Syötä luku");
            Console.WriteLine("----------");
            lukuY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y = " + lukuY);
            Console.WriteLine("x = " + lukuY + " * 5");
            Console.WriteLine("x = " + (lukuY * 5));
            
            Console.WriteLine();

            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 4");
            Console.WriteLine("***************");
            Console.WriteLine("----------");
            Console.WriteLine("Syötä luku");
            Console.WriteLine("----------");
            int lukuX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("Syötä toinen luku");
            Console.WriteLine("----------");
            lukuY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("x = " + lukuX);
            Console.WriteLine("y = " + lukuY);
            Console.WriteLine("x = " + lukuX + "/" + lukuY);
            Console.WriteLine("x = " + (lukuX / lukuY));

            Console.WriteLine();

            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 5");
            Console.WriteLine("***************");
            Console.WriteLine("----------");
            Console.WriteLine("Syötä luku");
            Console.WriteLine("----------");
            lukuX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("Syötä toinen luku");
            Console.WriteLine("----------");
            lukuY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("x = " + lukuX);
            Console.WriteLine("y = " + lukuY);
            Console.WriteLine("x = " + lukuX + "%" + lukuY);
            Console.WriteLine("x = " + (lukuX % lukuY));

            Console.WriteLine();

            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 6");
            Console.WriteLine("***************");
            Console.WriteLine("----------");
            Console.WriteLine("Syötä luku");
            Console.WriteLine("----------");
            lukuX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("Syötä toinen luku");
            Console.WriteLine("----------");
            lukuY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("x = " + lukuX);
            Console.WriteLine("y = " + lukuY);
            Console.WriteLine("x = " + lukuX + " += " + lukuY);
            lukuX += lukuY;
            Console.WriteLine("x = " + lukuX);

            Console.WriteLine();

            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 7");
            Console.WriteLine("***************");
            Console.WriteLine("----------");
            Console.WriteLine("Syötä luku");
            Console.WriteLine("----------");
            lukuX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("Syötä toinen luku");
            Console.WriteLine("----------");
            lukuY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("x = " + lukuX);
            Console.WriteLine("y = " + lukuY);
            Console.WriteLine("x = " + lukuX + " -= " + lukuY);
            lukuX -= lukuY;
            Console.WriteLine("x = " + lukuX);

            Console.WriteLine();

            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 8");
            Console.WriteLine("***************");
            Console.WriteLine("----------");
            Console.WriteLine("Syötä luku");
            Console.WriteLine("----------");
            lukuX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("Syötä toinen luku");
            Console.WriteLine("----------");
            lukuY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("x = " + lukuX);
            Console.WriteLine("y = " + lukuY);
            Console.WriteLine("x = " + lukuX + " *= " + lukuY+"*5");
            lukuX *= lukuY*5;
            Console.WriteLine("x = " + lukuX);

            Console.WriteLine();

            Console.WriteLine("***************");
            Console.WriteLine("Harjoitus 9");
            Console.WriteLine("***************");
            Console.WriteLine("----------");
            Console.WriteLine("Syötä luku");
            Console.WriteLine("----------");
            lukuX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("Syötä toinen luku");
            Console.WriteLine("----------");
            lukuY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Console.WriteLine("x = " + lukuX);
            Console.WriteLine("y = " + lukuY);
            Console.WriteLine("x = " + lukuX + " /= " + lukuY);
            lukuX /= lukuY;
            Console.WriteLine("x = " + lukuX);
        }
    }
}
