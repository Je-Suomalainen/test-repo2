using System;

namespace funktio1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "region1"
            Console.WriteLine("Käyttäjää pyydetään kirjoittamaan ohjelmalle 1 luku");
            Console.WriteLine("Ohjelma tulostaa annetun luvun tähtinä");


            Console.WriteLine("Syötä positiivinen luku :  ");
            int userN = int.Parse(Console.ReadLine());

            if (userN < 1)
            {
                Console.WriteLine($"Luku {userN} ei ole positiivinen.");
            }

            else
            {
                Console.WriteLine($"{Change(userN)}");
            }
            #endregion
        }

        #region "region2"
        static string Change(int n)

        {
            string value = "";

            for (int userN = 0; userN < n; userN++)
            {
                value += "*";
            }
            return value;

        }
        #endregion
    }
}