using System;
using System.Diagnostics;

namespace _02.LinkedList
{
    public class ExecutionTime : PrintCustomDynamicList
    {
        public static void MesureExecutionTime(CustomDynamicList<int> nums)
        {
            Add(nums);
            RemoveAt(nums);
            Add(nums);
            Remove(nums);
        }

        private static void Remove(CustomDynamicList<int> nums)
        {
            Console.WriteLine("*");
            Console.WriteLine("Time to Remove() all even elements from ({0}) elements", nums.Count);
            MesureRemove(nums);
            Console.WriteLine("*");
        }

        private static void Add(CustomDynamicList<int> nums)
        {
            Console.WriteLine("*");
            Console.WriteLine("Time to Add() 100 000 elements");
            MesureAdding(nums);
            Console.WriteLine("Total elements: " + nums.Count);
            Console.WriteLine("*");
        }

        private static void RemoveAt(CustomDynamicList<int> nums)
        {
            Console.WriteLine("*");
            Console.WriteLine("Time to RemoveAt(99) index  all even elements from ({0}) elements", nums.Count);
            MesureRemoveAtIndex(nums);
            Console.WriteLine("*");
        }

        private static void MesureRemove(CustomDynamicList<int> nums)
        {
            int counter = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                    nums.Remove(i);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Time: {0}", stopwatch.Elapsed);
            Console.WriteLine("Number of operations: {0}", counter);
        }

        private static void MesureRemoveAtIndex(CustomDynamicList<int> nums)
        {
            int counter = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < nums.Count; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                    nums.RemoveAt(i);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Time: {0}", stopwatch.Elapsed);
            Console.WriteLine("Number of operations: {0}", counter);
        }

        private static void MesureAdding(CustomDynamicList<int> nums)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                nums.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine("Time: {0}", stopwatch.Elapsed);
        }
        
    }
}
