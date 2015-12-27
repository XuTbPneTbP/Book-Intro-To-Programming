using System;

class WithMethod
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        PrintSign(number);
        
    }

    static void PrintSign(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("The number {0} is + positive",number);
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is - negative", number);
        }
        else
        {
            Console.WriteLine("ZERO");
        }
    }
}

