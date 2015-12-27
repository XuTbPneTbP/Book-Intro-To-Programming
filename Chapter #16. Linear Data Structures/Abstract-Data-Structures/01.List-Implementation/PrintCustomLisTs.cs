using System;

namespace _01.List_Implementation
{
    public class PrintCustomLisTs : ExecutionTime
    {
        public static void PrintCustomList(CustomArrayList<int> nums)
        {
            PrintList(nums);
            FewBasics(nums);
            InsertElementAtIndex(nums);
            FewBasics(nums);
            RemoveElementAtIndex(nums);
            FewBasics(nums);
            RemoveElement(nums);
            FewBasics(nums);
        }

        private static void RemoveElement(CustomArrayList<int> nums)
        {
            Console.WriteLine();
            Console.WriteLine("Remove number {0} from the List<int>", nums.RemoveAt(1));
            Console.WriteLine("==============================");
            Console.WriteLine("  0|  1|  2|  3|  4|  5|  6|");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < nums.Counter; i++)
            {
                Console.Write("|{0,2}|", nums[i]);
            }
            Console.WriteLine();
        }

        private static void RemoveElementAtIndex(CustomArrayList<int> nums)
        {
            Console.WriteLine();
            Console.WriteLine("RemoveAt(1) number {0}", nums.RemoveAt(1));
            Console.WriteLine("==============================");
            Console.WriteLine("  0|  1|  2|  3|  4|  5|  6|");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < nums.Counter; i++)
            {
                Console.Write("|{0,2}|", nums[i]);
            }
            Console.WriteLine();
        }

        private static void FewBasics(CustomArrayList<int> nums)
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

        private static void InsertElementAtIndex(CustomArrayList<int> nums)
        {
            Console.WriteLine();
            Console.WriteLine("Insert number (69) at index: (2)");
            Console.WriteLine("==============================");
            Console.WriteLine("  0|  1|  2|  3|  4|  5|  6|");
            Console.WriteLine("--------------------------");
            nums.Insert(2, 69);
            for (int i = 0; i < nums.Counter; i++)
            {
                Console.Write("|{0,2}|", nums[i]);
            }
            Console.WriteLine();
        }

        private static void PrintList(CustomArrayList<int> nums)
        {
            Console.WriteLine();
            Console.WriteLine("Print List<int>");
            Console.WriteLine("==============================");
            Console.WriteLine("  0|  1|  2|  3|  4|  5|  6|");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < nums.Counter; i++)
            {
                Console.Write("|{0,2}|", nums[i]);
            }
            Console.WriteLine();
        }
    }
}
