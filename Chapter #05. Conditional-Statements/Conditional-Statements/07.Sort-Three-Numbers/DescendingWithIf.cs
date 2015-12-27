using System;
using System.Collections.Generic;
using System.Linq;

class DescendingWithIf
{
    static void Main()
    {
        Console.Write("Enter three digits separated by space: ");

        string[] numbers = Console.ReadLine().Split(' ');
         
        double one = Convert.ToDouble(numbers[0]);
        double two = Convert.ToDouble(numbers[1]);
        double three = Convert.ToDouble(numbers[2]);

        var descendingThisNumbers = from number in numbers
                                    orderby number descending
                                    select number;

        foreach (var number in descendingThisNumbers)
        {
            Console.WriteLine(number);
        }

        List<double> sortedNumbers = new List<double>();
        sortedNumbers.Add(one);
        sortedNumbers.Add(two);
        sortedNumbers.Add(three);
        sortedNumbers.Sort();

        foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }


    }
}

