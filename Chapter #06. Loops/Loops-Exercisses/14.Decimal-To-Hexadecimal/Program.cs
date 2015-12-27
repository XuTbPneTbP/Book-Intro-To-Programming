using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter: ");
        int decimalN = int.Parse(Console.ReadLine());
        Console.WriteLine("0x{0} is Hexadecimal representation of the number {1}!!", Convert.ToString(decimalN, 16), decimalN);

        Console.WriteLine("|{0}| is the char representation of the {1}", (char) decimalN, decimalN);
    }
}
