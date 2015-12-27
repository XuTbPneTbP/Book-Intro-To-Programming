using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
       
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine(DateTime.IsLeapYear(year));
            Console.Write("Enter year: ");
            year = int.Parse(Console.ReadLine());
        }
        while (year > 0);
        {
            Console.WriteLine("Asta La Vista Baby!! No such year");
        }
    }
}

