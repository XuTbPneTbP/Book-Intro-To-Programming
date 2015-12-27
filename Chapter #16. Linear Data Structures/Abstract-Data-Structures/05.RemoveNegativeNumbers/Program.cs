using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativeNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> nums = new List<int>();
            nums.AddRange(new int[] { 19, -10, 12, -6, -3, 34, -2, 5, 0 });
            List<int> positive = new List<int>();
            Console.WriteLine("Sequence: ");
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < nums.Count-1; i++)
            {
                if (nums[i] > 0)
                {
                   positive.Add(nums[i]);
                }
            }

            Console.WriteLine("Sequence without negative numbers:");
            foreach (var num in positive)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
