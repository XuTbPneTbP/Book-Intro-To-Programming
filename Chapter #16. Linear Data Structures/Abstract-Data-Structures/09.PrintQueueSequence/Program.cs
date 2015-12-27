using System;
using System.Collections.Generic;

namespace _09.PrintQueueSequence
{
    class Program
    {
        static void Main()
        {
            int n = 2;
            int index = 0;

            Queue<int> nums = new Queue<int>();
            nums.Enqueue(n);

            while (nums.Count > 0)
            {
                if (index == 50)
                {
                    break;
                }

                int currentNumber = nums.Dequeue();
                int firstOperation = currentNumber + 1;
                int secondOperation = (2 * currentNumber) + 1;
                int thirdOperation = currentNumber + 2;

                Console.WriteLine("N + 1 = " + firstOperation);
                Console.WriteLine("(2 * N) + 1 = " + secondOperation);

                nums.Enqueue(firstOperation);
                nums.Enqueue(secondOperation);
                nums.Enqueue(thirdOperation);

                index++;
            }
            int counter = 1;
            foreach (var num in nums)
            {
                Console.WriteLine("{0} = > {1}", counter, num);
                counter++;
            }
        }
    }
}
