using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParametersAndReturnValue
{
    static void Main()
    {
        Console.WriteLine("Enter width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height:");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("width*height /2 = {0}",CalcTriangleArea(width,height));
    }
    static double CalcTriangleArea(double width, double height)
    {
        return width * height / 2;
    }
}

