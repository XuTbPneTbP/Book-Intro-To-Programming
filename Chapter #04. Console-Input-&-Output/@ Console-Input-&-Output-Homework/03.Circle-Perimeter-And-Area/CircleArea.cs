using System;
using System.Globalization;
using System.Threading;

class CircleArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        Console.WriteLine("======================================================");
        int hexNum = 2013;
        Console.WriteLine("Hexadecimal representation =>  |0x{0, -8:x}|", hexNum);
        double fractNegative = -165.78;
        Console.WriteLine("Fractional negative number =>  |{0, 10:f2}|", fractNegative);
        double fractPositive = 3234.4365;
        Console.WriteLine("Fractional positive number =>  |{0, 10:f2}|", fractPositive);
        Console.WriteLine("======================================================");

        Console.Write(" |Enter a digit and you will know the area of the circle: => ");  
        double radius = Double.Parse(Console.ReadLine());
        double pi = 3.14;
        double circleArea = (pi * radius * radius);
       
       
        Console.WriteLine("The area of the circle is |{0, 10:0.000}| something!!", circleArea);
        Console.WriteLine("The area of the circle is |{0, 10:0.000}|something!!", circleArea);
        Console.WriteLine("The area in Hexa is        |0x{0,-8:x}| something!!", (int)circleArea);
        Console.WriteLine();
        Console.WriteLine(" |Enter a digit for radius and you will know the perimeter of the circle => ");
        //Circle perimeter is found by the formula 2*pi*r, where "pi" is constant = 3.14 and "r" is the radius of the circle.
        double radiusA = Double.Parse(Console.ReadLine());
        double piPrim = 3.14;
        double perimeter = (2 * pi * radius);
        Console.WriteLine("The perimeter of the circle is {0}", perimeter);
    }
}

