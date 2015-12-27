using System;

class PrintMyName
{
    static void Main()
    {
        string firstName = "Анелия";
        // middleName = " Jey";
        string lastName = " Петкова";
        //string fullName = firstName + middleName + lastName;
        Console.Write("Your name is: ");
        string fullName = firstName + lastName;
        Console.WriteLine(fullName + "!");
        Console.WriteLine("You have a lot of movies in your head!");
    }
}

