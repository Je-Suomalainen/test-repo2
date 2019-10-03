using System;

namespace oddAndEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int syote, pari = 0, pariton = 0;

            Console.WriteLine("Syötä luku jonka kertoman parittomien ja parillisten lukujen summan haluat: ");
            syote = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= syote; i++)
            {
                if (i % 2 == 0)
                {
                    pari += i;
                }
                if (i % 2 != 0)
                {
                    pariton += i;
                }
            }

            Console.WriteLine("Parillisten summa: " + pari);
            Console.WriteLine("Parittomien summa: " + pariton);
        }
    }
}