using System;

class Program
{
    static void Main()
    {
        Console.Write("Ente zeroes and ones randomly: ");

        string binaryInput = Convert.ToString(Console.ReadLine());

        long numberToDecimal = Convert.ToInt64(binaryInput, 2);

        Console.WriteLine("Decimal number => " + numberToDecimal);
    }
}
