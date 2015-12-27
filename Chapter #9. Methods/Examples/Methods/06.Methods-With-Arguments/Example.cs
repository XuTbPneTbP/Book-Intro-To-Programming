using System;

class Example
{
    static void Main()
    {
        PrintSign(-8);
        int balance = 86;
        int amno = -23;
        PrintSign(balance);
        PrintSign(amno);
        PrintBigger(balance, amno);
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());       
        PrintSign(n);
        PrintSign(m);
        PrintBigger(n, m);
    } 
    static void PrintSign(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("The number {0} is + positive", number);
        }
        else if (number < 0)
        {
            Console.WriteLine("The number {0} is - negative", number);
        }
        else
        {
            Console.WriteLine("ZERO");
        }
    }
    static void PrintBigger(int n, int m)
    {
        int bigger = int.MinValue;
        bigger = n;
        if (m > bigger)
        {
            bigger = m;
        }
        Console.WriteLine("The bigger is {0}", bigger);
    }
}

