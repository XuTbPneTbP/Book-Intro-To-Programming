using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter array size:");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < 4; i++)
        {
            Console.Write("arr index [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        foreach (int number in array)
        {
            Console.WriteLine(number);
        }
    }
}

