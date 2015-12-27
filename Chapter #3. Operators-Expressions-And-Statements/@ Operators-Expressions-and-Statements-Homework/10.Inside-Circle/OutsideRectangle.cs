using System;

class OutsideRectangle
{
    static void Main()
    {
        Console.Write("Enter x =  ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y =  ");
        double y = double.Parse(Console.ReadLine());
        double pointX = 0;
        double pointY = 0;
        double radius = 2;
        bool pythagorean = ((x - pointX) * (x -pointX) + (y - pointY) * (y - pointY) <= radius * radius);
        Console.WriteLine(pythagorean);
      //  bool rectangle = ((x > 5) || (x < -1) || (y > 1) || (y < -1));

        //Console.WriteLine(rectangle && pythagorean);
        
    }
}

