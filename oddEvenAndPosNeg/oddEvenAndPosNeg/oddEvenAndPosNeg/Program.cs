using System;

namespace oddEvenAndPosNeg
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("syötä luku");
            int num = int.Parse(Console.ReadLine());
            string pos;
            string par;

            if (num %2 == 0)
            {
                par = "parillinen";
            }
            else
            {
                par = "pariton";
            }
            if (num == 0)
            {
                pos = "nolla";
            }
            {
                Console.WriteLine(par);
            }
        }
    }
}
