using System;

class CalculatingArea
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers to calculate trapezoid area:");
      
        Console.Write("Base a= ");
        double a =double .Parse(Console.ReadLine());
        Console.Write("Base b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Height h=");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("The formula is Area=((a+b)/2)*h  The area of trapezoid is: {0}", ((a + b) / 2) * h);
    }
}

