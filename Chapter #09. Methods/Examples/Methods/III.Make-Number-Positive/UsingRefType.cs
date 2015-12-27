using System;

class UsingRefType
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        MakeNumberPositive(ref number);
        Console.WriteLine(number);
    }
    static void MakeNumberPositive(ref int number)
    {
        if (number < 0)
        {
            number = -number;
        }
    }
}

