using System;

class PositiveOrNegative
{
    static void Main()
    {
        Console.WriteLine("{0,7}",123);
        Console.WriteLine("{0,10}",123);
        Console.Write("{0,-7}",567);
        Console.WriteLine("{0,7}",567);
        Console.WriteLine();
        Console.WriteLine("{0:x}",254);
        Console.WriteLine("{0:P}",0.254);
        Console.WriteLine("{0:c2}",254.5785);
        Console.WriteLine("{0:d5}",-254);
        Console.WriteLine("{0:e}",254);
        Console.WriteLine("{0:f4}",254.585);
    }
}

