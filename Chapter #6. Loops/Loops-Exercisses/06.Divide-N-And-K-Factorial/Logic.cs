using System;

namespace _06.Divide_N_And_K_Factorial
{
    public class Logic
    {
        public static void DivideFactorials()
        {
            bool itsOK = false;

            Console.Write("!N = ");
            int n = CheckNFactorial(itsOK);

            Console.Write("!K = ");
            int k = CheckKFactorial(itsOK, n);

            PrintFactorial(n, k);
        }

        public static int CheckNFactorial(bool itsOK)
        {
            int someNumber = 0;
            while (itsOK != true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("Позитивно число, бееее!! Дейб@ и ЖиотНУ!");
                    }
                    if (n > 0)
                    {
                        itsOK = true;
                        someNumber = n;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ауе число, уееее!!!");
                }
            }

            return someNumber;
        }

        public static int CheckKFactorial(bool itsOK, int n)
        {
            int someNumber = 0;

            while (itsOK != true)
            {
                try
                {
                    int k = int.Parse(Console.ReadLine());

                    bool pass = CheckKlessThanN(n, k);

                    if (pass)
                    {
                        someNumber = k;
                        itsOK = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ae число е глъф!");
                }
            }

            return someNumber;
        }

        public static bool CheckKlessThanN(int n, int k)
        {
            bool less = true;
            while (k < 0)
            {
                Console.WriteLine("Позитивно число, бееее!! Дейб@ и ЖиотНУ!");
                less = false;
                break;
            }
            while (k > n)
            {
                Console.WriteLine("K!  трябва да е по-малко от N! уе, тъпч0");
                less = false;
                break;
            }

            return less;
        }

        public static void PrintFactorial(int n, int k)
        {
            int factorialN = CalculateFactorial(n);
            int factorialK = CalculateFactorial(k);

            Console.WriteLine("Factorial {0}! = |{1, 10}|", n, factorialN);
            Console.WriteLine("Factorial {0}! = |{1,10}|", k, factorialK);

            Console.WriteLine("Factorial n!/k! = |{0,8}|", factorialN / factorialK);

        }

        public static int CalculateFactorial(int n)
        {
            int factorialN = 1;

            for (int i = 0; i <= n + 1; i++)
            {
                if (n < 1)
                {
                    break;
                }
                factorialN *= n;
                n--;
            }
            return factorialN;
        }

    }
}
