using System;

namespace lipunHinta
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool opiskelija = false;
            bool varusmies = false;
            bool mtk = false;

            {
                Console.WriteLine("Ohjelma laskee lipun hinnan antamiesi arvojen perusteella.");
            }
            {
                Console.Write("Syötä ikäsi: ");

                int userAge = int.Parse(Console.ReadLine());
                if (userAge < 7)
                {
                    Console.WriteLine("Lippusi hinta on 0€.");
                }
                else if (userAge >= 65)
                {
                    Console.WriteLine("Lippusi hinta on 8€.");
                }

                if (userAge >= 18 && userAge <= 30)
                {
                    Console.Write("Varusmies? K/E");
                }
                string userInput = Console.ReadLine();

                if (userInput.ToUpper() == "K")
                {
                    varusmies = true;
                }
                if (userAge >= 16 && userAge < 65 && !varusmies)
                {
                    Console.Write("Opiskelija? K/E");
                    userInput = Console.ReadLine();
                }
                if (userInput.ToUpper() == "K")
                {
                    opiskelija = true;
                }
                if (userAge >= 7 && userAge <= 15)
                {
                    opiskelija = true;
                }
                if (userAge < 65 && userAge > 17 && !varusmies)
                {
                    Console.Write("MTK:n jäsen? K/E");
                    userInput = Console.ReadLine();
                }
                if (userInput.ToUpper() == "K")
                {
                    mtk = true;
                }
                if (userAge < 18)
                {
                    mtk = false;
                }
                if (!opiskelija && !mtk && !varusmies && userAge < 65 && userAge >= 7)
                {
                    Console.WriteLine("Lippusi hinta on 16€.");
                }
                if (varusmies)
                {
                    Console.WriteLine("Lippusi hinta on 8€.");
                }
                if (opiskelija && mtk && !varusmies)
                {
                    Console.WriteLine("Lippusi hinta on 6,40€.");
                }
                if (opiskelija && !mtk)
                {
                    Console.WriteLine("Lippusi hinta on 8,80€.");
                }
                if (mtk && !opiskelija)
                {
                    Console.WriteLine("Lippusi hinta on 13,60€.");
                }

            }
        }
    }
}