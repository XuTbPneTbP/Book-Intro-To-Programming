using System;

class IsFemaleTask
{
    static void Main()
    {
        Console.WriteLine("Are you girl? y/n");
        string a = Convert.ToString(Console.ReadLine());
        while ((a != "y") || (a != "n"))
        {

            if (a == "y")
            {
                Console.WriteLine("You must be a female.");
                break;

            }
            else if (a == "n")
            {
                Console.WriteLine("OK then -> you are not a female!");
                break;
            }
                // save program from carshing when validate chars different from 'y' and 'n'.
            Console.WriteLine("TrY AgaIn");
            a = Console.ReadLine();
        }
    }
}

