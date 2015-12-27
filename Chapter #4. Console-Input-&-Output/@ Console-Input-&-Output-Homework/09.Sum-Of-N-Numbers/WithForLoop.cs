using System;

class WithForLoop
{
    static void Main()
    {
        Console.Write("How many numbers do you wish to sum? : ");
        double numberCounter = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter {0} numbers following by Enter:", numberCounter);
        double sum = 0;

        for (double i = 0; i < numberCounter; i++)
        {           
            double numbers = double.Parse(Console.ReadLine());
            sum += numbers;
        }
        Console.WriteLine("The sum is: " + sum);
    }
}


