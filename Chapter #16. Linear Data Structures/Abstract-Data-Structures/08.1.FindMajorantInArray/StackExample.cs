using System;
using System.Collections.Generic;

namespace _08._1.FindMajorantInArray
{
    class StackExample
    {
        static void Main()
        {
            List<int> majorant = new List<int>();
            majorant.AddRange(new int[] { 2, 99, 101, -34, -1000, 3, 7, 3, 2, 3, 3, 3, 3, 22 });
            majorant.Sort();
            int scanTrough = ((majorant.Count - 1) / 2) + 1;
            foreach (var num in majorant)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Majorant count => {0} => N/2 + 1 = {1}", majorant.Count, scanTrough);

            Stack<int> stack = new Stack<int>();
            foreach (var num in majorant)
            {
                stack.Push(num);
            }
            int count = 0;
            Stack<int> stack2 = new Stack<int>();
            for (int i = 0; i < stack.Count -1; i++)
            {
                int num = stack.Pop();
                if (num == majorant[i])
                {
                    count++;
                    stack2.Push(majorant[i]);
                }
            }

            for (int i = 0; i < stack2.Count - 1; i++)
            {
                Console.WriteLine(stack2.Pop());
            }
            Console.WriteLine("Found " + count);
        }
    }
}
