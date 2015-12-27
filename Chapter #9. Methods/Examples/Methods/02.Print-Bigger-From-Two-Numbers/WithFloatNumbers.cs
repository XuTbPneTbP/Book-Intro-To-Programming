using System;

class WithFloatNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter two floating point numbers:");
        float first = float.Parse(Console.ReadLine());
        float second = float.Parse(Console.ReadLine());
        PrintBigger(first,second);
    }
    static void PrintBigger(float first, float second)
    {
        float bigger = float.MinValue;
        bigger = first;
        if (second > bigger)
        {
            Console.WriteLine("The bigger is {0}", second);
        }
        Console.WriteLine("The bigger is {0}", bigger);       
    }
}

