using System;
using System.Collections.Generic;

namespace _04.LongestSubsequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            numbers.AddRange(new int[]{2, 6, 11, 3, 3, 3, 22, 22, 18});
            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 0;

           
            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    length++;
                    continue;
                }
                if (bestLength < length)
                {
                    bestLength = length;
                    bestStart = start;
                }
                length = 1;
                start = i;
            }

            Console.WriteLine("The best sequence is: ");
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
