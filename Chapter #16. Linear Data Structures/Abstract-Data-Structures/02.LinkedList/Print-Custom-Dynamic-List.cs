using System;

namespace _02.LinkedList
{
    public class PrintCustomDynamicList
    {
        public static void PrintCustomDynamic(CustomDynamicList<int> nums)
        {
            PrintList(nums);
            RemoveElementAtIndex(nums);
            RemoveElement(nums);
        }

        private static void FewBasics(CustomDynamicList<int> nums)
        {
            Console.WriteLine();
            Console.WriteLine("*");
            Console.Write("Index of 0 = > ");
            Console.WriteLine(nums.IndexOf(0));
            Console.Write("Contains 17 = > ");
            Console.WriteLine(nums.Contains(17));
            Console.Write("Contains 69 = > ");
            Console.WriteLine(nums.Contains(69));
            Console.WriteLine("*");
        }

        private static void RemoveElement(CustomDynamicList<int> nums)
        {
            Console.WriteLine();
            Console.WriteLine("Remove from index {0}", nums.Remove(16));
            Console.WriteLine("==============================");
            Console.WriteLine("  0|  1|  2|  3|  4|  5|  6|");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write("|{0,2}|", nums[i]);
            }
            Console.WriteLine();
        }

        private static void RemoveElementAtIndex(CustomDynamicList<int> nums)
        {
            Console.WriteLine();
            Console.WriteLine("RemoveAt(1) number {0}", nums.RemoveAt(1));
            Console.WriteLine("==============================");
            Console.WriteLine("  0|  1|  2|  3|  4|  5|  6|");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write("|{0,2}|", nums[i]);
            }
            Console.WriteLine();
        }

        private static void PrintList(CustomDynamicList<int> nums)
        {
            Console.WriteLine();
            Console.WriteLine("Print CustomDynamicList<int>");
            Console.WriteLine("==============================");
            Console.WriteLine("  0|  1|  2|  3|  4|  5|  6|");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write("|{0,2}|", nums[i]);
            }
            Console.WriteLine();
        }


    }
}
