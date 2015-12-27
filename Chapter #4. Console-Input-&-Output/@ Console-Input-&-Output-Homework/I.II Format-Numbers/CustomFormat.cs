using System;

class CustomFormat
{
    static void Main()
    {
        Console.WriteLine("{0:0.00}", 1);
        Console.WriteLine("{0:#.##}", 1.234);
        Console.WriteLine("{0:#####}", 12345.87);
        Console.WriteLine("{0:0#### ## ##}",31515919);
        Console.WriteLine("{0:%##}", 0.12845);
        Console.WriteLine("{0:C2}", 123.45);
    }
}

