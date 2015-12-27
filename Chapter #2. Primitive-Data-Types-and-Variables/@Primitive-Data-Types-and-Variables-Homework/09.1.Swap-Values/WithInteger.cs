using System;
using _09._1.Swap_Values;

class WithInteger : Swap
{
    static void Main()
    {
        int a = 18;
        int b = 12;
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("SWAP!!!");
        int oldA = a;
        int oldB = b;
        a = b;
        b = oldA;
        a = oldB;
        Console.WriteLine("a  = {0}", a);
        Console.WriteLine("b = {0}", b);

        SwapValue(4, 7);
    }
}

