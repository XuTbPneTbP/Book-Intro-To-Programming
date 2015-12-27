using System;

class OnASingleLine
{
    static void Main()
    {
        Console.WriteLine("Enter lenght of the sequence: ");
        long lenghtOfSequence = int.Parse(Console.ReadLine());

        long fiboFirst = 0;
        long fiboOne = 1;
        long totalSum = 0;

        for (long i = 0; i < lenghtOfSequence; i++)
        {
            Console.Write(fiboFirst + " ");

            long fiboSumLastTwo = fiboFirst;

            fiboFirst = fiboOne;

            fiboOne = fiboSumLastTwo + fiboOne;

            totalSum += fiboSumLastTwo;
        }
        Console.WriteLine();
        Console.WriteLine("Total: " + totalSum);
    }
}

