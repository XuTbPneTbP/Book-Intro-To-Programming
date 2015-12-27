using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.WriteLine("Enter lenght: ");

        int lenghtTo = int.Parse(Console.ReadLine());

        for (int i = 0; i < lenghtTo; i++)
        {

            if ((i % (3*7) == 0))
            {
                Console.Write("Not divisible " + i + " ");
                continue;
            }

        } // End of loop bracket

        Console.WriteLine();

    } // End of static void Main()


}

