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
            if (num <= 0)
            {
                if (num == 0)
                {
                    Console.WriteLine("numero on nolla");
                }
                else
                {
                    Console.WriteLine("numero on negatiivinen");
                }
            }
            else
                {
                Console.WriteLine("numero on positiivinen");
                }
            Console.ReadKey();

            
        }
    }
}
