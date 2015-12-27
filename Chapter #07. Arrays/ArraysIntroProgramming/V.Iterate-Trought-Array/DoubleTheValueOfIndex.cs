using System;

class DoubleTheValueOfIndex
{
    static void Main()
    {
        //Console.Write("Enter array[] size: ");
        //int size = int.Parse(Console.ReadLine());
        //int[] array = new int[size];
        //for (int i = 0; i < size; i++)
        //{
        //    Console.Write("index[{0}] = ", i);
        //    int value = int.Parse(Console.ReadLine());
        //}
        int[] arrayNew = { 2, 3, 4, 5 };
        Console.WriteLine("Output:");
        for (int i = 0; i < arrayNew.Length; i++)
        {
            arrayNew[i] = 2 * arrayNew[i];
            Console.Write(arrayNew[i] + " ");
        }
        Console.WriteLine();
    }
}

