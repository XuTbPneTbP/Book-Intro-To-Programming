using System;

class WithInput
{
    static void Main()
    {
        DateTime present = DateTime.Now;

        //Console.WriteLine("Enter your birth date in the format yyyy-mm-dd");
        DateTime myAge = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Your age now are: " + (present.Year - myAge.Year));
        Console.WriteLine("You will be at " + ((present.Year - myAge.Year)+10) + " after ten years");

        Console.WriteLine("Year of " + present.Year + " Month " + present.Month + " " + present.DayOfWeek + " " + present.Day + "th");
    }
}

