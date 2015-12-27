using System;

class SquareValues
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("index [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("The tripled values are:");
        for (int index = 0; index < array.Length; index++)       
        {
            array[index] *= 3;            
            Console.WriteLine("index[{0}] = {1}",index, array[index]);        
        }
        Console.WriteLine("Now in reverse order: ");
        for (int index = array.Length-1; index >= 0; index-=2)
        {
            Console.WriteLine("index[{0}] = {1}", index, array[index]);
        }
    }   
}

