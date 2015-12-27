using System;

class WithArray
{
    static void Main()
    {
        Console.Write("Period from: ");
        int periodA = int.Parse(Console.ReadLine());
        GethMonthName(periodA);
        Console.WriteLine();
        Console.Write("Period to: ");
        int periodB = int.Parse(Console.ReadLine());
        GethMonthName(periodB);
        Console.WriteLine();
        SayPeriod(periodA,periodB);
    }

    static void GethMonthName(int month)
    {
        string[] monthNames = new string[] {"January", "February", "March", "April", "May", "June", "July",                                           "August", "September", "October", "November", "December" };
        string monthName = monthNames[month - 1];
        Console.WriteLine(monthName);
    }

    static void SayPeriod(int startMonth, int endMonth)
    {
        int period = endMonth - startMonth;
        if (period < 0)
        {
            period = period + 12;
        }
        Console.Write("There is {0} months period from ", period);
        GethMonthName(startMonth);
        Console.Write("to ");
        GethMonthName(endMonth);
        Console.WriteLine();
    }
}

