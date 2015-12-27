using System;
using System.Text;

class MethodsExample
{

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 10; i >= 1; i--)
        {
            PrintHyphens(i);
        }
    }

    static void PrintHyphens(int count)
    {
        for (int i = 1; i < count; i++)
        {
            Console.Write(" " + i);
        }
        Console.WriteLine();
    }

}
