using System;

class ConsecutiveLenght
{
    static void Main()
    {
        int[] array = new int[] { 1, 1, 2, 3, 555, 4, 34, 4, 8, 4, 4, 6, 6, 888, 8, 8, 8, 8, 7, 7, 77 };
        int start = 0;
        int lenght = 1;
        int bestStart = 0;
        int bestLenght = 0;

        for (int index = 0; index < array.Length; index++)
        {
            Console.WriteLine("Element[{0}] = {1}  ", index, array[index]);
        }
        Console.WriteLine();

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == array[i])
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
        }
        Console.WriteLine("The best sequence is: ");
        for (int i = bestStart; i < bestStart + bestLenght; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}


