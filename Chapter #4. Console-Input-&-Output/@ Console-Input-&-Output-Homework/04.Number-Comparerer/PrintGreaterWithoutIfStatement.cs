using System;

class PrintGreaterWithoutIfStatement
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        double number1 = Double.Parse(Console.ReadLine());
        double number2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("The greater is: {0}", Math.Max(number1, number2));
    }
}

