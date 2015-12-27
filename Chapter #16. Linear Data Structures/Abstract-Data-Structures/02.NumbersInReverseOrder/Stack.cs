using System;
using System.Collections.Generic;

namespace _02.NumbersInReverseOrder
{
    class Stack
    {
        static void Main()
        {
            Stack<int> nums = new Stack<int>();
            nums.Push(2);
            nums.Push(4);
            nums.Push(6);
            nums.Push(8);
            while (nums.Count > 0)
            {
                int num = nums.Pop();
                Console.WriteLine(num);
            }
        }
    }
}
