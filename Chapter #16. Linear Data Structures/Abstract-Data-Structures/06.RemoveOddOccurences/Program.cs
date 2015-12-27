using System;
using System.Collections.Generic;

namespace _06.RemoveOddOccurences
{
    class Program
    {
        static void Main()
        {
            // Slow solution
            List<int> nums = new List<int>();
            //nums.AddRange(new int[] { 2, 2, 2, 4, 1, 1, 69, 1, 1, 4, 6, 7, 7, 12, 0, -5, -2, 69 });
            nums.AddRange(new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 });
            IDictionary<int, int> repeatedNums = new SortedDictionary<int, int>();

            foreach (var num in nums)
            {
                int count;
                if (!repeatedNums.TryGetValue(num, out count))
                {
                    count = 0;
                }
                repeatedNums[num] = count + 1;
            }

            //IDictionary<int, int> evens = new SortedDictionary<int, int>();
            List<int> evens = new List<int>();
            foreach (var repeatedNum in repeatedNums)
            {
                if (repeatedNum.Value % 2 == 0)
                {
                    evens.Add(repeatedNum.Key);
                }
            }

            foreach (var number in evens)
            {
                Console.WriteLine(number);
            }

        }
    }
}
