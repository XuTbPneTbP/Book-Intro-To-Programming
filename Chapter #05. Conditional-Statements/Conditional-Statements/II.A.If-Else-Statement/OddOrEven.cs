using System;

class OddOrEven
{
    static void Main()
    {
        bool conditionalStatement;
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
        conditionalStatement = (digit % 2 == 0);
        Console.WriteLine(conditionalStatement); 
    }
}
