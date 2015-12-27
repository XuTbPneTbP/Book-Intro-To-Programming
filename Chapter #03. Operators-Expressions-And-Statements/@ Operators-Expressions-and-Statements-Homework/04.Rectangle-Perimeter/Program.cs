using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Rectangle_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter hight: ");
            double hight = double.Parse(Console.ReadLine());

            Console.WriteLine("rectangle perimeter is {0}", 2 * (width + hight));
            Console.WriteLine("rectangle area is {0}", width * hight);
        }
    }
}
