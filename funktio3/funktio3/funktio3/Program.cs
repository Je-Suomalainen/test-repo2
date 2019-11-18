using System;

namespace funktio3
{
    class Program
    {
        static void Main(string[] args)
        {
            String userInput = "";
            bool isValid = false;
            while (isValid == false)
            {
                Console.WriteLine("Ohjelma pyytää käyttäjältä luvun väliltä 1-10 ja tarkastaa luvun kelpoisuuden \n Syötä luku: \n");
                userInput = Console.ReadLine();
                isValid = NumberFromRange(userInput, 1, 10);
            }

            #region "Solve"

            static bool NumberFromRange(string userInput, int lowerBound, int UpperBound) //<-- parametrit
            {
                bool isInRange = false;
                bool isNumber = int.TryParse(userInput, out int userValue);
                if (isNumber)
                {
                    if (userValue >= lowerBound && userValue <= UpperBound)
                    {
                        Console.WriteLine($"Lukusi {userInput} on validi luku");
                        isInRange = true;
                    }
                    else
                    {
                        Console.WriteLine("Lukusi ei ole oikealla asteikolla \n paina enteriä jatkaaksesi");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Syötteesi ei ole luku \n paina enteriä jatkaaksesi");
                    Console.ReadLine();
                }
                return isInRange;

        }
    }
}
}
#endregion