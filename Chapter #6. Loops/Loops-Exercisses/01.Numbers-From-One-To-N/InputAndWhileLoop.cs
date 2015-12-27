using System;

class InputAndWhileLoop
{
    static void Main()
    {
        Console.Write("Enter interval lenght in digits: ");

        int intervalTo = int.Parse(Console.ReadLine());

        int counter = 1;

        for (int i = 0; i < intervalTo; i++)
        {
            if (counter == intervalTo)
            {
                Console.WriteLine(counter);
                break;
            }
            Console.Write(counter + " + ");
            counter++;
        }
        
        Console.WriteLine();
        Console.WriteLine("===================================================");

        int sum = 0;
        int currentNumber = 1;

        while (currentNumber <= intervalTo)
        {
            sum += currentNumber;

            currentNumber++;

        }

        Console.WriteLine("Total sum = " + sum);
    }
}

