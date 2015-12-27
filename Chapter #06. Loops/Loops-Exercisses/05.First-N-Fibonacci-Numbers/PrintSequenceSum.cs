using System;
using System.Text;

class PrintSequenceSum
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Enter Fibonacci sequence lenght: ");

        long lenght = long.Parse(Console.ReadLine());
        long zero = 0;
        long one = 1;
        long sequenceSumCounter = 0;

        for (long i = 0; i < lenght; i++)
        {
            Console.Write(zero);
            Console.Write('\u00a9' + " ");

            long sumOfZeroAndOne = zero;

            zero = one;
            one = sumOfZeroAndOne + one;
            sequenceSumCounter += sumOfZeroAndOne;
        }
        Console.WriteLine();
        Console.WriteLine("The sum of {0} Fibonacci numbers is: {1}",lenght,sequenceSumCounter);
    }
}

