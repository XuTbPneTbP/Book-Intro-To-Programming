using System;
using System.Collections.Generic;

namespace _08.FindMajorantInArray
{
    class ListExample
    {
        static void Main()
        {
            List<int> majorant = new List<int>();
            majorant.AddRange(new int[] { 2, 99, 101, -34, -1000, 3, 3, 3, 2, 3, 2, 3, 3, 3, 22 });
            majorant.Sort();
            int scanTrough = ((majorant.Count - 1) / 2) + 1;
            foreach (var num in majorant)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Majorant count => {0} => N/2 + 1 = {1}", majorant.Count, scanTrough);
           
            int bestLength = 0;
            
            for (int j = 1; j < majorant.Count -1; j++)
            {
                if (majorant[j] == majorant[j - 1])
                {
                    bestLength++;
                    if (bestLength == scanTrough)
                    {
                        Console.WriteLine("Majorant ({0}) found => {1} times", majorant[j], bestLength);
                        break;
                    }
                    continue;
                }
                bestLength = 1;
            }
            if (bestLength < scanTrough)
            {
                Console.WriteLine("Majorant not found!");
            }

        }
    }
}
