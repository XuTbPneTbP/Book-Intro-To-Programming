using System;
using System.Collections.Generic;

namespace CountIntegerOccurrencesInArray
{
    class Dictonary_Key_Value
    {
        static void Main()
        {
            int[] array = new[] {3, 4, 4, 2, 3, 3, 4, 3, 2};

            IDictionary<int, int> repeatedNumbers = new SortedDictionary<int, int>();

            foreach (var number in array)
            {
                int count;
                if (!repeatedNumbers.TryGetValue(number, out count))
                {
                    count = 0;
                }
                repeatedNumbers[number] = count + 1;
            }

            foreach (var repeatedNumber in repeatedNumbers)
            {
                Console.WriteLine("{0}" + " => " + "{1}",repeatedNumber.Key, repeatedNumber.Value);
            }

        }
    }
}
