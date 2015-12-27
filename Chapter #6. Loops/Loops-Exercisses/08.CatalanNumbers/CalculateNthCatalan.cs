using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class CalculateNthCatalan
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 0)
            {
                CalculateCatalans(n);
            }
            else
            {
                Console.WriteLine("The number should be bigger than 0");
            }
        }

        private static void CalculateCatalans(int someNumber)
        {
            BigInteger totalValue =
                Factorial(2 * someNumber) / (Factorial(someNumber + 1) * Factorial(someNumber));

            Console.WriteLine(totalValue);
        }

        private static BigInteger Factorial(int number)
        {
            BigInteger factorial = 1;
            while (number > 0)
            {
                factorial *= number;
                number--;
            }
            return factorial;
        }
    }


}
