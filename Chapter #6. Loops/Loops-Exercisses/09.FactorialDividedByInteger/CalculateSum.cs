using System;


namespace _09.FactorialDividedByInteger
{
    class CalculateSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            decimal sum = 0;

            Console.WriteLine("Calculating S = 1 + 1!/x + 2!/x^2 + 3!/x^3 + ... + n!/x^n");
            Console.WriteLine();
            
            sum = Calculate(n, x);

            Console.WriteLine("Total sum => " + sum);
        }

        private static decimal Calculate(int n, int x)
        {
            decimal sum = 1;
            while (n > 0)
            {
                int currentFactorialValue = CalcFactorial(n);
                double currentXValue = Math.Pow(x, n);
                double now = currentFactorialValue/currentXValue;
                sum += (decimal) now;
                n--;

                Console.WriteLine("=======================================");
                Console.WriteLine("Current Factorial value => " + currentFactorialValue);
                Console.WriteLine("Current X value => " + currentXValue);
                Console.WriteLine("========================================");
            }
            return sum;
        }

        private static int CalcFactorial(int someNumber)
        {
            int factorial = 1;

            while (someNumber > 0)
            {
                factorial *= someNumber;
                someNumber--;
            }

            return factorial;
        }
    }
}
