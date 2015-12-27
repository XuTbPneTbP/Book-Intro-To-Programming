using System;

class MultiplyElementBy5
{
    static void Main()
    {        
        int[] array = new int[20];

        Console.WriteLine("Output: ");

        for (int index = 0; index < 20; index++)
        {
            array[index] = index;

            Console.WriteLine("index [{0}] = {1} --> index[{0}] = {2} ", index, array[index],  array[index] * 5);            
        }
    }
}

