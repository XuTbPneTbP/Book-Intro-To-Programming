using System;

class AtSepareteLine
{
    static void Main()
    {
        Console.WriteLine("Enter your first name: ");
        string firstName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter your last name: ");
        string lastName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Your name is: ");
        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
    }
}

