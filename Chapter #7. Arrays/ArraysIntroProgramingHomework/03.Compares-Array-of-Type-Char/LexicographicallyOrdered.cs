using System;
using System.Collections;
using System.Linq;

class LexicographicallyOrdered
{
    static void Main()
    {
        char[] firstArray = { 'a', 's', 'd' };
        char[] secondArray = { 'b', 'c', 'e' };
        char[] first = { 'a', 's', 'd' };

        int[] second = { 2, 4, 6 };
        int[] third = { 3, 5, 9 };

        Console.WriteLine(firstArray.SequenceEqual(secondArray));

        Console.WriteLine(second.SequenceEqual(third));
    }
}

