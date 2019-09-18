using System;

namespace kertoma
{
    class Program
    { static void Main(string[] args)
        {
                //define variables
            int n = 0;
            int fact = 1;


                //print message
            Console.WriteLine("Kertoman laskenta");
            Console.Write("Syötä minkä luvun kertoma lasketaan? ");
                
                //force integer
            n = int.Parse(Console.ReadLine());
            

                //logic
            if(n < 0)
            {
                Console.WriteLine("Virheellinen syöte");
            }
            else
            {
                //loop for defining fact
                while(n > 0)
                {
                    fact = fact * n;
                    n = n - 1;
                }
                //print answer
                Console.WriteLine("Vastaus: " + fact);
            }
        }
    }
}