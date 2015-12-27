using System;

class RecursiveFactorial
{
    static void Main()
    {
        Console.Write("n = ");
        decimal number = int.Parse(Console.ReadLine());

        decimal result = Factorial(number);
        Console.WriteLine("{0}! = {1}", number,result);
    }
    static decimal Factorial(decimal number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}

