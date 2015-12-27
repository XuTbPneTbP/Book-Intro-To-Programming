using System;

class ArrayExample
{
    static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Before modify the array parameters are: ");
        PrintArray(array);
        Console.WriteLine("Now we will modify the array!");
        ModifyArray(array);
        Console.WriteLine("After modifying the array the result is: ");
        PrintArray(array);
    }

    static void ModifyArray(int[] arrayParameters)
    {
        arrayParameters[0] = 999;
        arrayParameters[4] = 999;
        arrayParameters[9] = 999;
        Console.WriteLine("In ModifyArray() the parameters are: ");
        PrintArray(arrayParameters);
    }

    static void PrintArray(int[] arrayParameters)
    {
        Console.Write("[");
        int lenght = arrayParameters.Length;
        if (lenght > 0)
        {
            Console.Write(arrayParameters[0].ToString());
            for (int i = 1; i < lenght; i++)
            {
                Console.Write(", {0}",arrayParameters[i]);
            }
        }
        Console.WriteLine("]");
    }
}

