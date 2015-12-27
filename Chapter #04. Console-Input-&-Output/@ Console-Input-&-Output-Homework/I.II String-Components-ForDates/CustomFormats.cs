using System;

class CustomFormats
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        DateTime fantase = new DateTime(3078, 02, 12, 23, 17, 48);
        Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", now);
        Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}",fantase);
        Console.WriteLine("{0:dd.MM.yyyy}",now);

        Console.WriteLine("===============================================");

        Console.WriteLine("{0:G}", DayOfWeek.Friday);

    }
}

