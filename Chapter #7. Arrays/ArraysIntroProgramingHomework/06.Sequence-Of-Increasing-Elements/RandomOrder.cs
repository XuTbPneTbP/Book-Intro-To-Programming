using System;
using System.Collections.Generic;

namespace _06.Sequence_Of_Increasing_Elements
{
    class RandomOrder
    {
        static void Main()
        {
            int[] numbers = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
           HashSet<int> numbs = new HashSet<int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + 2 == numbers[j])
                    {
                        numbs.Add(numbers[i]);
                       // numbs.Add(numbers[j]);
                    }
                    
                }

                Console.WriteLine();

                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            List<int> newNumbs = new List<int>();
            foreach (var numb in numbs)
            {
                newNumbs.Add(numb);
            }

            newNumbs.Sort();

            foreach (var numb in newNumbs)
            {
                Console.WriteLine(numb);
            }

        }
    }
}
