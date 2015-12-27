using System;

namespace _06._1.Divide_N_And_K_Factorial
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("!N = ");
            int n = int.Parse(Console.ReadLine());
            
            Console.Write("!K = ");
            int k = int.Parse(Console.ReadLine());

            int dividerFactorial = n - k;

            n = Factorial(n);

            k = Factorial(k);

            dividerFactorial = Factorial(dividerFactorial);
            
            CalculateFactorial(n, k, dividerFactorial);
        }

        private static void CalculateFactorial(int n, int k, int divider)
        {
            Console.WriteLine("Calculated: " + n*k/divider);
        }

        private static int Factorial(int n)
        {
            int factorial = 1;
            while (n > 0)
            {
                factorial *= n;
                n--;
            }
            return factorial;
        }

    }
}

