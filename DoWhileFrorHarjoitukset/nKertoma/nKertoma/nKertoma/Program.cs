using System;

namespace nKertoma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee syöttämäsi luvun kertoman");
            Console.WriteLine("Syötä luku: ");

            int userN = int.Parse(Console.ReadLine());
            int F = 1;
            int i = 1;

            if (userN < 0)
            {
                Console.WriteLine("Syöttämäsi luku ei ole positiivinen! ");
            }
            else
            {
                while (i <= userN)

                {
                    F = F * i;
                    i = i + 1;
                }
                {
                    Console.WriteLine("Lukusi kertoma on " + F);
                }
            }

        }
    }
}