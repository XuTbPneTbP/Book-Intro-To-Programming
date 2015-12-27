using System;
using System.Linq;

class SeriesOfIntegers
{
    static void Main()
    {
        Console.Write("Enter array lenght: ");
        int lenghtOfArray = int.Parse(Console.ReadLine());
        int[] arrayToCompare = new int[lenghtOfArray];      
        Console.WriteLine("Enter values: ");
        for (int i = 0; i < lenghtOfArray; i++)
        {
            arrayToCompare[i] = int.Parse(Console.ReadLine());           
        }    			
            Console.WriteLine("min --> {0} \nmax --> {1}",arrayToCompare.Min(),arrayToCompare.Max());      
    }
}

