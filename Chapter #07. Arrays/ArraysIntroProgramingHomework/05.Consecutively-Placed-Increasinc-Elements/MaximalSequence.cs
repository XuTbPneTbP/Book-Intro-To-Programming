using System;
using System.Diagnostics;

class MaximalSequence
{
    static void Main()
    {
        int[] array = new int[] { 1, 3, 5, 7, 2, 2, 3, 4, 8, 9 };
        int start = 0;
        int lenght = 1;
        int bestStart = 0;
        int bestLenght = 0;
        int counter = 0;

        for (int index = 0; index < array.Length; index++)
        {
            Console.WriteLine("Element[{0}] = {1}  ", index, array[index]);
        }
        Console.WriteLine();

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] + 1 == array[i])
            {
                lenght++;
                continue;
            }
            if (bestLenght < lenght)
            {
                bestLenght = lenght;
                bestStart = start;
            }
            lenght = 1;
            start = i;

            counter++;
        }
        Console.WriteLine("The best sequence is: ");
        for (int i = bestStart; i < bestStart + bestLenght; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
           
        Console.WriteLine(array.Length);
        Console.WriteLine(counter);
    }
}

