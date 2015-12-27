using System;

class Example
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers.");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        if (second > first)
        {
            first = second; //Присвояваме от дясно на ляво. В обратния случай ще принтира first.
        }
        Console.WriteLine("The greater number is: {0}", first);
    }
}

