using System;

class FahrenheitToCelsius
{
    static void Main()
    {
        Console.WriteLine("Enter your temp in Fahrneheit: ");
        double temp = double.Parse(Console.ReadLine());     
        SayIfThingsGoesReallyShit(FahrToCelss(temp));
    }
    static void SayIfThingsGoesReallyShit(double temp)
    {
        Console.WriteLine("Your temp in Cels is {0}", temp);
        if (temp >= 37)
        {
            Console.WriteLine("You are ill!!");
        }
        else if (temp < 27)
        {
            Console.WriteLine("You have  hypothermia!!");
        }
    }
    static double FahrToCelss(double tempInFahr)
    {
        double tempInCels = (tempInFahr - 32) * 5 / 9;
        return tempInCels;
    }
}

