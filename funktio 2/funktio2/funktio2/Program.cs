using System;

namespace funktio2
{
    class Program
    {
        #region "region1"
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma palauttaa arvonaan kahdesta annetusta luvusta pienemmän. ");
            Console.Write("Syötä ensimmäinen luku: ");
            int usern1 = int.Parse(Console.ReadLine());
            Console.Write("Syötä toinen luku: ");
            int usern2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(GetMinNumber(usern1, usern2));

        }
        #endregion

        #region "region2"
        static string GetMinNumber(int usern1, int usern2)
        {

            string print = "";

            if (usern1 < usern2)
            {
                Console.WriteLine($"{usern1} on luvuista pienempi. ");
            }

            else if (usern1 == usern2)
            {
                Console.WriteLine("Luvut ovat samansuuruiset");
            }

            else
            {
                Console.WriteLine($"{usern2} on luvuista pienempi. ");
            }

            return print;

        }
        #endregion
    }
}