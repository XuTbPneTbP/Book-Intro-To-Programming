using System;

class DataValidation
{
    static void Main()
    {
        //Get Input Data
        Console.WriteLine("What time is it?");
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Minutes: ");
        int minutes = int.Parse(Console.ReadLine());

        bool IsValid = ValidHours(hours) && ValidMinutes(minutes);
        if (IsValid)
        {
            Console.WriteLine("The time is {0}:{1}", hours,minutes);
        }
        else
        {
            Console.WriteLine("Incorrect time!");
        }
    }
    // Check If Input Data Is Valid

    static bool ValidHours(int hours)
    {
        bool result = (hours >= 0) && (hours < 24);
        return result;
    }
    static bool ValidMinutes(int minutes)
    {
        bool result = (minutes >= 0) && (minutes <= 59);
        return result;
    }
}

