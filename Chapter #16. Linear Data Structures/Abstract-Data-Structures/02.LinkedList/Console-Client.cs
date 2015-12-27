using System;

namespace _02.LinkedList
{
    public class ConsoleClient : ExecutionTime
    {
        static void Main()
        {
            CustomDynamicList<int> nums = new CustomDynamicList<int>();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 4 == 0)
                {
                    nums.Add(i);
                }
            }

            PrintCustomDynamic(nums);
            //MesureExecutionTime(nums);
        }

        
    }
}
