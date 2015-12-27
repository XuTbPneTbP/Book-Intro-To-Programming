using System;

class WithBool
{
    static void Main()
    {
        Console.Write("Are you girl? y/n: ");
        string sht = Convert.ToString(Console.ReadLine());       
        bool isFemale = (sht == "sht");
        Console.WriteLine(isFemale);    

    }
}
