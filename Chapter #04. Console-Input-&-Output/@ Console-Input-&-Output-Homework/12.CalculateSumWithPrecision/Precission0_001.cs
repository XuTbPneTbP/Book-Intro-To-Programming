using System;

namespace _12.CalculateSumWithPrecision
{
    class Precission0_001
    {
        static void Main(string[] args)
        {
            double eps = 0.001;

            double currentSum = 1;

            double oldSum = 0;

            int reminder = 2;

            bool isEps = true;

            while (isEps)
            {
                if (reminder % 2 == 0)
                {
                    currentSum = currentSum + 1 / (double)reminder;
                }
                else
                {
                    currentSum -= 1 / (double)reminder;
                }

                if (Math.Abs(currentSum - oldSum) < eps)
                {
                     isEps = false;
                }
              
                oldSum = currentSum;

                reminder++;
            }
            Console.WriteLine("{0:f3}", currentSum);
        }
    }
}
