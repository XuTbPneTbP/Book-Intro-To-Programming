using System;

class ExchangeAorB
{
    static void Main()
    {
        Console.Write("First = ");
        double first = int.Parse(Console.ReadLine());

        Console.Write("Second = ");
        double second = int.Parse(Console.ReadLine());

        double swap = first;

        if (first > second)
        {
            first = second;
            second = swap;
            Console.WriteLine("First now is {0}  second is {1}",first,second);
        }
        else
        {
            Console.WriteLine("First must be greater than Second!");
        }
    }
}

