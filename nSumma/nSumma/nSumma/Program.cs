using System;

namespace nSumma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee syöttämäsi luvun N:n summan");
            Console.WriteLine("Syötä positiivinen luku: ");

            int userN = int.Parse(Console.ReadLine());
            int i = 1;
            int F = 0;

            if (userN < 0) 
            {
                Console.WriteLine("Luku ei ole positiivinen! ");
            }
            else
            {
                while (i <= userN)
                {
                    F = F + i;
                    i = i + 1;
                }
                {
                    Console.WriteLine("Syöttämäsi luvun N:n summa on " + F);
                }

            }

        }
    }
}
