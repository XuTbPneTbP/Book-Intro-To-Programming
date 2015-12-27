using System;

class IntToHexa
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        string hexa = string.Format("{0:x2}", a);
        Console.WriteLine("{0} converted to hexadecimal is {1}", a, hexa);

        int b = 0xFE; // 254
        Console.WriteLine("{0} in hexa is {1:X}", b, b);
    }
}

