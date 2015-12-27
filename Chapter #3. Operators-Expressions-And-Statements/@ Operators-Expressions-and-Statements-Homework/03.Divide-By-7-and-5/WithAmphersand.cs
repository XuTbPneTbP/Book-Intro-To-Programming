using System;

class WithAmphersand
{
    static void Main()
    {
        Console.WriteLine("Divide a number to 5 and 7 and check if there is  no reminder:  ");
        int divided = int.Parse(Console.ReadLine());
        bool value = ((divided % 7 == 0) && (divided % 5 == 0));

        Console.WriteLine(value);

    }
}

