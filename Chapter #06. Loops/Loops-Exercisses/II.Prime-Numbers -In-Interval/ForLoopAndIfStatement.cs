using System;

class ForLoopAndIfStatement
{
    static void Main()
    {
        Console.Write("Start interval from: ");

        int startNumber = int.Parse(Console.ReadLine());

        Console.Write("End interval at: ");

        int endNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The sequence of prime numbers is: ");

        for (int number = startNumber; number < endNumber; number++)
        {
            bool primeNumber = true;
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);

            while (divider <= maxDivider)
            {
                if (number % divider == 0)
                {
                    primeNumber = false;
                    break;
                }
                divider++;
            }

            if (primeNumber)
            {
                Console.Write(number + " ");
            }
        }

        Console.WriteLine();

    }
}

