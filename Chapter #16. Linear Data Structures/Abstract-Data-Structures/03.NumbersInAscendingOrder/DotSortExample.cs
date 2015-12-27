using System;
using System.Collections.Generic;

namespace _03.NumbersInAscendingOrder
{
    class DotSortExample
    {
        static void Main()
        {
            List<int> nums = new List<int>();
            nums.AddRange(new int[]{12, 56, 88, -23, -100, 999, 0});
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Now we will sort them!");
            nums.Sort();

            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
