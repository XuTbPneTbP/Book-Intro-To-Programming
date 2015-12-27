using System;

class Example
{
    static void Main()
    {
        //int number = int.Parse(Console.ReadLine());
        PrintNumber(5);
        float num = 4.0f;
        Console.WriteLine(num);
    }
    static void PrintNumber(float number)
    {
        Console.WriteLine("the float number is {0}",number);
    }
}

