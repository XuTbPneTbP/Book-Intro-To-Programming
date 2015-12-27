using System;
using System.Collections.Generic;

namespace _02.RemoveIntegersFromSequence
{
    class AppearOddNumberOfTimes
    {
        static void Main()
        {
            int[] numbers = new[] {4, 2, 1, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 2, 6};
            IDictionary<int, int> repeatedNumbers = new SortedDictionary<int, int>();
            foreach (var number in numbers)
            {
                int count;
                if (!repeatedNumbers.TryGetValue(number, out count))
                {
                    count = 0;
                }
                repeatedNumbers[number] = count + 1;
            }

            List<int> evenOccurrences = new List<int>();
            foreach (var repeatedNumber in repeatedNumbers)
            {
                if (repeatedNumber.Value % 2 == 0)
                {
                    evenOccurrences.Add(repeatedNumber.Key);
                }
            }

            Console.Write("{ ");
            Console.Write(string.Join(", ", evenOccurrences));
            Console.WriteLine(" }");
        }
    }
}
