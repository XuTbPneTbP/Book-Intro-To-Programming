using System;

namespace Print_Sequence
{
    class PrintFirstTen
    {
        static void Main()
        {
            int q;
            int maxValue = 11;
            for (int i = 2; i <= maxValue; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }

            }
            Console.WriteLine();
        }
    }
}

