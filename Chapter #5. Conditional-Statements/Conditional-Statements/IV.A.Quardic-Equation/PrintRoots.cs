using System;

class PrintRoots
{
    static void Main()
    {
        Console.WriteLine("Enter 3 digits to find the roots in the equation ax^2 + bx +c = 0 :");

        double a, b, c, rootX1, rootX2;
        a = Double.Parse(Console.ReadLine());
        b = Double.Parse(Console.ReadLine());
        c = Double.Parse(Console.ReadLine());

        double discriminant = (b * b - (4 * a * c));
        if (discriminant == 0)
        {
            rootX1 = -b / (2 * a);
            rootX2 = -b / (2 * a);
            Console.WriteLine("X1 is {0}", rootX1);
            Console.WriteLine("X2 is {0}", rootX2);
        }
        else if (discriminant > 0)
        {
            rootX1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            rootX2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("X1 is {0}", rootX1);
            Console.WriteLine("X2 is {0}", rootX2);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("No real roots. Discriminat < 0");
        }
    }
}

