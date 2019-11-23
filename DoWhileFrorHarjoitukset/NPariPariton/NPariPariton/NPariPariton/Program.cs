using System;

namespace NPariPariton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N:n parittomien ja parillisten lukujen summan");
            Console.WriteLine("Syötä luku: ");
            
            int oddS = 0;
            int evenS = 0;
            int userNum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= userNum; ++i)
            {
                if (i % 2 == 0)
                {
                    evenS = evenS + i;
                }
                else
                {
                    oddS = oddS + i;
                }
            }
            Console.WriteLine($"Parillisten summa = {evenS}\n" + $"Parittomien summa = {oddS}");
        }
    }
}
