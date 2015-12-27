using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _05.UnionAndIntersectionOfLists
{
    class Program
    {
         static void Main()
         {
             //ShowExample();
             //BlqBlq();
             Console.WriteLine(":)");
         }

        static void BlqBlq()
        {
            List<int> nums = new List<int>();
            nums.Add(2);
            nums.Add(-10);
            Console.WriteLine("*");
            PrintList(nums);
            Console.WriteLine("*");
            List<int> numz = new List<int>();
            numz.Add(2);
            numz.Add(0);
            Console.WriteLine("*");
            PrintList(numz);
            Console.WriteLine("*");

            List<int> newOne = UnionOfLists(numz, nums);
            Console.WriteLine("Union :");
            PrintList(newOne);
        }

        static void ShowExample()
        {
            List<int> someInts1 = new List<int>();
            int[] nums1 = {12, 18, 6, 37, 1};
            ExecuteList(someInts1, nums1);

            List<int> someInts2 = new List<int>();
            int[] nums2 = {12, 19, 66, 701, 1};
            ExecuteList(someInts2, nums2);

            Console.WriteLine("Union of lists :");
            ExecuteUnion(someInts1, someInts2);

            Console.WriteLine("Intersect of lists : ");
            ExecuteIntersect(someInts1, someInts2);
        }

        static void ExecuteIntersect(List<int> someInts1, List<int> someInts2)
        {
            List<int> intersectList = IntersectionOfLists(someInts1, someInts2);
            PrintList(intersectList);
            ContainZ(intersectList);
            Console.WriteLine("##################################");
        }

        static void ExecuteUnion(List<int> someInts1, List<int> someInts2)
        {
            List<int> unionList = UnionOfLists(someInts1, someInts2);
            PrintList(unionList);
            ContainZ(unionList);
            Console.WriteLine("##################################");
        }

        static void ExecuteList(List<int> someInts1, int[] nums1)
        {
            someInts1.AddRange(nums1);
            Console.WriteLine("List 1 :");
            PrintList(someInts1);
            ContainZ(someInts1);
            Console.WriteLine("##################################");
        }

        static void ContainZ(List<int> someInts)
        {
            Console.WriteLine("Contains 66 = > " + someInts.Contains(66));
            Console.WriteLine("Contains 18 = > " + someInts.Contains(18));
        }

        static List<int> IntersectionOfLists(List<int> someInts1, List<int> someInts2)
        {
            List<int> intesect = new List<int>();
            foreach (var number in someInts1)
            {
                if (someInts2.Contains(number))
                {
                    intesect.Add(number);
                }
            }

            return intesect;
        }

        static List<int> UnionOfLists(List<int> someInts1, List<int> someInts2)
     {
         List<int> union = new List<int>();
         union.AddRange(someInts1);

         foreach (var number in someInts2)
         {
             if (!union.Contains(number))
             {
                 union.Add(number);
             }
         }
         return union;
     }

        static void PrintList(List<int> someInts)
        {
            //Console.Write("{ ");
            foreach (var number in someInts)
            {
                Console.Write("|" + number);
            }
            Console.WriteLine("|");
            //Console.WriteLine("}");
        }

    }
}
