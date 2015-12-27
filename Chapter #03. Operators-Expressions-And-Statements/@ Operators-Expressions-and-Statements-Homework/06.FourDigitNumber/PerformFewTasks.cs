using System;

class PerformFewTasks
{
    static void Main()
    {
        Console.WriteLine("Enter four digit number: ");
        int number = int.Parse(Console.ReadLine());
        int a = number % 10;
        int b = (number / 10) % 10;
        int c = (number / 100) % 10;
        int d = (number / 1000) % 10; 
        Console.WriteLine(a + " <-- fourth digit");
        Console.WriteLine(b + " <-- third digit");
        Console.WriteLine(c + " <-- second digit");
        Console.WriteLine(d + " <-- first digit");
        Console.WriteLine("The sum if the digits is: a + b + c + d = {0}", a+b+c+d);
        Console.WriteLine(a + "" + b + "" + c + "" + d + " <-- reversed");
        Console.WriteLine(a + "" + d + "" + c + "" + b + " <-- last digit in front");
        Console.WriteLine(d + "" + b + "" + c + "" + a + " <-- second and third digits exchanged");
    }
}

