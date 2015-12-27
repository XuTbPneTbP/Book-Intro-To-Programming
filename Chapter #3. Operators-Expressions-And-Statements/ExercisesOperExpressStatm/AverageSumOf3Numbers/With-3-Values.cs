using System;

class With3Values
{
    static void Main()
    {
        // Shift + Alt + Enter => Full screen

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double average = (a + b + c)/3;
        Console.WriteLine("{0:F5}", average);


    }
}
