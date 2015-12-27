using System;

namespace _14.PetyaDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter two digits who will be compared with precision eps = 0.000001");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double result = a - b;

            //(Math.Abs(x - 0.1) < 0.0000001)

            if (Math.Abs(a - b) < eps)
            {
                Console.WriteLine(result);
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine(result);
                Console.WriteLine("Not equal");
            }
        }
    }
}
