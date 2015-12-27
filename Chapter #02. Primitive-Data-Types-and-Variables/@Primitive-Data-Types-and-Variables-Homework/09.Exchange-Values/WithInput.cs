using System;

class WithInput
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers: ");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Before the exchange x = {0} and  y = {1}", x,y);
        x = x ^ y;
        y = y ^ x;
        x = x ^ y;
        Console.WriteLine("After the exchange x = {0} and y = {1}", x,y);
    }
}

