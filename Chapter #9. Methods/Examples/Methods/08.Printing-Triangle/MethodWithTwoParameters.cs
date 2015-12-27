using System;

class MethodWithTwoParameters
{
    static void Main()
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());

        for (int line = 1; line <= number; line++)
        {
            PrintLine(10, line);
        }
        for (int line = number - 1; line >= 1; line--)
        {
            PrintLine(10, line);
        }
    }

    static void PrintLine(int start, int end)
    {
        for (int i = start; i < start + end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

