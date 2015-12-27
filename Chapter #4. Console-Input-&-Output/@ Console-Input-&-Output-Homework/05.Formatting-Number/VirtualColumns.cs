using System;

class VirtualColumns
{
    static void Main()
    {
        int numberA = int.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double numberC = double.Parse(Console.ReadLine());
        Console.Write("|{0,-10:X}|" + Convert.ToString(numberA,2).PadLeft(10, '0'), numberA);
        Console.Write("|{0,10:f2}|",numberB);
        Console.Write( "{0, -10:f3}|",numberC);
        Console.WriteLine();
    }  
}

