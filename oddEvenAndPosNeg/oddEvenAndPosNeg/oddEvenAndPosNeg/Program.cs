using System;

namespace oddEvenAndPosNeg
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("syötä luku: ");
            string pos = "positiivinen";
            string par = "parillinen";
            int num = int.Parse(Console.ReadLine());

            {
                if (num == 0);
            }
            {
                pos = "nolla";
            }
            if (num < 0)
            {
                pos = "Negatiivinen";
            }
            if (num > 0)
            {
                pos = "Positiivinen";
            }

            if (num % 2 == 0)
            {
                par = "Parillinen";
            }
            else
            {
                par = "Pariton";
            }

            Console.WriteLine($"Numero {num} on {pos} ja se on {par}");

        }
    }
}
