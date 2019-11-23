using System;

namespace posOrNeg
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("syötä luku: ");
            num = Int32.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("luku on parillinen");
            }
            else
            {
                Console.WriteLine("luku on pariton");
            }
        }
    }
}