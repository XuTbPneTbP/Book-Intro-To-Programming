using System;

class WithRef
{
    static void Main()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5 };
        PrintArray(arr);
        ChangeArray(ref arr);
        PrintArray(arr);
    }
    static void ChangeArray(ref int[] array)
    {
        array = new int[] { 13, 24, 35, 46, 57, 68, 79 };
    }
    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

