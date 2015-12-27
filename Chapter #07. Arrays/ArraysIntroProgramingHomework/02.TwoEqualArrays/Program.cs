using System;

class Program
{
    static void Main()
    {
        int[] first = { 2, 4, 6 };
        int[] second = { 2, 4, 6 };
        int[] third = { 3, 5, 9 };
        bool equal = true;
        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != third[i])
            {
                equal = false;
                break;
            }            
        }
        Console.WriteLine("Are equal? {0}",equal);
    }
}

