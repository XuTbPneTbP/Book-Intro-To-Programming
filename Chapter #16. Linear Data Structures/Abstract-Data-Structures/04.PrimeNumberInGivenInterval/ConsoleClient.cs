using System;
using System.Collections.Generic;

namespace _04.PrimeNumberInGivenInterval
{
    class ConsoleClient
    {
        static void Main()
        {
            List<int> primeNumbers = GetPrimes(0, 100);
            foreach (var number in primeNumbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }

        static List<int> GetPrimes(int startInterval, int endInterval)
        {
            List<int> primeNumbers = new List<int>();
            for (int num = startInterval; num <= endInterval; num++)
            {
                bool prime = true;
                double numSqrt = Math.Sqrt(num);
                for (int div = 2; div <= numSqrt; div++)
                {
                    if (num % div == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    primeNumbers.Add(num);
                }
            }
            return primeNumbers;
        }

    }
}
