using System;

class PythagoreanTheoremForCheck
{
    static void Main()
    {
        Console.Write("Enter x =  ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y =  ");               
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine();

        double pointX = 0;
        double pointY = 0;        
        double radius = 8;
        bool pythagorean = (x * x + y * y <= radius*radius);
        Console.WriteLine("(x * x) = {0}  \n    +  \n(y * y) = {1}  \n    = \n          {3} <= (radius * radius)  = {2}", x * x, y * y, radius * radius, (x * x + y * y));

        Console.WriteLine();
        Console.Write(pythagorean + " ");
        Console.WriteLine("The point is inside the circle");
        bool pythagoreanA = ((x - pointX) * (x - pointX) + (y - pointY) * (y - pointY) <= radius * radius);
        Console.WriteLine(pythagoreanA);
        
    }
}

