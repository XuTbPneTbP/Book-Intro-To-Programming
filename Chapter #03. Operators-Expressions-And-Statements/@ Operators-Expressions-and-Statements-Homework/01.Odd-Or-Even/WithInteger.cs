using System;

class WithInteger
{
    static void Main()
    {
        bool valuex;
        Console.Write("Is your digit odd: ");
        int digit = int.Parse(Console.ReadLine());
        if (digit % 2 == 0)
        {
            Console.WriteLine("The number {0} is even. Reminder --> {1}", digit, digit % 2);
        }
        else
        {
            Console.WriteLine("The number {0} is odd. Reminder --> {1}", digit, digit % 2); 
        }      
        valuex = (digit%2==0);     
        Console.WriteLine(valuex);               
    }   
}

