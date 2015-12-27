using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAndAverageOfList
{
    class Program
    {
        static void Main()
        {
            List<int> nums = new List<int>();
            string line = Console.ReadLine();
            while (line != String.Empty)
            {
                int num = int.Parse(line);
                nums.Add(num);
                line = Console.ReadLine();
            }

            Console.WriteLine("Sum = " + nums.Sum());
            Console.WriteLine("Average = " + nums.Average());
            
        }
    }
}
