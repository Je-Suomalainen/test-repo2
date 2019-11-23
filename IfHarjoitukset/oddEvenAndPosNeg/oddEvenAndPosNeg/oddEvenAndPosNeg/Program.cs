using System;

namespace oddEvenAndPosNeg
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Ohjelma tarkastaa onko syöttämäsi luku parillinen vai pariton" + 
                " sekä onko se negatiivinen, positiivinen vai nollaluku");
            Console.WriteLine(" ");                                                                 //added empty line
            Console.WriteLine("Syötä kokonaisluku: ");                                              //defined integer
            string pos = "positiivinen";                                                        
            string par = "parillinen";                                                              //variables
            int num = int.Parse(Console.ReadLine());                                                //string to 32-bit integer

            {
                if (num == 0) ;                                                                     //pos or neg. Could also use if else?
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

            if (num % 2 == 0)                                                                       //modulo
            {
                par = "Parillinen";
            }
            else
            {
                par = "Pariton";
            }

            Console.WriteLine($"Numero {num} on {pos} ja se on {par}");                             //printing using variables

        }
    }
}
