using System;
using System.Globalization;
using System.Threading;

    class SumWithDouble
    {
        static void Main()
        {
            Console.WriteLine("Please, enter three digits/numbers, following by pressing Enter:");
            Console.WriteLine();

            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("bg-BG");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("\n  {0} \n+ \n  {1} \n+ \n  {2} \n= \n  {3}", a, b, c, a + b + c);
            Console.WriteLine();

        Console.WriteLine("=======================================");

        }
    }

