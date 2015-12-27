using System;

class FromNNumbers
{
    static void Main()
    {
        Console.Write("Enter lenght of numbers: ");
        int lenghtOfNumbers = int.Parse(Console.ReadLine());
        int sum = 0;
        double average = 0;
        int min = int.MaxValue;
        int max = int.MinValue;
        Console.WriteLine("Begin!!!: ");

        for (int i = 0; i < lenghtOfNumbers; i++)
        {            
            int numbers = int.Parse(Console.ReadLine());

            min = Math.Min(min, numbers);
            max = Math.Max(max, numbers);

            sum += numbers;
            
        }

        average = (double)sum / lenghtOfNumbers;

        Console.WriteLine("Min\t = " + min);
        Console.WriteLine("Max\t = " + max);
        Console.WriteLine("Sum\t = " + sum);
        Console.WriteLine("Avg\t = {0:F2}", average);
    }
}

