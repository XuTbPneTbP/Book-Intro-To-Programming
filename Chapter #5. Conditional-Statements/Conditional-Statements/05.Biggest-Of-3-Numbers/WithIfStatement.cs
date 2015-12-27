using System;

class WithIfStatement
{
    static void Main()
    {
        Console.Write("Enter 3 numbers separated by space: ");
        string[] whoIsBigger = Console.ReadLine().Split();
        double first = Convert.ToDouble(whoIsBigger[0]);
        double second = Convert.ToDouble(whoIsBigger[1]);
        double third = Convert.ToDouble(whoIsBigger[2]);
        if (first > second)
        {
            Console.WriteLine("The bigger is {0}", Math.Max(first,third));
        }
        else if (first < second)
        {
            Console.WriteLine("The bigger is {0}", Math.Max(second,third));
        }
    }
}

