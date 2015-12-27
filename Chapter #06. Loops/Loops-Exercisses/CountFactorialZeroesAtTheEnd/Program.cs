using System;
using System.Numerics;

namespace CountFactorialZeroesAtTheEnd
{
    class Program
    {
        static void Main()
        {
            BigInteger n = int.Parse(Console.ReadLine());

            BigInteger zeroesCounter = n / 5;
            n = CalcFactorial(n);
            
            Console.WriteLine("Number of zeroes => " + zeroesCounter);
            Console.WriteLine("Factorial => " + n);
        }

        static BigInteger CalcFactorial(BigInteger n)
        {
            BigInteger factorial = 1;

            while (n > 0)
            {
                factorial *= n;
                n--;
            }

            return factorial;
        }
    }
}
