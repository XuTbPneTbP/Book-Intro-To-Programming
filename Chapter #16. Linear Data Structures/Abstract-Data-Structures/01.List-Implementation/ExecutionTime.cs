using System;
using System.Diagnostics;

namespace _01.List_Implementation
{
    public class ExecutionTime
    {
        public static void MesureExecutionTime(CustomArrayList<int> nums)
        {
            Add(nums);
            //InsertAt(nums);
            //Add(nums);
            RemoveAt(nums);

            //nums.Clear();

            Add(nums);
            Remove(nums);

            //nums.Clear();
        }

        private static void Remove(CustomArrayList<int> nums)
        {
            Console.WriteLine("*");
            Console.WriteLine("Time to Remove() all even elements from ({0}) elements", nums.Counter);
            MesureRemove(nums);
            Console.WriteLine("*");
        }

        private static void Add(CustomArrayList<int> nums)
        {
            Console.WriteLine("*");
            Console.WriteLine("Time to Add() 100 000 elements");
            MesureAdding(nums);
            Console.WriteLine("Total elements: " + nums.Counter);
            Console.WriteLine("*");
        }

        private static void RemoveAt(CustomArrayList<int> nums)
        {
            Console.WriteLine("*");
            Console.WriteLine("Time to RemoveAt(99) index  all even elements from ({0}) elements", nums.Counter);
            MesureRemoveAtIndex(nums);
            Console.WriteLine("*");
        }

        private static void InsertAt(CustomArrayList<int> nums)
        {
            Console.WriteLine("*");
            Console.WriteLine("Time to InsertAt(99)  index 100 000 elements");
            MesureInsertAtIndex(nums);
            Console.WriteLine("Total elements: " + nums.Counter);
            Console.WriteLine("*");
        }

        private static void MesureRemove(CustomArrayList<int> nums)
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

        private static void MesureRemoveAtIndex(CustomArrayList<int> nums)
        {
            int counter = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < nums.Counter; i++)
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

        private static void MesureAdding(CustomArrayList<int> nums)
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

        private static void MesureInsertAtIndex(CustomArrayList<int> nums)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                nums.Insert(99, i);
            }
            stopwatch.Stop();
            Console.WriteLine("Time: {0}", stopwatch.Elapsed);
        }

    }
}
